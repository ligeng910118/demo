using System;
using System.Collections.Generic;
using System.Linq;
namespace simpleapp.AddClass
{
    public class LinqWNT
    {
        public List<string> myCars = new List<string> { "yugo", "atz", "bmw" };
        public List<string> yourCars = new List<string> { "bmw", "atz", "saab" };

        public static void LinqWNTMain()
        {
            LinqWNT myLinqWNT = new LinqWNT();
            //myLinqWNT.DisplayDiff();
            //myLinqWNT.DisplayIntersection();
            //myLinqWNT.DisplayUnion();
            //myLinqWNT.DisplayConcat();
            myLinqWNT.DisplayConcatNoDups();
        }

        public void DisplayConcatNoDups()
        {
            var carConcat = (from c in yourCars select c).Concat(from c2 in myCars select c2);
            foreach (string s in carConcat.Distinct())
                Console.WriteLine(s); 
        }

        public void DisplayConcat()
        {
            var carConcat = (from c in yourCars select c).Concat(from c2 in myCars select c2);
            foreach (string s in carConcat)
                Console.WriteLine(s);
        }

        public void DisplayUnion()
        {
            var carUnion = (from c in yourCars select c).Union(from c2 in myCars select c2);
            foreach (string s in carUnion)
                Console.WriteLine(s);
        }

        public void DisplayIntersection()
        {
            var carIntersection = (from c in yourCars select c).Intersect(from c2 in myCars select c2);
            foreach (string s in carIntersection)
                Console.WriteLine(s);
        }

        public void DisplayDiff()
        {
            var carDiff = (from c in yourCars select c).Except(from c2 in myCars select c2);

            foreach (string s in carDiff)
                Console.WriteLine(s);
        }
    }
}
