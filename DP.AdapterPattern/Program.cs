using DP.AdapterPattern.Implementations;
using System;

namespace DP.AdapterPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Dog dog = new Dog();
            Male male = new Male();
            Parrot parrot = new Parrot();
            ParrotAdapter parrotAdapter = new ParrotAdapter(parrot);            

            dog.MakeSound("Bhow Bhow!");
            male.SpeakWords("Ssup dude!");
            parrot.MakeSound("Phew!");

            // parrot should not 'make sound', it should 'speak words'
            parrotAdapter.SpeakWords("Hey, parrot can speak.");

            Console.ReadLine();
        }
    }
}
