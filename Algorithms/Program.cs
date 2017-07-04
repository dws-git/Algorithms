using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            var stopwatch = Stopwatch.StartNew();
            stopwatch.Start();
            BinaryGap algorithm = new BinaryGap();
            //var max = algorithm.FindLongestSequenceOfZerosCharArray(529);
            int max = algorithm.FindLongestSequenceOfZerosBitShift(1041);


            //bit shifting - right shift = divide by 2
            //stopwatch.Stop();
            var elapsedSeconds = stopwatch.Elapsed.TotalMilliseconds;
            //Console.WriteLine(byte42);
            Console.WriteLine(max);
            Console.WriteLine(elapsedSeconds);
            Console.ReadLine();
        }
    }
}
