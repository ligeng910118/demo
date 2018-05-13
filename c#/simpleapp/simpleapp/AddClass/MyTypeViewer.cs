using System;
using System.Reflection;
using System.Linq;
namespace simpleapp.AddClass
{
    public class MyTypeViewer
    {
        public static void MyTypeViewerMain()
        {
            string typeName = Console.ReadLine();
            Type t = Type.GetType(typeName);
            ListVariousStats(t);
            ListFields(t);
            ListProps(t);
            ListMethods(t);
            ListInterfaces(t);
        }

        public static void ListMethods(Type t)
        {
            Console.WriteLine("methods");
            MethodInfo[] mi = t.GetMethods();
            foreach (MethodInfo m in mi)
            {
                string retVal = m.ReturnType.FullName;
                string paramInfo = "(";
                foreach(ParameterInfo pi in m.GetParameters())
                {
                    paramInfo += string.Format("{0} {1},",pi.ParameterType,pi.Name);
                }
                paramInfo += ")";
                Console.WriteLine("->{0} {1} {2}",retVal,m.Name,paramInfo);
            }
        }

        public static void ListFields(Type t)
        {
            Console.WriteLine("fields");
            var fieldNames = from f in t.GetFields() select f.Name;
            foreach (var name in fieldNames)
                Console.WriteLine("->{0}", name);
        }

        public static void ListProps(Type t)
        {
            Console.WriteLine("properties");
            var propNames = from p in t.GetProperties() select p.Name;
            foreach (var name in propNames)
                Console.WriteLine("->{0}",name);
        }

        public static void ListInterfaces(Type t)
        {
            Console.WriteLine("Interfaces");
            var ifaces = from p in t.GetInterfaces() select p;
            foreach (var i in ifaces)
                Console.WriteLine("->{0}", i.Name);
        }

        public static void ListVariousStats(Type t)
        {
            Console.WriteLine("various");
            Console.WriteLine("base class is:{0}", t.BaseType);
            Console.WriteLine("is type abstract:{0}", t.IsAbstract);
            Console.WriteLine("is type sealed:{0}", t.IsSealed);
            Console.WriteLine("is type generic:{0}", t.IsGenericType);
            Console.WriteLine("is type a class type:{0}", t.IsClass);
        }
    }
}
