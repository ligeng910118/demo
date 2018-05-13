using System;
namespace simpleapp.AddClass
{
    public partial class myPartialClass
    {
        partial void PrintSum(int x, int y);
        public void Add(int x,int y)
        {
            PrintSum(x, y);
        }
    }

    public partial class myPartialClass
    {
		partial void PrintSum(int x, int y)
		{
            Console.WriteLine("sum is {0}",x+y);
		}
	}
    public class PartialClass
    {
        public PartialClass()
        {
        }

        public static void PartialMain()
        {
            myPartialClass my = new myPartialClass();
            my.Add(5, 6);
        }
    }
}
