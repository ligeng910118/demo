using System;
using System.Collections.Generic;
using System.Linq;
namespace simpleapp.AddClass
{
    public class LinqRetValuesClass
    {
        public static void LinqRetValuesClassMain()
        {
            IEnumerable<string> subset = GetStringSubset();

            foreach (string item in subset)
                Console.WriteLine(item);
        }

        public static IEnumerable<string> GetStringSubset()
        {
            string[] colors = { "light red", "green", "yellow", "dark red","red","purple"};
            IEnumerable<string> theRedColors = from c in colors
                                               where c.Contains("red")
                                               select c;
            return theRedColors;
        }
    }
}
