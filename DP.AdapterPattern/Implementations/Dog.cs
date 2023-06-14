using DP.AdapterPattern.Contracts;
using System;

namespace DP.AdapterPattern.Implementations
{
    class Dog : IAnimal
    {
        public void MakeSound(string sound)
        {
            Console.WriteLine(sound);
        }
    }
}
