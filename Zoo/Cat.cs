using System;
namespace Zoo
{
    //derived class
    //concrete class
    public class Cat:Mammal
    {
        public override string Hunt
        {
            get { return "Rats"; }
            set {  }
        }

        public override double Weight
        {
            get { return 4 ; }
            
        }

        public Cat(string name, int age, string gender, int numberOfLegs) : base(name, age, gender, numberOfLegs)
        {
        }

        public override string Eat()
        {
            return "The cat is eating.";
        }

        public override string Sound()
        {
            return  "The cat is meoing.";
        }

        public override string Sleep()
        {
            return "The cat is Sleeping.";
        }

        public override void GiveBirth()
        {
            Console.WriteLine("The cat is giving birth to kittens.");
        }

    }
}

