using System;
using System.Collections;
namespace simpleapp.AddClass
{
    public class ExceptionClass
    {
        public static void ExceptionClassMain()
        {
            Car myCar = new Car("zippy",20);
            myCar.CrankTunes(true);
            //try{
            //    for (int i = 0; i < 10; i++)
            //        myCar.Accelerate(10);
            //}catch(Exception e)
            //{
            //    ExceptionClass.DataExcepttion(e);
            //    //ExceptionClass.HelpLinkException(e);
            //    //ExceptionClass.StackTrace(e);
            //    //ExceptionClass.TargetSiteException(e);
            //    //ExceptionClass.normalExcepttion(e);
            //}
           
            try{
                for (int i = 0; i < 10; i++)
                   myCar.Accelerate(10);
            }catch(CustomClass e)
            {
                ExceptionClass.CustomException(e);
            }
        }

        public static void CustomException(CustomClass e)
        {
            Console.WriteLine(e.Message);
            Console.WriteLine(e.ErrorTimeStamp);
            Console.WriteLine(e.CauseOfError);
        }

        public static void normalExcepttion(Exception e)
        {
            Console.WriteLine("message:{0}", e.Message);
            Console.WriteLine("method:{0}", e.TargetSite);
            Console.WriteLine("source:{0}", e.Source);
        }

        public static void TargetSiteException(Exception e)
        {
            Console.WriteLine("member name:{0}",e.TargetSite);
            Console.WriteLine("class defining member:{0}",e.TargetSite.DeclaringType);
            Console.WriteLine("member type:{0}",e.TargetSite.MemberType);
        }

        public static void StackTrace(Exception e)
        {
            Console.WriteLine("stack:{0}",e.StackTrace);
        }

        public static void HelpLinkException(Exception e)
        {
            Console.WriteLine("help link : {0}",e.HelpLink);
        }

        public static void DataExcepttion(Exception e)
        {
            Console.WriteLine("custom data:");
            if(e.Data != null)
            {
                foreach(DictionaryEntry de in e.Data)
                {
                    Console.WriteLine("{0}:{1}",de.Key,de.Value);
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

        public Car(){}

        public Car(string name,int speed)
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
                if(CurrentSpeed > MaxSpeed)
                {
                    CurrentSpeed = 0;
                    carIsDead = true;
                    //Exception ex = new Exception(string.Format("{0} has overheated!", PetName));
                    //ex.HelpLink = "http://www.CarsRUs.com";
                    //ex.Data.Add("time",string.Format("the car exploded at {0}",DateTime.Now));
                    //ex.Data.Add("cause","you have a lead foot");
                    CustomClass ex = new CustomClass(string.Format("{0} has overheated!", PetName),"you have a lead foot",DateTime.Now);
                    throw ex;
                }else{
                    Console.WriteLine("=> CurrentSpeed = {0}",CurrentSpeed);
                }
            }
        }
    }
}
