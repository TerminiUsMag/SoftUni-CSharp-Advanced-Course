using System;
using System.Linq;
using System.IO;



namespace ExtractSpecialBytes
{
    public class ExtractSpecialBytes
    {
        static void Main()
        {
            string binaryFilePath = @"..\..\..\Files\example.png";
            string bytesFilePath = @"..\..\..\Files\bytes.txt";
            string outputPath = @"..\..\..\Files\output.bin";

            ExtractBytesFromBinaryFile(binaryFilePath, bytesFilePath, outputPath);
        }

        public static void ExtractBytesFromBinaryFile(string binaryFilePath, string bytesFilePath, string outputPath)
        {
            using (var reader = new FileStream(binaryFilePath, FileMode.Open, FileAccess.Read))
            {
                using(var bytesReader = new StreamReader(bytesFilePath))
                {
                    using(var writer = new FileStream(outputPath, FileMode.Create, FileAccess.Write))
                    {
                        
                        var bytes = File.ReadAllBytes(bytesFilePath);
                        var binaryFileBytes = File.ReadAllBytes(binaryFilePath);
                        byte[] output = new byte[binaryFileBytes.Length];
                        int counter = 0;
                        for(int i = 0; i < bytes.Length; i++)
                        {
                            for(int j =0; j < binaryFileBytes.Length; j++)
                            {
                                if(bytes[i] == binaryFileBytes[j])
                                {
                                    output[counter]=bytes[i];
                                    counter++;
                                }
                            }
                        }

                        writer.Write(output);
                        
                    }
                }
            }
        }
    }
}

