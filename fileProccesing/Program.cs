using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fileProccesing
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path1 = @"C:\myLab\fileProccesing\fileProccesing\source\textFileLink";
            string path2 = @"C:\myLab\fileProccesing\fileProccesing\source\textFile.txt";

            var file1 = new FileInfo(path1);
            var file2 = new FileInfo(path2);

            if (file1.Exists && file2.Exists) {

                Console.WriteLine($"name: \n {file1.Name} \n {file2.Name}" );
                Console.WriteLine($"creation time: \n {file1.CreationTime} \n {file2.CreationTime}");
                Console.WriteLine($"full name: \n {file1.FullName} \n {file2.FullName}");
                Console.WriteLine($"length: \n {file1.Length} \n {file2.Length}");
                Console.WriteLine($"attributes: \n {file1.Attributes} \n {file2.Attributes}");
                Console.WriteLine($"creation time: \n {file1.CreationTime} \n {file2.CreationTime}");
                Console.WriteLine($"last access time: \n {file1.LastAccessTime} \n {file2.LastAccessTime}");
                Console.WriteLine($"last write time: \n {file1.LastWriteTime} \n {file2.LastWriteTime}");
                Console.WriteLine($"Extension: \n {file1.Extension} \n {file2.Extension}");
                Console.WriteLine($"Exist \n {file1.Exists} \n {file2.Exists}");

            }

        }
    }
}
