using System;
using System.IO;
namespace simpleapp.AddClass
{
    public class StreamClass
    {
        public static void StreamMain()
        {
            using(StreamWriter writer = File.CreateText("remember.txt"))
            {
                writer.WriteLine("don't forget these numbers:");
                for (int i = 0; i < 10; i++)
                {
                    writer.WriteLine("{0}", i);
                }
            }
            Console.WriteLine("create file complete!");
        }

        public static void StreamRead()
        {
            Console.WriteLine("here are your thoughts:");
            using(StreamReader sr = File.OpenText("remember.txt"))
            {
                string input = null;
                while((input = sr.ReadLine())!= null)
                {
                    Console.WriteLine(input);
                }
            }
        }

        public static void WatchSystem()
        {
            FileSystemWatcher watcher = new FileSystemWatcher();
            try{
                watcher.Path = ".";
            }catch(ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
                return;
            }

            watcher.NotifyFilter = NotifyFilters.LastAccess
                | NotifyFilters.LastWrite | NotifyFilters.FileName | NotifyFilters.DirectoryName;

            watcher.Filter = "*.txt";

            watcher.Changed += new FileSystemEventHandler(OnChanged);
            watcher.Created += new FileSystemEventHandler(OnChanged);
            watcher.Deleted += new FileSystemEventHandler(OnChanged);
            watcher.Renamed += new RenamedEventHandler(OnRenamed);

            watcher.EnableRaisingEvents = true;
            Console.WriteLine("press 'q' to quit app.");
            while (Console.Read() != 'q'){} ;
        }

        public static void OnChanged(object source,FileSystemEventArgs e)
        {
            Console.WriteLine("file : {0} {1}!",e.FullPath,e.ChangeType);
        }

        public static void OnRenamed(object source,RenamedEventArgs e)
        {
            Console.WriteLine("file:{0} renamed to {1}",e.OldFullPath,e.FullPath);
        }
    }
}
