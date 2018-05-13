using System;
namespace simpleapp.AddClass
{
    public class CarDelegateClass
    {
        public void CarDelegateClassMain()
        {
            Car c1 = new Car("slugbug",100,10);
            c1.RegisterWithCarEngine(new Car.CarEngineHandler(OnCarEngineEvent));
            Console.WriteLine("**** speeding up ****");
            for (int i = 0; i < 6; i++)
                c1.Accelerate(20);
        }

        public static void OnCarEngineEvent(string msg)
        {
            Console.WriteLine("=>{0}",msg);
        }

        public class Car
        {
            public int CurrentSpeed { get; set; }
            public int MaxSpeed { get; set; }
            public string PetName { get; set; }

            public delegate void CarEngineHandler(string msgForCaller);

            private CarEngineHandler listOfHandlers;

            public void RegisterWithCarEngine(CarEngineHandler methodToCall)
            {
                listOfHandlers = methodToCall;
            }

            private bool carIsDead;

            public Car() { MaxSpeed = 100; }

            public Car(string name,int maxSp,int currSp)
            {
                CurrentSpeed = currSp;
                MaxSpeed = maxSp;
                PetName = name;
            }

            public void Accelerate(int delta)
            {
                if(carIsDead)
                {
                    if(listOfHandlers != null)
                    {
                        listOfHandlers("sorry,this car is dead..");
                    }
                }else{
                    CurrentSpeed += delta;
                    if(10 == (MaxSpeed - CurrentSpeed)&&listOfHandlers != null)
                    {
                        listOfHandlers("careful buddy,gonna blow");
                    }
                    if (CurrentSpeed >= MaxSpeed)
                        carIsDead = true;
                    else
                        Console.WriteLine("currentspeed = {0}",CurrentSpeed);
                }
            }
        }
    }
}
