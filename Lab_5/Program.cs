

using System;
using System.Collections.Generic;

class Program
{
    static bool running = true;
    // Queue to store the songs
    static Queue<string> musicQueue = new Queue<string>();
    // List to store previous songs
    static List<string> previousSongs = new List<string>();

    static void Main()
    {
        while (running)
        {
            // ask for user input regarding options
            Console.WriteLine("Choose an option:");
            Console.WriteLine("1. Add a song to your playlist");
            Console.WriteLine("2. Play the next song in your playlist");
            Console.WriteLine("3. Skip the next song");
            Console.WriteLine("4. Rewind one song");
            Console.WriteLine("5. Exit");
            // Read a single character from the user's input
            char optionInput = Console.ReadKey().KeyChar;
            Console.WriteLine();
            // Check if the input is a number
            if (Char.IsNumber(optionInput))
            {
                // Convert the character to an integer
                int optionNumber = Int32.Parse(optionInput.ToString());

                switch (optionNumber)
                {
                    case 1:
                        Console.WriteLine("Enter a song:");
                        // Read the user's input for the song
                        string userSong = Console.ReadLine();
                        // Call the readline to add the song to the playlist
                        AddSong(userSong);
                        break;
                    case 2:
                        // Call the method to play the next song in the playlist
                        PlayNextSong();
                        break;
                    case 3:
                        // Call the method to skip the next song in the playlist
                        SkipNextSong();
                        break;
                    case 4:
                        // Call the method to rewind to the previous song
                        RewindSong();
                        break;
                    case 5:
                        // Set running to false to exit
                        running = false;
                        break;
                    default:
                        Console.WriteLine($"{optionNumber} is not a valid option. Please select an option.");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Please choose a correct option");
            }
        }
        Console.WriteLine();
    }


    static void AddSong(string userSong)
    {
        // Enqueue the user's song to the end of the playlist queue, enqueue is used to add songs
        // to end of queue. link explaining:
        // https://www.tutorialspoint.com/queue-enqueue-method-in-chash#:~:text=Enqueue()%20method%20in%20C%23%20is%20used%20to%20add%20an,the%20end%20of%20the%20Queue.
        musicQueue.Enqueue(userSong);
        Console.WriteLine($"\"{userSong}\" added to your playlist.");
        Console.WriteLine();
    }

    static void PlayNextSong()
    {
        if (musicQueue.Count > 0)
        {
            // Dequeue removes and returns the first object in the queue. link explaining:
            // https://www.tutorialspoint.com/queue-dequeue-method-in-chash#:~:text=Dequeue()%20method%20in%20C%23,the%20beginning%20of%20the%20Queue.
            string nextSong = musicQueue.Dequeue();
            // Add the song to the list of previous songs
            previousSongs.Add(nextSong);
            Console.WriteLine($"Now playing \"{nextSong}\"");

            if (musicQueue.Count > 0)
                // Peek returns the object at the top without removing it. link explaining:
                // https://www.tutorialspoint.com/stack-peek-method-in-chash#:~:text=Peek()%20method%20in%20C%23%20is%20used%20to%20return%20the,the%20Stack%20without%20removing%20it.
                Console.WriteLine($"Next song: {musicQueue.Peek()}");
            else
                Console.WriteLine("Next song: none queued");
        }
        else
        {
            Console.WriteLine("Your playlist is empty.");
        }
        Console.WriteLine();
    }

    static void SkipNextSong()
    {
        if (musicQueue.Count > 0)
        {
            // remove next song from the beginning of the playlist queue to skip
            string skippedSong = musicQueue.Dequeue();
            Console.WriteLine($"Skipped song \"{skippedSong}\"");

            if (musicQueue.Count > 0)
                // show next song in the queue
                Console.WriteLine($"Next song: {musicQueue.Peek()}");
            else
                // return error if there isn't more than one song in the queue when skipping
                Console.WriteLine("Next song: none queued");
        }
        else
        {
            Console.WriteLine("Your playlist is empty.");
        }
        Console.WriteLine();
    }

    static void RewindSong()
    {
        if (previousSongs.Count > 0)
        {
            // previousSong gets the last song from the list of previous songs
            string previousSong = previousSongs[previousSongs.Count - 1];
            // remove the last song from the list to be able to add song back in
            previousSongs.RemoveAt(previousSongs.Count - 1);
            // must add the previous song back to the playlist queue
            musicQueue.Enqueue(previousSong);
            Console.WriteLine($"Rewinding to song \"{previousSong}\"");
            Console.WriteLine($"Now playing \"{previousSong}\"");

            if (musicQueue.Count > 0)
            {
                // must convert queue to an array to get the index of, easiest.
                string[] queueSongs = musicQueue.ToArray();
                // Get the first song in the array
                Console.WriteLine($"Next song: {queueSongs[0]}");
            }
            else
            {
                Console.WriteLine("Next song: none queued");
            }
        }
        else
        {
            // validate no previous song if at the beginning of the queue
            Console.WriteLine("No previous song available.");
        }
    }
}

// source links for research:
// https://www.geeksforgeeks.org/c-sharp-queue-with-examples/
// https://dotnetcoretutorials.com/queue-vs-list-performance-in-c/
