using System;
using System.Collections.Generic;
using System.IO;
    class Harddiskdetails
    {
        static void Main(string[] args)
        {
            DriveInfo[] drives = DriveInfo.GetDrives();
            foreach (DriveInfo drive in drives)
            {
                Console.WriteLine("Drive name : " + drive.Name);
                Console.WriteLine("Drives type : "+drive.DriveType);
                Console.WriteLine("Free Space : " + drive.AvailableFreeSpace);
                 Console.WriteLine("TotalSize : " + drive.TotalSize);
                Console.WriteLine("VolumeLabel : "+drive.VolumeLabel);
                Console.WriteLine("RootDirectory : " + drive.RootDirectory);
                Console.WriteLine("DriveFormat : " + drive.DriveFormat);
           }
        }
    }
