using System;
namespace simpleapp.AddClass
{
    public class OperatorClass
    {
        const int MaxValue = 100;
        const int MinValue = 0;
        public int _theValue = 0;
        public int TheValue
        {
            get { return _theValue; }
            set
            {
                if (value < MinValue)
                    _theValue = 0;
                else
                    _theValue = value > MaxValue ? MaxValue : value;
            }
        }

        public static OperatorClass operator-(OperatorClass x)
        {
            OperatorClass li = new OperatorClass();
            li.TheValue = 0;
            return li;
        }

        public static OperatorClass operator-(OperatorClass x,OperatorClass y)
        {
            OperatorClass li = new OperatorClass();
            li.TheValue = x.TheValue - y.TheValue;
            return li;
        }

        public static OperatorClass operator+(OperatorClass x,double y)
        {
            OperatorClass li = new OperatorClass();
            li.TheValue = x.TheValue + (int)y;
            return li;
        }

        public static void OperatorClassMain()
        {
            OperatorClass li1 = new OperatorClass();
            OperatorClass li2 = new OperatorClass();
            OperatorClass li3 = new OperatorClass();
            li1.TheValue = 10;li2.TheValue = 26;
            Console.WriteLine("li1:{0},li2:{1}",li1.TheValue,li2.TheValue);
            li3 = -li1;
            Console.WriteLine("-{0} = {1}",li1.TheValue,li3.TheValue);
            li3 = li2 - li1;
            Console.WriteLine("{0}-{1}={2}",li2.TheValue,li1.TheValue,li3.TheValue);
            li3 = li1 - li2;
            Console.WriteLine("{0}-{1}={2}",li1.TheValue,li2.TheValue,li3.TheValue);
        }

        public static void GetClassName()
        {
            OperatorClass op = new OperatorClass();
            Console.WriteLine("{0}",op.GetType().Name);
        }
    }
}
