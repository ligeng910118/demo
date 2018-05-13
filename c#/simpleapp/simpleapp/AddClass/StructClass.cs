using System;
namespace simpleapp.AddClass
{
    struct Point
    {
        public int x;
        public int y;

        public Point(int xPos, int yPos)
        {
            x = xPos;
            y = yPos;
        }

        public void Display()
        {
            Console.WriteLine("x={0},y={1}", x, y);
        }

    }
    public class StructClass
    {
        public StructClass()
        {
        }

        public static void StructInt()
        {
            Point myPoint = new Point(50, 60);
            myPoint.Display();
        }

        public static void StructAndClass()
        {
            Rectangle r1 = new Rectangle("first rect",10,20);
            Rectangle r2 = r1;
            r2.rectInfo.infoString = "this is new info";
            r2.rectLeft = 444;
            r2.display();
            r1.display();
        }
    }

    public class ShapeInfo
    {
        public string infoString;
        public ShapeInfo(string info) { infoString = info; }
    }

    struct Rectangle
    {
        public int rectTop, rectLeft;
        public ShapeInfo rectInfo;
        public Rectangle(string info,int top,int left)
        {
            rectInfo = new ShapeInfo(info);
            rectTop = top;
            rectLeft = left;
        }

        public void display()
        {
            Console.WriteLine("string={0},top={1},left={2}",rectInfo.infoString,rectTop,rectLeft);
        }
    }
}
