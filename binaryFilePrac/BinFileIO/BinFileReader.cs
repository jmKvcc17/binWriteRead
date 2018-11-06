using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace binaryFilePrac.BinFileIO
{
    public static class BinFileReader
    {
        public static void ReadFile(string fileName)
        {
            using (BinaryReader b = new BinaryReader(File.Open(fileName, FileMode.Open)))
            {
                int pos = 0;

                int length = (int)b.BaseStream.Length;
                while(pos < length)
                {
                    int v = b.ReadInt32();

                    Console.WriteLine(v);
                    pos += sizeof(int);
                }
            }
        }
    }
}
