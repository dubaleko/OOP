using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace laba13
{
    class DVVDiskInfo
    {
        public static string GetFreeSpace(string diskName)
        {
            try
            {
                DriveInfo driveInfo = new DriveInfo(diskName);
                DVVLog.AddNote("DVVDiskInfo", driveInfo.Name);   //add log 
                return (driveInfo.AvailableFreeSpace / 1073741824).ToString();
            }
            catch (DriveNotFoundException)
            {
                return "Drive not found";
            }
        }

        public static string GetFileSystem(string diskName)
        {
            try
            {
                DriveInfo driveInfo = new DriveInfo(diskName);
                DVVLog.AddNote("DVDDiskInfo", driveInfo.Name);   //add log note
                return driveInfo.DriveFormat;
            }
            catch (DriveNotFoundException)
            {
                return "Drive not found";
            }
        }

        public static string GetDisksInfo()
        {
            try
            {
                DriveInfo[] drivers = DriveInfo.GetDrives();
                string info = $"Count of drivers: {DriveInfo.GetDrives().Length}\n";
                foreach (var driveInfo in drivers)
                {
                    try
                    {
                        info += $"Name: {driveInfo.Name} Free space: {driveInfo.AvailableFreeSpace / 1073741824} " +
                            $"GB Total space: {driveInfo.TotalSize / 1073741824} GB " +
                            $"Label: {driveInfo.VolumeLabel}\n";
                        DVVLog.AddNote("DVDDiskInfo", driveInfo.Name);   //add log note
                    }
                    catch (IOException)
                    {
                        info += $"{driveInfo} not available.\n";
                    }
                }

                return info;
            }
            catch (DriveNotFoundException)
            {
                return "Drive not found";
            }
        }
    }
}

