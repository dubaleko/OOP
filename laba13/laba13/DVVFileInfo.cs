using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace laba13
{
    class DVVFileInfo
    {
        public static string GetFullPath(string filename)
        {
            try
            {
                FileInfo file = new FileInfo(filename);
                DVVLog.AddNote("DVVFileInfo", file.FullName);   //add log note
                return file.FullName;
            }
            catch (FileNotFoundException)
            {
                return "File not found";
                throw;
            }
        }

        public static string GetMainFileInfo(string filename)
        {
            try
            {
                FileInfo file = new FileInfo(filename);
                DVVLog.AddNote("DVVFileInfo", file.FullName);   //add log note
                return $"File name: {file.Name} extension: {file.Extension} size: " +
                    $"{file.Length / 1024} kb.";
            }
            catch (FileNotFoundException)
            {
                return "File not found";
                throw;
            }
        }

        public static string GetCreationTime(string filename)
        {
            try
            {
                FileInfo file = new FileInfo(filename);
                DVVLog.AddNote("DVVFileInfo", file.FullName);   //add log note
                return $"Creation time: {file.CreationTime}";
            }
            catch (FileNotFoundException)
            {
                return "File not found";
                throw;
            }
        }
    }
}
