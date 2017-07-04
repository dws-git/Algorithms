using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    /// <summary>
    /// A binary gap within a positive integer N is any maximal sequence of consecutive zeros
    /// that is surrounded by ones at both ends in the binary representation of N.
    /// </summary>
    public class BinaryGap
    {
        /// <summary>
        /// Convert number to its binary representation.
        /// Trim leading and/or trailing zeros.
        /// Split the remaining string (character array) on 1 and return the longest one.
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        public int FindLongestSequenceOfZerosCharArray(int number)
        {
            var binaryString = Convert.ToString(number, 2);
            binaryString = binaryString.TrimEnd('0');
            binaryString = binaryString.TrimStart('0');
            //a string is a character array, search array for zeros - divide and conquer?
            var max = binaryString.Split('1').Max(x => x.Length);
            return max;
        }

        /// <summary>
        /// Remove trailing zeros.
        /// Loop while the number does not equal itself with the last bit removed.
        /// Drop the last bit.
        /// Get the new last bit.
        /// If the last bit is 1, check if the count is greater than the max.
        /// If it is, set the max to the value of the count.
        /// Then reset the counter.
        /// If the last bit is zero, increment the counter.
        /// Return the max.
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        public int FindLongestSequenceOfZerosBitShift(int number)
        {
            int maxOcurrencesOfZero = 0, countOfXeros = 0;
            number |= number - 1;   //bitwise or --> number = (number | (number -1))
            //removes trailing zeros if present
            while (number != number >> 1)
            {
                number >>= 1;
                var lastBit = number & 1;
                bool isNewMax = countOfXeros > maxOcurrencesOfZero;
                if (lastBit == 1)
                {
                    if (isNewMax)
                    {
                        maxOcurrencesOfZero = countOfXeros;
                    }
                    //reset because we are counting between ones
                    countOfXeros = 0;                  
                }
                else   //last bit is zero, so we count it
                {
                    countOfXeros++;
                }
            }
            return maxOcurrencesOfZero;
        }
    }
}
