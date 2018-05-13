using System;
namespace simpleapp.AddClass
{
    public class myClass
    {
        public int Val = 20;
    }
    public class RefClass
    {
        public RefClass()
        {
        }

        public static void myMethod(myClass f1,int f2)
        {
            f1.Val = f1.Val + 5;
            f2 = f2 + 5;
            Console.WriteLine("f1.val:{0},f2:{1}", f1.Val, f2);
        }

        public static void RefClassMain()
        {
            myClass a1 = new myClass();
            int a2 = 10;
            myMethod(a1,a2);
            Console.WriteLine("f1.val:{0},f2:{1}", a1.Val, a2);
        }
    }
}

