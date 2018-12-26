using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba13
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("----------------------DVVDiskInfo-----------------------");
            Console.WriteLine($"File system of D: {DVVDiskInfo.GetFileSystem("D")}");
            Console.WriteLine($"Free space on D: {DVVDiskInfo.GetFreeSpace("D")} GB");
            Console.WriteLine("Information about disk:");
            Console.WriteLine(DVVDiskInfo.GetDisksInfo());

            Console.WriteLine("-------------------- DVVFileInfo --------------------");
            Console.WriteLine($"Hello.txt located at {DVVFileInfo.GetFullPath("Hello.txt")}");
            Console.WriteLine($"{DVVFileInfo.GetMainFileInfo("Hello.txt")}");
            Console.WriteLine($"{DVVFileInfo.GetCreationTime("Hello.txt")}");
            Console.WriteLine();

            Console.WriteLine("-------------------- DVVDirInfo --------------------");
            Console.WriteLine($"Creation time: {DVVDirInfo.GetCreationTime("D:\\Battle.net")}");
            Console.WriteLine($"Has {DVVDirInfo.GetNumberOfFiles("D:\\Battle.net")} files");
            Console.WriteLine($"Parent of OOP: {DVVDirInfo.GetParents("D:\\Labs\\OOP")}");
            Console.WriteLine($"Child of OOP:{DVVDirInfo.GetChild(@"D:\\Labs\\OOP")}");
            Console.WriteLine();

            DVVFileManager.WriteFilesAndFodlers("D");
            DVVFileManager.CopyFilesByExtension("txt", @"D:\Labs\OOP\laba13\laba13\bin\Debug\DVVInspect");
            DVVFileManager.ZipFolder();

            Console.WriteLine("----------------------DVVlogfile-----------------------");
            DVVLog.Upgrade(@"D:\Labs\OOP\laba13\laba13\bin\Debug\dvvlogfile.txt", DateTime.Now.Hour);
            DVVLog.Count(@"D:\Labs\OOP\laba13\laba13\bin\Debug\dvvlogfile.txt");
            DVVLog.PrintInfo(@"D:\Labs\OOP\laba13\laba13\bin\Debug\dvvlogfile.txt");
        }
    }
}
