// FileAppender.cs
using System;
using System.IO;

namespace FileIOReadAndWriteModular
{
    public class FileAppender
    {
        public static void AppendTextToFile(string filePath)
        {
            try
            {
                // Use the StreamWriter constructor with the append parameter set to true.
                // This will open the file in append mode, allowing new content to be added at the end of the file.
                using (StreamWriter writer = new StreamWriter(filePath, true))
                {
                    // Use the WriteLine method to append data to the file. this also puts in new lines by default.
                    writer.WriteLine("Ensign Red Releases:");
                    writer.WriteLine("EP: Behind the Ramparts");
                    writer.WriteLine("Single: So I Bleed");
                    writer.WriteLine("Single: From the Shadows");
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("An error occurred while appending to the file:");
                Console.WriteLine(e.Message);
            }
        }
    }
}


