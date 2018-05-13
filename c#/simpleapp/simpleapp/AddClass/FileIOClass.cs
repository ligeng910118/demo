using System;
using System.IO;
namespace simpleapp.AddClass
{
    public class FileIOClass
    {
        public static void ShowWindowDirectoryInfo()
        {
            DirectoryInfo dir = new DirectoryInfo(".");
            Console.WriteLine("fullname:{0}",dir.FullName);
            Console.WriteLine("name:{0}",dir.Name);
            Console.WriteLine("parent:{0}",dir.Parent);
            Console.WriteLine("creation:{0}",dir.CreationTime);
            Console.WriteLine("attribute:{0}",dir.Attributes);
            Console.WriteLine("root:{0}",dir.Root);
        }

        public static void DisplayImageFiles()
        {
            DirectoryInfo dir = new DirectoryInfo(".");
            FileInfo[] fileInfo = dir.GetFiles("*",SearchOption.AllDirectories);
            Console.WriteLine("found {0} files.",fileInfo.Length);
            foreach(FileInfo f in fileInfo)
            {
                Console.WriteLine("file name :{0}",f.Name);
                Console.WriteLine("file size : {0}",f.Length);
                Console.WriteLine("create time : {0}",f.CreationTime);
                Console.WriteLine("attribute : {0}",f.Attributes);
            }
        }

        public static void ModifyDirectory()
        {
            DirectoryInfo dir = new DirectoryInfo(".");
            dir.CreateSubdirectory("createDir");
            DirectoryInfo mySubDir =  dir.CreateSubdirectory("createDir/subDir");
            Console.WriteLine("new folder {0}",mySubDir);
        }

        public static void FunType()
        {
            string[] drives = Directory.GetLogicalDrives();
            foreach(string s in drives)
            {
                Console.WriteLine("-> {0}",s);                
            }

            Directory.Delete("createDir",true);
        }
    }
}
