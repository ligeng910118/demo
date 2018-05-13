using System;
namespace simpleapp.AddClass
{
    class D
    {
        int menu1;
        static int menu2;
        public void SetVars(int v1,int v2)
        {
            menu1 = v1;
            menu2 = v2;
        }

        public void Display(string str)
        {
            Console.WriteLine("{0}:menu1={1},menu2={2}", str, menu1, menu2);
        }
    }

    public class StaticClass
    {
        public StaticClass()
        {
        }

        public static void StaticMain()
        {
            D d1 = new D(), d2 = new D();
            d1.SetVars(2, 4);
            d1.Display("d1");

            d2.SetVars(12, 17);
            d2.Display("d2");

            d1.Display("d1");
        }
    }
}
