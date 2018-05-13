using System;
namespace simpleapp.AddClass
{
    public class CarClass
    {
        public readonly int maxSpeed;
        private int currSpeed;

        public CarClass(int max)
        {
            maxSpeed = max;
        }
        public CarClass()
        {
            maxSpeed = 55;
        }

        public int Speed
        {
            get { return currSpeed; }
            set {
                currSpeed = value;
                if (currSpeed > maxSpeed)
                    currSpeed = maxSpeed;
            }
        }

        class MiniVan:CarClass
        {
            
        }


        public static void CarMain()
        {
            MiniVan myCar = new MiniVan();
            myCar.Speed = 10;
            Console.WriteLine("my car is going {0} mph", myCar.Speed);
            
            //CarClass myCar = new CarClass(80);
            //myCar.Speed = 50;
            //Console.WriteLine("my car is going {0} mph", myCar.Speed);


        }
    }

}
