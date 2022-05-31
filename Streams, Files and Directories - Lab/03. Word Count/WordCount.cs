using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;


namespace WordCount
{
    public class WordCount
    {
        static void Main()
        {
            string wordPath = @"..\..\..\Files\words.txt";
            string textPath = @"..\..\..\Files\text.txt";
            string outputPath = @"..\..\..\Files\output.txt";

            CalculateWordCounts(wordPath, textPath, outputPath);
        }

        public static void CalculateWordCounts(string wordsFilePath, string textFilePath, string outputFilePath)
        {
            var reader = new StreamReader(textFilePath);
            var wordsToFind = new StreamReader(wordsFilePath);
            var writer = new StreamWriter(outputFilePath);
            using (reader)
            {
                using (wordsToFind)
                {
                    using (writer)
                    {
                        var separators = new string[] { " ", ",", ".", "!", "?", "\r", "\n","-"};
                        var wordsDict = wordsToFind
                            .ReadToEnd()
                            .Split(separators, StringSplitOptions.RemoveEmptyEntries)
                            .Select(x => x.ToLower())
                            .Select((value, index) => new { value, index = 0 })
                            .ToDictionary(pair => pair.value, pair => pair.index);

                        string[] textInWords = reader
                            .ReadToEnd()
                            .Split(separators, StringSplitOptions.RemoveEmptyEntries)
                            .Select(x => x.ToLower())
                            .ToArray();

                        for (int i = 0; i < textInWords.Length; i++)
                        {
                            if (wordsDict.ContainsKey(textInWords[i]))
                            {
                                wordsDict[textInWords[i]]++;
                            }
                        }

                        var sortedDict = wordsDict.OrderByDescending(x => x.Value);

                        foreach (var (word, ocurr) in sortedDict)
                        {
                            writer.WriteLine($"{word} - {ocurr}");
                        }
                    }
                }
            }
        }
    }
}
