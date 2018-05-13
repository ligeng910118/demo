using System;
using System.Threading;
namespace simpleapp.AddClass
{
    public delegate int BinaryOp(int x, int y);

    public class Threadlass
    {
        private static bool isDone = false;

        public static void ThreadMain()
        {
            //Thread1();
            //Thread2();
            Thread3();
        }

        public static void Thread3()
        {
            Console.WriteLine("main() invoked on thread {0}", Thread.CurrentThread.ManagedThreadId);
            BinaryOp b = new BinaryOp(Add);
            IAsyncResult iftAR = b.BeginInvoke(10,10,new AsyncCallback(AddComplete),null);
            while(!isDone)
            {
                Thread.Sleep(1000);
                Console.WriteLine("working...");
            }
        }

        public static void Thread2()
        {
            Console.WriteLine("main() invoked on thread {0}", Thread.CurrentThread.ManagedThreadId);
            BinaryOp b = new BinaryOp(Add);
            IAsyncResult iftAR = b.BeginInvoke(10, 10,null,null);
            Console.WriteLine("doing more work in main()!");
            int answer = b.EndInvoke(iftAR);
            Console.WriteLine("10 + 10 is {0}",answer);
        }

        public static void Thread1()
        {
            Console.WriteLine("main() invoked on thread {0}", Thread.CurrentThread.ManagedThreadId);
            BinaryOp b = new BinaryOp(Add);
            int answer = b(10, 10);
            Console.WriteLine("10 + 10 is {0}", answer);
        }

        public static int Add(int x,int y)
        {
            Console.WriteLine("add() invoked on thread {0}",Thread.CurrentThread.ManagedThreadId);
            Thread.Sleep(5000);
            return x + y;
        }

        public static void AddComplete(IAsyncResult itfAR)
        {
            Console.WriteLine("addcomplete() invoked on thread {0}",Thread.CurrentThread.ManagedThreadId);
            Console.WriteLine("you addtion is complete");
            isDone = true;
        }
    }
}
