using System;
using System.Reflection;
using System.Linq;
namespace simpleapp.AddClass
{
    public class AppDomainClass
    {
        public AppDomainClass()
        {
        }

        public static void DisplayDADStats()
        {
            AppDomain defaultAD = AppDomain.CurrentDomain;
            Console.WriteLine("name of this domain:{0}",defaultAD.FriendlyName);
            Console.WriteLine("id of domain in this process:{0}",defaultAD.Id);
            Console.WriteLine("is this the default domain:{0}", defaultAD.IsDefaultAppDomain());
            Console.WriteLine("base directory of this domain:{0}", defaultAD.BaseDirectory);
        }

        public static void ListAllAssembliesInAppDomain()
        {
            AppDomain defaultAD = AppDomain.CurrentDomain;
            Assembly[] loadedAssemblies = defaultAD.GetAssemblies();
            Console.WriteLine("here are the assemblies loaded in {0}",defaultAD.FriendlyName);
            foreach(Assembly a in loadedAssemblies)
            {
                Console.WriteLine("-> name : {0}",a.GetName().Name);
                Console.WriteLine("-> version : {0}",a.GetName().Version);
            }
        }
    }
}
