using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace laba13
{
    class DVVDirInfo
    {
        public static string GetNumberOfFiles(string directoryPath)
        {
            try
            {
                DirectoryInfo info = new DirectoryInfo(directoryPath);
                DVVLog.AddNote("DVVDirInfo", info.FullName);   //add log note
                return info.GetFiles().Length.ToString();
            }
            catch (DirectoryNotFoundException)
            {
                return "Directory not found";
            }
        }

        public static string GetCreationTime(string directoryPath)
        {
            try
            {
                DirectoryInfo info = new DirectoryInfo(directoryPath);
                DVVLog.AddNote("DVVDirInfo", info.FullName);   //add log note
                return info.CreationTime.ToString();
            }
            catch (DirectoryNotFoundException)
            {
                return "Directory not found";
            }
        }

        public static string GetNumberOfDirectories(string directoryPath)
        {
            try
            {
                DirectoryInfo info = new DirectoryInfo(directoryPath);
                DVVLog.AddNote("DVVDirInfo", info.FullName);   //add log note
                return info.GetDirectories().Length.ToString();
            }
            catch (DirectoryNotFoundException)
            {
                return "Directory not found";
            }
        }

        public static string GetParents(string directoryPath)
        {
            try
            {
                DirectoryInfo info = new DirectoryInfo(directoryPath);
                DVVLog.AddNote("DVVDirInfo", info.FullName);   //add log note
                return info.Parent.ToString();
            }
            catch (DirectoryNotFoundException)
            {
                return "Directory not found";
            }
        }

        public static string  GetChild(string directoryPath)
        {
            try
            {
                DirectoryInfo info = new DirectoryInfo(directoryPath);
                DVVLog.AddNote("DVVDirInfo", info.FullName);
                return Directory.GetDirectories(directoryPath).Count().ToString();
            }
            catch (DirectoryNotFoundException)
            {
                return "Directory not found";
            }
        }
    }
}
