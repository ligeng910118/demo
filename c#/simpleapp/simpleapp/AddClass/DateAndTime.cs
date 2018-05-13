
using System;
using System.Linq;
namespace simpleapp.AddClass
{
    public class DateAndTime
    {


        public static void  DateAndTimeShow()
        {
            DateTime dt = new DateTime(2010,10,12);
            Console.WriteLine("the day of {0} is {1}",dt.Date,dt.DayOfWeek);
            dt = dt.AddMonths(2);
            Console.WriteLine("daylight saving:{0}",dt.IsDaylightSavingTime());
            TimeSpan ts = new TimeSpan(4, 30, 0);
            Console.WriteLine(ts);

            Console.WriteLine(ts.Subtract(new TimeSpan(0,15,0)));
        }

        public static void EscapeChars()
        {
            Console.WriteLine("model\t color\t speed\t pet name\a");
            Console.WriteLine("everyone loves \"hello world\" \a");
            Console.WriteLine("all finished.\n\n\n\a");
        }

        public static void QueryOverInts()
        {
            int[] numbers = { 10,20,30,1,2,3};
            var subset = from i in numbers where i < 10 select i;
            Console.WriteLine("values in subset:");
            foreach(var i in subset)
            {
                Console.WriteLine("{0}", i);
            }
            Console.WriteLine("subset is a:{0}",subset.GetType().Name);
            Console.WriteLine("subset is defined in {0}",subset.GetType().Namespace);
        }
    }
}
