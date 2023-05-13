using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextManagerApp
{
    public class TextManager
    {
        public string GetLongestWord(string sentence)
        {
            if (string.IsNullOrWhiteSpace(sentence))
            {
                throw new ArgumentException("The sentence is empty.");
            }

            string[] words = sentence.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            if (words.Length == 0)
            {
                throw new ArgumentException("The sentence does not contain any words.");
            }

            string longestWord = "";
            foreach (string word in words)
            {
                if (word.Length > longestWord.Length)
                {
                    longestWord = word;
                }
            }

            return longestWord;
        }

        public string[] GetAllLongestWords(string sentence)
        {
            if (string.IsNullOrWhiteSpace(sentence))
            {
                throw new ArgumentException("The sentence is empty.");
            }

            string[] words = sentence.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            if (words.Length == 0)
            {
                throw new ArgumentException("The sentence does not contain any words.");
            }

            int maxLength = 0;
            foreach (string word in words)
            {
                if (word.Length > maxLength)
                {
                    maxLength = word.Length;
                }
            }

            string[] longestWords = new string[words.Length];
            int count = 0;
            foreach (string word in words)
            {
                if (word.Length == maxLength)
                {
                    longestWords[count] = word;
                    count++;
                }
            }

            Array.Resize(ref longestWords, count);
            return longestWords;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a sentence:");
            string sentence = Console.ReadLine();

            TextManager textManager = new TextManager();

            string longestWord = textManager.GetLongestWord(sentence);
            Console.WriteLine("Longest word: " + longestWord);

            string[] allLongestWords = textManager.GetAllLongestWords(sentence);
            Console.WriteLine("All longest words:");
            foreach (string word in allLongestWords)
            {
                Console.WriteLine(word);
            }

            Console.ReadLine();
        }
    }
}
