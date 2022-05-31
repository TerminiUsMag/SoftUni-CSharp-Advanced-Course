using System;
using System.Linq;
using System.IO;
using System.Collections.Generic;

namespace MergeFiles
{
    public class MergeFiles
    {
        static void Main()
        {
            var firstInputFilePath = @"..\..\..\Files\input1.txt";
            var secondInputFilePath = @"..\..\..\Files\input2.txt";
            var outputFilePath = @"..\..\..\Files\output.txt";

            MergeTextFiles(firstInputFilePath, secondInputFilePath, outputFilePath);
        }

        public static void MergeTextFiles(string firstInputFilePath, string secondInputFilePath, string outputFilePath)
        {
            var firstInput = new StreamReader(firstInputFilePath);
            var secondInput = new StreamReader(secondInputFilePath);
            var output = new StreamWriter(outputFilePath);
            using (firstInput)
            using (secondInput)
            using (output)
            {
                while (true)
                {

                    string line1 = firstInput.ReadLine();
                    if (line1 != null)
                        output.WriteLine(line1);

                    string line2 = secondInput.ReadLine();
                    if (line2 != null)
                        output.WriteLine(line2);

                    if (line1 == null & line2 == null)
                        break;
                }
            }
        }
    }
}

