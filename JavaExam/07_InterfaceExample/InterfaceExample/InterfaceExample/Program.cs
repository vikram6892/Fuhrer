using System;

namespace InterfaceExample
{
    interface IAnimal{
        void animalSound();
    }

    class Tiger : IAnimal {
        public void animalSound(){
            Console.WriteLine("Tiger says : Grrr Grrr" );
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Tiger puli = new Tiger();
            puli.animalSound();
        }
    }
}
