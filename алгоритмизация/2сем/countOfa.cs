using System;
using System.IO;

namespace FindShortestString
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] lines = File.ReadAllLines("input.txt");

            int minSequenceLength = int.MaxValue;
            string shortestString = "";


            foreach (string line in lines)
            {
                int sequenceLength = 0;
                foreach (char c in line)
                {
                    if (c == 'a')
                    {
                        sequenceLength++;
                    }
                }

                if (sequenceLength < minSequenceLength)
                {
                    minSequenceLength = sequenceLength;
                    shortestString = line;
                }
            }

            Console.WriteLine(shortestString);
        }
    }
}