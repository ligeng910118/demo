using System;
namespace simpleapp.AddClass
{
    public static class ObjectFunctionality
    {
        public static void objectFunctionality()
        {
            Console.WriteLine("system object functionality");
            Console.WriteLine("12.gethashcode = {0}",12.GetHashCode());
            Console.WriteLine("12 equal (23) = {0}",12.Equals(23));
            Console.WriteLine("12 tostring = {0}",12.ToString());
            Console.WriteLine("12 gettype = {0}",12.GetType());
        }
    }
}
