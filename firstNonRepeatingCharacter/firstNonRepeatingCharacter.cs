using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingProblemPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            //This is first none repeating character problem sovled in python
            //question : find first non repeating character, return '_' if nothing found
            //Ex. abccdddefg return 'a'
            //Finding first non repeating character in a string in O(N) time complexity

            //Test
            firstNonRepeatingCharacter("aabcdd");
            firstNonRepeatingCharacter("aabbcdef");
            firstNonRepeatingCharacter("abccdd");
            firstNonRepeatingCharacter("aabbcc");
            Console.ReadLine();
        }

        public static char firstNonRepeatingCharacter(string word)
        {
            Dictionary<char, int> dict = new Dictionary<char, int>();
            //Iterate through string and create lookup table in Dictionary O(N)
            foreach (char character in word)
            {
                if (dict.ContainsKey(character) == false)
                {
                    dict[character] = 1;
                }
                else
                {
                    dict[character] = dict[character] + 1;
                }
            }

            //Iterate through string again O(N) but refer to dictionary to find if the character is repeated O(1)
            foreach (char character in word)
            {
                if (dict[character] == 1)
                {
                    Console.WriteLine(character);
                    return character;
                }
            }

            //If not found return '_'
            Console.WriteLine('_');
            return '_';
            
        }
    }
}
