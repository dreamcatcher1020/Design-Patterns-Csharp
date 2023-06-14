using DP.AdapterPattern.Contracts;

namespace DP.AdapterPattern.Implementations
{
    class ParrotAdapter : IHuman
    {
        private IAnimal _animal;

        public ParrotAdapter(IAnimal animal)
        {
            _animal = animal;
        }

        public void SpeakWords(string words)
        {
            _animal.MakeSound(words);
        }
    }
}
