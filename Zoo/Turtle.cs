using System;
namespace Zoo
{
    //derived class
    //concrete class
    public class Turtle : Reptile, ISwimmable
    {

        public override bool IsDangerous
        {
            get { return false; }

        }

        public override bool HasAShell
        {
            get { return true; }
            set { }

        }



        public Turtle(string name, int age, string gender, int numberOfLegs) : base(numberOfLegs, name,age,gender)
        {

        }

        public override string Eat()
        {
            return "The turtle is eating.";
        }

        public override string Sound()
        {
            return "The turtle does not make sound.";
        }

        public override string Sleep()
        {
            return "The turtle is sleeping.";
        }

        public override void LayEggs()
        {
            Console.WriteLine("The turtle is laying eggs.");
        }



        public string Swim()
        {
            return "The turtle is swimming.";
        }

    }
}

