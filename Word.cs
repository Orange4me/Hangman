using System;
using System.Collections.Generic;

namespace Hangman
{
    public class Word
    {
        // These are the attributes
        private List<string> _secret = new List<string>() {"b","a","n","a","n","a"};
        private List<string> _guesses = new List<string>() { "_", "_", "_", "_", "_", "_"};

        // This is the constructor.
        public Word()
        {
            List<string> words = new List<string>() { "banana", "apple", "orange"};
            Random random = new Random();
            int index = random.Next(0,2);
            string word = words[index];
            _secret = new List<string>(word.Split());

            // use a loop to set _guesses to a list of underscores (the same number of letters in _secret)
        
        
        }

        // These are the methods
        public void CheckGuess(string guess)
        {
            for (int i = 0; i < _secret.Count; i++)
            {
                if (guess == _secret[i])
                {
                    _guesses[i] = guess;
                }
            }   
        }

        public string ToString()
        {
            string s = "";
            foreach (string item in _guesses)
            {
                s += item;
            }
            
            return s;
        }

        

    }
}