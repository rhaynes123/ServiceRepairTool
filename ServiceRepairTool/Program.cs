using System;
//TODO Add Methods to stop and start services

namespace ServiceRepairTool
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            FileMove filemoveobj = new FileMove();
            FileMoveLog filemovelog = new FileMoveLog();
        }
    }
    public class FileMoveLog
    {
        static void WriteMoveLog()
        {
            string logMessage = "File was moved";
            DateTime logTimeStamp = DateTime.Now;
            string logOutput = logMessage + Convert.ToString(logTimeStamp);
            System.IO.File.WriteAllText(@"", logOutput);

        }
    }
    //TODO Not certain if this needs its own class
    public class FileMove
    {
        static void MoveFileMethod()
        {
            //Add any file you need from any file entered to a destination file. See Example below
            /*string fileName = "test.txt";
            string sourcePath = @"C:\Users\Public\TestFolder";
            string targetPath =  @"C:\Users\Public\TestFolder\SubDir";
            */
            string NameOfFile = "";
            string OriginFilePath = " ";
            string DestinationFilePath = "";
            //Will Make the Destination Folder if its missing
            string OriginFile = System.IO.Path.Combine(OriginFilePath, NameOfFile);
            string DestinationFile = System.IO.Path.Combine(DestinationFilePath, NameOfFile);

            if(!System.IO.Directory.Exists(DestinationFilePath))
            {
                System.IO.Directory.CreateDirectory(DestinationFilePath);
            }
            //Copys to a file in a location or overwrites it
            System.IO.File.Copy(OriginFile, DestinationFile, true);
            if(System.IO.Directory.Exists(OriginFilePath))
            {
                string[] newfiles = System.IO.Directory.GetFiles(OriginFilePath);
                //Copies files and overwrites them if they pre-exist
                foreach (string oldfiles in newfiles)
                {
                    NameOfFile = System.IO.Path.GetFileName(oldfiles);
                    DestinationFile = System.IO.Path.Combine(DestinationFilePath, NameOfFile);
                    System.IO.File.Copy(oldfiles, DestinationFile, true);

                }
            }
            else
            {
                Console.WriteLine("Can't Find Source Path!");
            }
            Console.WriteLine("All Set!");
        }
    }
}
