using System;
using binaryFilePrac.BinFileIO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace binaryFilePrac
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 1, 3, 4, 6, 10, 100 };

            BinFileWriter.CreateFile(arr, "test.bin");
            BinFileReader.ReadFile("test.bin");

            Console.WriteLine("Press any key to continue.");
            Console.ReadKey();
        }
    }
}
