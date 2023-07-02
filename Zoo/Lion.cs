using System;
namespace Zoo
{
    //derived class
    //concrete class
    public class Lion: Mammal, IRunnable, ISwimmable
    {
        public override string Hunt
        {
            get { return "Deer"; }
            set { }
        }

        public override double Weight
        {
            get { return 200; }
            
        }

        public Lion(string name, int age, string gender, int numberOfLegs) : base(name, age, gender, numberOfLegs)
        {
        }

        public override string Eat()
        {
            return "The lion is eating.";
        }

        public override string Sound()
        {
            return "The lion is roaring.";
        }

        public override string Sleep()
        {
            return "The lion is Sleeping.";
        }
        public override void GiveBirth()
        {
            Console.WriteLine("The lion is giving birth to cubs.");
        }

        public string Run()
        {
            return "The lion is running.";
        }

        public string Swim()
        {
           return "The lion is swimming.";
        }

    }
}

