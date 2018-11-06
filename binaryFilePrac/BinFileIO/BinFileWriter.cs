using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace binaryFilePrac.BinFileIO
{
    public static class BinFileWriter
    {
        public static void CreateFile(int[] arr, string fileName)
        {
            using (BinaryWriter b = new BinaryWriter(File.Open(fileName, FileMode.Create)))
            {
                foreach (int i in arr)
                {
                    b.Write(i);
                }
            }
        }
    }
}
