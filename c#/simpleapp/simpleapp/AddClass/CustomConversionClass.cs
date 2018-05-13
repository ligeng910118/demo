using System;
namespace simpleapp.AddClass
{
    public class CustomConversionClass
    {
        public static void CustomConversionClassMain()
        {
            Rectangle r = new Rectangle(15, 4);
            Console.WriteLine(r.ToString());
            r.Draw();
            Console.WriteLine();

            //Square s = (Square)r;
            //Console.WriteLine(s.ToString());
            //s.Draw();

            //显性转换
            //Square sq2 = (Square)90;
            //Console.WriteLine("sq2 = {0}", sq2.Lenght);

            //int side = (int)sq2;
            //Console.WriteLine("side length of sql = {0}",side);

            //隐性转换
            Square s3 = new Square(7);
            Rectangle rect2 = s3;
            Console.WriteLine("rect2 width {0} heigth {1}",rect2.Width,rect2.Height);

            Square s4 = new Square(3);
            Rectangle rect3 = (Rectangle)s4;
            Console.WriteLine("rect3 width {0} heigth {1}", rect3.Width, rect3.Height);
        }

        public class Rectangle
        {
            public int Width { get; set; }
            public int Height { get; set; }

            public Rectangle(int x, int b)
            {
                Width = x;
                Height = b;
            }


            public void Draw()
            {
                for (int i = 0; i < Height; i++)
                {
                    for (int j = 0; j < Width;j++)
                    {
                        Console.Write("*");
                    }
                    Console.WriteLine();
                }
            }

			public override string ToString()
			{
                return string.Format("[width = {0},height = {1}]",Width,Height);
			}

            public static implicit operator Rectangle(Square s)
            {
                return new Rectangle(s.Lenght * 2,s.Lenght);
            }
		}

        public class Square
        {
            public int Lenght { get; set; }

            public Square(int l)
            {
                Lenght = l;
            }

            public void Draw()
            {
                for (int i = 0; i < Lenght; i++)
                {
                    for (int j = 0; j < Lenght; j++)
                    {
                        Console.Write("*");
                    }
                    Console.WriteLine();
                }
            }

			public override string ToString()
			{
                return string.Format("[length = {0}]",Lenght);
			}

            //public static explicit operator Square(Rectangle r)
            //{               
            //    return new Square(r.Height);
            //}

            public static explicit operator Square(int sideLength)
            {
                return new Square(sideLength);
            }

            public static explicit operator int(Square s)
            { return s.Lenght; }
		}

    }
}
