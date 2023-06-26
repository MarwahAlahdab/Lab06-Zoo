using System;
namespace Zoo
{
    //derived class
    //concrete class
    public class Snake : Reptile
    {

        public override bool IsDangerous
        {
            get { return true; }
            
        }

        public override bool HasAShell
        {
            get { return false; }
            set { }

        }


        public Snake(string name, int age, string gender, int NumberOfLegs) : base(NumberOfLegs, name,age,gender)
        {
        }

        public override string Eat()
        {
            return "The snake is eating.";
        }

        public override string Sound()
        {
            return  "The snake hisses.";
        }

        public override string Sleep()
        {
            return "The snake is sleeping.";
        }

        public override void LayEggs()
        {
            Console.WriteLine("The snake is laying eggs.");
        }



    }
    }


