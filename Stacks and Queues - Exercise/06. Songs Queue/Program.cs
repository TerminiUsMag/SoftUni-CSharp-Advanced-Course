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

            //Declaring variables.
            var playlist = new Queue<string>();
            string[] inputSongs = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .ToArray();
            //Adding the initial songs to the playlist (Queue).
            for (int i = 0; i < inputSongs.Length; i++)
            {
                playlist.Enqueue(inputSongs[i]);
            }
            //This WHILE cicle is used to determine when the playlist is empty and stops the program when so.
            while (playlist.Count > 0)
            {
                //String array used to store the command line split by whitepsaces.
                string[] cmd = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
                //Switch case statement used to determine which command is given.
                switch (cmd[0])
                {
                    //If the command is PLAY we dequeue the first added song.
                    case "Play":
                        playlist.Dequeue();
                        break;
                    //If the command is ADD we check if the song is already in the playlist (Queue) and if not we add it.
                    case "Add":
                        //Declaring the song variable and setting it to null because the song is usually not one word and we have to concatenate the whole song name again.
                        string song = string.Empty;
                        //The FOR cicle used to concatenate the song name.
                        for (int j = 0; j < cmd.Length; j++)
                        {
                            if (j == 0) continue;//If it's the first iteration of the cicle don't use it as an index.
                            if (j + 1 == 2) song += cmd[j];//If it's the second iteration don't add white space infront of the word.
                            else song += " " + cmd[j];//If it's any other iteration add white space infront of the word to make it whole.
                        }
                        //If statement to check if the song is already in the playlist (Queue).
                        //If it is not we enqueue (Add) the song.
                        if (!playlist.Contains(song))
                        {
                            playlist.Enqueue(song);
                        }
                        //If it is already in the playlist (Queue) we print a message without adding the song.
                        else
                        {
                            Console.WriteLine($"{song} is already contained!");
                        }
                        break;
                    //If the command is SHOW we print all songs from the playlist (Queue) separated by a coma and a whitespace.
                    case "Show":
                        Console.WriteLine(String.Join(", ", playlist));
                        break;
                }
            }
            //When the playlist (Queue) is empty we end the WHILE cicle and print this message.
            Console.WriteLine("No more songs!");

        }
    }
}
