using System;
using System.IO;
namespace simpleapp.AddClass
{
    public class FilesClass
    {
        public static void FilesMain()
        {
            FileInfo f = new FileInfo("./test.txt");
            FileStream fs = f.Create();
            fs.Close();
        }

        public static void FilesTwoMain()
        {
            FileInfo f2 = new FileInfo("./test.txt");
            using(FileStream fs2 = f2.Open(FileMode.OpenOrCreate,FileAccess.ReadWrite,FileShare.None))
            {
                
            }
        }

        public static void FilesOpenText()
        {
            FileInfo FileText = new FileInfo("./test.txt");
            using(StreamReader text = FileText.OpenText())
            {
                Console.WriteLine("{0}", text.ToString());                
            }
        }

        public static void FileSave()
        {
            string[] myTasks = {
                "fix bathroom sink",
                "call dave",
                "call mom and dad",
                "play xbox 360"
            };

            File.WriteAllLines("./test.txt",myTasks);

            foreach(string task in File.ReadAllLines("./test.txt"))
            {
                Console.WriteLine("{0}",task);
            }
        }
    }
}
