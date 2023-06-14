using DP.AdapterPattern.Contracts;
using System;

namespace DP.AdapterPattern.Implementations
{
    class Parrot : IAnimal
    {
        public void MakeSound(string sound)
        {
            Console.WriteLine(sound);
        }
    }
}
