using System;
using System.IO;

namespace CSharpFundamentals.Working_with_Files
{
    class FileAndFileInfo
    {   
        //using System.io
        //File And FileInfo: provide methods for creating, copying, deleting, moving, GetAttributes(), ReadAllText() and opening of files.
        //FileInfo/ DirectoryInfo : provides instance methods
        //File / Directory : provides static methods.
        //Directory and DirectoryInfo : CreateDirectory(), Delete(), Exists(), GetCurrentDirectory(), GetFiles(), Move(), GetLogicalDrives()
        //Path class which provides methods to work with a string that contains a file or directory.
        //public void FileInfoAndFile()
        //{
        //    var path = @"C:\My Programs\images\Sonal_HBD.jpg";

            //File.Copy(@"C:\My Programs\images\Sonal_HBD.jpg", @"C:\My Programs\images2-CreateDirectoryTest\Sonal_HBD.jpg", true);
            //File.Delete(path);
            //if (File.Exists(path))
            //{
            //    //
            //}
            //// var content  = File.ReadAllText(path);

            //var fileInfo = new FileInfo(path);
            //fileInfo.CopyTo(@"C:\My Programs\images2-CreateDirectoryTest\Sonal1_HBD.jpg");
            //fileInfo.Delete();
            //if (fileInfo.Exists)
            //{
            //    Console.WriteLine("OK");
            //}
        //}
        //public void DirectoryAndDirectoryPath()
        //{
            //Directory.CreateDirectory(@"C:\My Programs\images2-CreateDirectoryTest");
            //File.Copy(@"C:\My Programs\images\Sonal_HBD.jpg", @"C:\My Programs\images2-CreateDirectoryTest\Sonal_HBD.jpg", true);
            //var files = Directory.GetFiles(@"C:\My Programs\images2-CreateDirectoryTest", "*.*", SearchOption.AllDirectories);
            //foreach(var file in files)
            //    Console.WriteLine(file);

        //    var directories = Directory.GetDirectories(@"C:\Users\bhekeru\source\repos\Program", ".", SearchOption.AllDirectories);
        //    foreach (var directory in directories)
        //        Console.WriteLine(directory);

        //    Directory.Exists("...");
            
        //}
        
       public void PathDemo()
        {
            var path = @"C:\My Programs\images2-CreateDirectoryTest\Sonal_HBD.jpg";

            var dotIndex = path.IndexOf('.');
            var extension = path.Substring(dotIndex);

            Console.WriteLine("Extension: " + Path.GetExtension(path));
            Console.WriteLine("File Name: " + Path.GetFileName(path));
            Console.WriteLine("File Name without Extension: " + Path.GetFileNameWithoutExtension(path));


        }
    }
}
