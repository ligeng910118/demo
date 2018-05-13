using System;
using System.Collections;
namespace simpleapp.AddClass
{
    public class IEnumberableClass
    {
        public static void IEnumberableClassMain()
        {
            Garage carLot = new Garage();
            foreach(Car c in carLot.GetTheCars(true))
            {
                Console.WriteLine("{0} is going {1} MPH",c.PetName,c.CurrentSpeed);
            }
        }

        public class Garage:IEnumerable
        {
            private Car[] carArray = new Car[4];

            public Garage()
            {
                carArray[0] = new Car("rusty",30);
                carArray[1] = new Car("clunker", 55);
                carArray[2] = new Car("zippy", 30);
                carArray[3] = new Car("fred", 30);
            }
            //自带的GetEnumerator
            //public IEnumerator GetEnumerator()
            //{
            //    return carArray.GetEnumerator();
            //}
            //自定义GetEnumerator
            public IEnumerator GetEnumerator()
            {
                foreach(Car c in carArray)
                {
                    yield return c;
                }
            }

            public IEnumerable GetTheCars(bool ReturnRevesed)
            {
                if(ReturnRevesed)
                {
                    for (int i = carArray.Length; i != 0;i--)
                    {
                        yield return carArray[i - 1];
                    }
                }else{
                    foreach(Car c in carArray)
                    {
                        yield return c;
                    }
                }
            }

        }

        public class Radio
        {
            public void TurnOn(bool on)
            {
                if (on)
                    Console.WriteLine("jamming..");
                else
                    Console.WriteLine("quiet time..");
            }
        }

        public class Car
        {
            public const int MaxSpeed = 100;
            public int CurrentSpeed { get; set; }
            public string PetName { get; set; }

            private bool carIsDead;

            private Radio theMusicBox = new Radio();

            public Car() { }

            public Car(string name, int speed)
            {
                CurrentSpeed = speed;
                PetName = name;
            }

            public void CrankTunes(bool state)
            {
                theMusicBox.TurnOn(state);
            }

            public void Accelerate(int delta)
            {
                if (carIsDead)
                {
                    Console.WriteLine("{0} is out of order...", PetName);
                }
                else
                {
                    CurrentSpeed += delta;
                    if (CurrentSpeed > MaxSpeed)
                    {
                        CurrentSpeed = 0;
                        carIsDead = true;
                        //Exception ex = new Exception(string.Format("{0} has overheated!", PetName));
                        //ex.HelpLink = "http://www.CarsRUs.com";
                        //ex.Data.Add("time",string.Format("the car exploded at {0}",DateTime.Now));
                        //ex.Data.Add("cause","you have a lead foot");
                        CustomClass ex = new CustomClass(string.Format("{0} has overheated!", PetName), "you have a lead foot", DateTime.Now);
                        throw ex;
                    }
                    else
                    {
                        Console.WriteLine("=> CurrentSpeed = {0}", CurrentSpeed);
                    }
                }
            }
        }
    }
}
