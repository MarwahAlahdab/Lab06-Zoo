using System;
namespace Zoo
{
    //derived class
    // parent class for (Snake,Turtle)
    // abstract class
    
    public abstract class Reptile : Animal
    {

        public int NumberOfLegs { get; set; }

        public abstract bool IsDangerous { get; } // Abstract property

        public virtual bool HasAShell { get; set; } // Virtual property


        public Reptile(int NumberOfLegs, string name, int age, string gender):base(name,age,gender)
        {
            this.NumberOfLegs = NumberOfLegs;
        }

        /*
    virtual method
    overridden in (Snake,Turtle)
  */
        public virtual void LayEggs()
        {
            Console.WriteLine("The reptile is laying eggs.");
        }



        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"Number of Legs: {NumberOfLegs}");
        }




    }
}

