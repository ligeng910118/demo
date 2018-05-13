using System;
namespace simpleapp.AddClass
{
    public class LocalClass
    {

        public static void DeclareImplicitVars()
        {
            var myInt = 0;
            var myBoot = true;
            var myString = "time,marches on...";

            Console.WriteLine("myInt is a:{0}",myInt.GetType().Name);
            Console.WriteLine("myBool is a:{0}",myBoot.GetType().Name);
            Console.WriteLine("myString is a:{0}",myString.GetType().Name);
        }


    }
}
