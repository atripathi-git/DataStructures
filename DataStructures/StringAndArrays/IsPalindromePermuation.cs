using System;
using System.Text;

namespace DataStructures.StringAndArrays
{
    public class IsPalindromePermuation
    {
        public IsPalindromePermuation()
        {
            Console.WriteLine(IsPermutationPlindrome("aabbcddf"));
        }

        public Boolean IsPermutationPlindrome(string phrase)
        {
            int bitVector = CreateBitVector(phrase);
            return bitVector == 0 || checkExactlyOneBitSet(bitVector);
        }

        private int CreateBitVector(string phrase)
        {
            int bitVector = 0;

            var byteOfA = Encoding.ASCII.GetBytes("a");
            var byteOfZ = Encoding.ASCII.GetBytes("z");

            byte[] byteArray = Encoding.ASCII.GetBytes(phrase);

            foreach (byte c in byteArray)
            {

                int x = c - byteOfA[0];

                bitVector = toggle(bitVector, Convert.ToInt32(x));
            }

            return bitVector;
        }

        private int toggle(int bitVector, int index)
        {
            if (index < 0) return bitVector;

            int mask = 1 << index;

            if((bitVector & mask) == 0)
            {
                bitVector |= mask;
            }
            else
            {
                bitVector &= ~mask;
            }

            return bitVector;
        }

        private Boolean checkExactlyOneBitSet(int bitVector)
        {
            return (bitVector & (bitVector - 1)) == 0;
        }
    }
}
