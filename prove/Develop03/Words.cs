﻿using System;
using System.Linq;

namespace Develop03
{
    /// <summary>
    /// Holds a word
    /// </summary>
    public class Words
    {
        string[] word;
        bool visible;

        int randomNumber;
        int rnd;

        // Delete
        int x = 0;

        public Words(string words)
        {
            word = words.Split(" ");
        }

        public string SetInvisible()
        {
            Random random = new Random();
            int rnd = random.Next(0, word.Length); // This gets a random int in word
                                                   //Console.WriteLine(word[rnd]); // This outputs a random word

            // Put this code in a while loop to keep the code running
            while (x - 1 != 10) // While the verse length and '___' are not the same number...
            {
                Console.WriteLine(x);
                x++;
            }

            // Get length of word to replace with number of '___'
            int invisibleNum = word[rnd].Length;
            string replaceWithUnderscores = String.Concat(Enumerable.Repeat("_", invisibleNum)); // This writes '_' as much as the words length

            // This code is not done yet. Now I have to get the whole sentence back together, but instead of the word, it needs to have ___
            Console.WriteLine();
            word[rnd] = replaceWithUnderscores; // Replaces word with underscores
            string joinWords = string.Join(" ", word); // This joins the words back together but with the new "_"

            return joinWords;
        }

        public void GetInvisible()
        {
            string invisibleWord = SetInvisible();
            Console.WriteLine(invisibleWord);
        }
    }
}

