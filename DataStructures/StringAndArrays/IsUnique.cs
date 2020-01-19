using System;
using System.Collections.Generic;

namespace DataStructures.StringAndArrays
{
    public class IsUnique
    {
        /// <summary>
        /// Check if all character in string are unique
        /// </summary>
        public IsUnique()
        {
        }

        /// <summary>
        /// Use hash set to check the char count
        /// </summary>
        /// <returns></returns>
        public Boolean IsUniqueWithHashSet(string characters)
        {
            HashSet<char> characterCount = new HashSet<char>();
            foreach (char character in characters)
            {
                // excluding spaces from duplicate list
                if (character != ' ')
                {
                    if (characterCount.Contains(character))
                    {
                        return false;
                    }
                    characterCount.Add(character);
                }
            }
            return true;
        }

        public Boolean IsUnque(string characters)
        {
            for (int i = 0; i < characters.Length; i++)
            {
                for (int j = 0; j < characters.Length; j++)
                {
                    if (i != j)
                    {
                        if (characters[i] == characters[j])
                        {
                            return false;
                        }
                    }
                }
            }

            return true;
        }
    }
}
