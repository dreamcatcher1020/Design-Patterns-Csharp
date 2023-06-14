using DP.AdapterPattern.Contracts;
using System;

namespace DP.AdapterPattern.Implementations
{
    class Male : IHuman
    {
        public void SpeakWords(string words)
        {
            Console.WriteLine(words);
        }
    }
}
