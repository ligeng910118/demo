using System;
using System.Collections.Generic;
using System.Linq;
namespace simpleapp.AddClass
{
    public class LinqClass
    {
        public static void LinqClassMain()
        {
            QueryOverStrings();
        }


        public static void QueryOverStrings()
        {
            string[] currntVideoGames = {
                "morrowind",
                "uncharted 2",
                "fallout 3",
                "daxter",
                "system shock 2",
            };

            IEnumerable<string> subset = from g in currntVideoGames
                                          where g.Contains(" ")
                                          orderby g
                                          select g;
            foreach(string s in subset)
            {
                Console.WriteLine("item:{0}",s);
            }

            ReflectOverQueryResults(subset);
        }

        public static void ReflectOverQueryResults(object resultSet)
        {
            Console.WriteLine("result is of type:{0}",resultSet.GetType().Name);
            Console.WriteLine("result location:{0}",resultSet.GetType().Assembly.GetName().Name);
        }
    }
}
