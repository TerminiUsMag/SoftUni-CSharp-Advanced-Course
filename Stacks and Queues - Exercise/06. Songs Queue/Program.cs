using System;
using System.Linq;
using System.Collections.Generic;

namespace _06._Songs_Queue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Possible commands:
            //•	"Play" - plays a song(removes it from the queue)
            //•	"Add {song}" - adds the song to the queue, if it isn't contained already, otherwise print "{song} is already contained!"
            //•	"Show" - prints all songs in the queue, separated by a comma and a white space(start from the first song in the queue to the last)

            var playlist = new Queue<string>();

            string[] inputSongs = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            for (int i = 0; i < inputSongs.Length; i++)
            {
                playlist.Enqueue(inputSongs[i]);
            }

            while (playlist.Count > 0)
            {
                string[] cmd = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                switch (cmd[0])
                {
                    case "Play":
                        playlist.Dequeue();
                        break;
                    case "Add":
                        string song = string.Empty;
                        for (int j = 0; j < cmd.Length; j++)
                        {
                            if (j == 0) continue;
                            if (j + 1 == 2)
                                song += cmd[j];
                            else song += " " + cmd[j];
                        }
                        if (!playlist.Contains(song))
                        {
                            playlist.Enqueue(song);
                        }
                        else
                        {
                            Console.WriteLine($"{song} is already contained!");
                        }
                        break;
                    case "Show":
                        Console.WriteLine(String.Join(", ", playlist));
                        break;
                }
            }
            Console.WriteLine("No more songs!");

        }
    }
}
