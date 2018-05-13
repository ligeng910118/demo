using System;
using System.Threading;
namespace simpleapp.AddClass
{
    public class ThreadInfoClass
    {

        public static void ThreadInfo()
        {
            Thread primaryThread = Thread.CurrentThread;
            primaryThread.Name = "the primary thread";

            Console.WriteLine("name of current appdomain:{0}",Thread.GetDomain().FriendlyName);
            Console.WriteLine("id of current context:{0}", Thread.CurrentContext.ContextID);
            Console.WriteLine("thread name:{0}", primaryThread.Name);
            Console.WriteLine("has thread started:{0}", primaryThread.IsAlive);
            Console.WriteLine("priority level:{0}", primaryThread.Priority);
            Console.WriteLine("thread state:{0}", primaryThread.ThreadState);
        }
    }

    public class Printer
    {
        public void PrintNumbers()
        {
            Console.WriteLine("-> {0} is executing printer number",Thread.CurrentThread.Name);
            Console.Write("your numbers:");
            for (int i = 0; i < 10;i++)
            {
                Console.Write("{0},", i);
                Thread.Sleep(2000);
            }
        }
    }
}
