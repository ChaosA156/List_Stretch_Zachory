using System;
using System.Collections.Generic;

namespace Lists_Stretch_Zachory
{
    class Program
    {
        // Creates a list of games
        static void Main(string[] args)
        {
            List<string> games = new List<string>
            {
                "Halo: Reach",
                "Darksiders II",
                "Elden Ring",
                "Prince of Persia: Warrior Within",
                "SoulCalibur VI"
            };
            // Two more games for the list
            string[] otherGames = new string[]
            {
                "Call of Duty: Ghosts",
                "Bendy and the Ink Machine"
            };

            foreach (string game in games)
            {
                Console.WriteLine(game);
            }
            //Counts the number of games
            Console.WriteLine($"\nGames in list: {games.Count}");

            //Counts the number of games after adding the additional games
            games.AddRange(otherGames);

            Console.WriteLine($"\nGames in list: {games.Count}");

            // Writes an if else statement that checks if Halo: Reach is in the list. if it isn't, it adds it. if it is, it gives a special message.
            if (games.Contains("Halo: Reach"))
            {
                Console.WriteLine("\nSpartan awaiting further orders.");
            }
            else
            {
                games.Add("Halo: Reach");
            }

            int myInt = 6;

            if(myInt < games.Count)
            {
                games.RemoveAt(myInt);
            }
            else
            {
                Console.WriteLine("\nGame not found!");
            }
            // Creates a list with all games
            Console.WriteLine("\nAll games in the list:");
            foreach (string game in games)
            {
                Console.WriteLine(game);
            }

            // Creates a list with sorted games
            games.Sort();

            Console.WriteLine("\nSorted games list:");
            foreach (string game in games)
            {
                Console.WriteLine(game);
            }

            //Counts the games again
            string[] newList = new string[games.Count];

            games.CopyTo(newList);

            games.Clear();

            // Creates another list
            Console.WriteLine("\nNew List:");
            foreach(string game in newList)
            {
                Console.WriteLine(game);
            }
        }
    }
}
