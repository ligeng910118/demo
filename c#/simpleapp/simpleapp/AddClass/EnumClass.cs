using System;
namespace simpleapp.AddClass
{

    public class EnumClass
    {
        public enum EmpType : byte
        {
            Manager = 10,
            Grunt = 1,
            Contractor = 100,
            VicePresident = 9,
        }
        public static void EnumClassParam()
        {
            Console.WriteLine("***** fun with enum *****");
            EmpType emp = EmpType.Contractor;
            AskForBonus(emp);
            Console.WriteLine("emptype uses a {0} for storage",Enum.GetUnderlyingType(emp.GetType()));

        }

        public static void EnumKey()
        {
            Console.WriteLine("***** fun with enum *****");
            EmpType emp = EmpType.Contractor;
            Console.WriteLine("emp is a {0}",emp.ToString());
        }

        public static void EnumValue()
        {
            Console.WriteLine("***** fun with enum *****");
            EmpType emp = EmpType.Contractor;
            Console.WriteLine("emp value is a {0}", (byte)emp);
        }

        public static void AskForBonus(EmpType e)
        {
            switch(e)
            {
                case EmpType.Manager:
                    Console.WriteLine("how about stock options instead?");
                    break;
                case EmpType.Grunt:
                    Console.WriteLine("have you got to be kidding");
                    break;
                case EmpType.Contractor:
                    Console.WriteLine("you already get enough cash");
                    break;
                default:
                    Console.WriteLine("very good,sir!");
                    break;
            }
        }
    }
}
