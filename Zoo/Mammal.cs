using System;
namespace Zoo
{
    //derived class
    // parent class for (Cat,Lion,Dog)
    // abstract class
    public abstract class Mammal: Animal
    {



        public int NumberOfLegs { get; set; }

        public abstract double Weight { get; } // Abstract property
                                                
        public virtual string Hunt { get; set; } // Virtual property


        public Mammal(string name, int age, string gender, int numberOfLegs) : base(name, age, gender)
        {
            NumberOfLegs = numberOfLegs;
        }

        /*
     virtual method
     overridden in (Cat,Lion,Dog)
   */
        public virtual void GiveBirth()
        {
            Console.WriteLine("The mammal is giving birth.");
        }


        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"Number of Legs: {NumberOfLegs}");
            Console.WriteLine($"Weight: {Weight}");
            Console.WriteLine($"Hunting a: {Hunt}");
        }



    }
}

