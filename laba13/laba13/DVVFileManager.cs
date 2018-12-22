﻿using System;
using System.IO;
using System.IO.Compression;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba13
{
    class DVVFileManager
    {
        public static void WriteFilesAndFodlers(string driveName)
        {
            Directory.CreateDirectory("DVVInspect");
            StreamWriter streamWriter = new StreamWriter("DVVInspect\\dvvdirinfo.txt");
            try
            {
                DirectoryInfo directoryInfo = new DirectoryInfo($"{driveName}:\\");
                //Dirs
                foreach (var item in directoryInfo.EnumerateDirectories())
                {
                    streamWriter.WriteLine(item.Name);
                }
                //Files
                foreach (var item in directoryInfo.EnumerateFiles())
                {
                    streamWriter.WriteLine(item.Name);
                }
                string path = @"D:\Labs\OOP\laba13\laba13\bin\Debug\DVVInspect\dvvdirinfo.txt";
                string newpath = @"D:\Labs\OOP\laba13\laba13\bin\Debug\DVVInspect\dvv.txt";
                File.Copy(path, newpath, true);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            streamWriter.Close();
            File.Delete(@"D:\Labs\OOP\laba13\laba13\bin\Debug\DVVInspect\dvvdirinfo.txt");
        }
        public static void CopyFilesByExtension(string extension, string path)
        {
            try
            {
                Directory.CreateDirectory("DVVFiles");
                DirectoryInfo directory = new DirectoryInfo(path);
                foreach (var item in directory.GetFiles())
                {
                    if (item.Name.EndsWith(extension))
                    {
                        item.CopyTo($"DVVFiles\\{item.Name}");
                    }
                }
                Directory.Move("DVVFiles", "DVVInspect\\DVVFiles");
            }
            catch (IOException e)
            {
                Console.WriteLine(e.Message);
            }
        }
        public static void ZipFolder()
        {
            try
            {
                ZipFile.CreateFromDirectory("DVVInspect\\DVVFiles", @"D:\Labs\OOP\laba13\laba13\bin\Debug\DVVFile.zip");
            }
            catch(IOException e)
            {
                Console.WriteLine(e.Message);   
            }
        }
    }
}
