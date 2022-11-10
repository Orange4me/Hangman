using System;
using System.Collections.Generic;

namespace Hangman
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Word myWord = new Word();
            Console.WriteLine(myWord.ToString());
            myWord.CheckGuess("a");
            Console.WriteLine(myWord.ToString());
        
            
        }
    }
}