using System;
namespace Zoo
{
    //derived class
    //concrete class
    public class Dog : Mammal
    {

        public override string Hunt
        {
            get { return "Cat"; }
            set { }
        }

        public override double Weight
        {
            get { return 50; }

        }


        public
            Dog(string name, int age, string gender, int numberOfLegs) : base(name, age, gender, numberOfLegs)
        {
        }

        public override string Eat()
        {
            return "The dog is eating.";
        }


        public override string Sound()
        {
            return "The dog is barking.";
        }

        public override string Sleep()
        {
            return "The dog is sleeping.";
        }

        public override void GiveBirth()
        {
            Console.WriteLine("The dog is giving birth to puppies.");
        }

    }
}

