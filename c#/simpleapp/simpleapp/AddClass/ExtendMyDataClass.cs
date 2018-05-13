using System;
namespace simpleapp.AddClass
{
    public static class ExtendMyDataClass
    {
        public static void ExtendMyDataMain()
        {
            MyDataClass md = new MyDataClass(3, 4, 5);
            Console.WriteLine("average:{0}",md.Average());
        }

        public static double Average(this MyDataClass md)
        {
            return md.Sum() / 3;
        }
    }
}
