using System;
using System.Collections.Generic;
using System.Linq;
namespace simpleapp.AddClass
{
    public class LinqOverCustomObject
    {
        public static void LinqOverCustomObjectMain()
        {
            List<LinqCar> myCars = new List<LinqCar>()
            {
                new LinqCar{PetName = "henry",Color="silver",Speed=100,Make="bmw"},
                new LinqCar{PetName = "daisy",Color="tan",Speed=90,Make="bmw"},
                new LinqCar{PetName = "mary",Color="black",Speed=55,Make="vm"},
                new LinqCar{PetName = "clunker",Color="rust",Speed=5,Make="yugo"},
                new LinqCar{PetName = "melvin",Color="white",Speed=43,Make="ford"},
            };
            GetFastCars(myCars);
        }



        public static void GetFastCars(List<LinqCar> myCars)
        {
            var fastCars = from c in myCars where c.Speed > 55 select c;
            foreach (var car in fastCars)
                Console.WriteLine("{0} is going too fast!",car.PetName);
        }
    }


    public class LinqCar
    {
        public string PetName { get; set; }
        public string Color { get; set; }
        public int Speed { get; set; }
        public string Make { get; set; }
    }
}
