using System;
namespace simpleapp.AddClass
{
    public class CarReferenceClass
    {
        public class Car
        {
            public int CurrentSpeed { get; set; }
            public string PetName { get; set; }

            public Car(string name,int speed)
            {
                CurrentSpeed = speed;
                PetName = name;
            }

			public override string ToString()
			{
                return string.Format("{0} is going {1} MPH",PetName,CurrentSpeed);
			}
		}
        public static void CarReferenceClassMain()
        {
            Car refToMyCar = new Car("zippoy", 10);
            Console.WriteLine(refToMyCar.ToString());
        }


    }
}
