using System;
namespace Zoo
{

    // parent class
    // abstract class
    public abstract class Animal
    {

        public string Name { get; set; }
        private int Age { get; set; }
        private string Gender { get; set; }
       


        public Animal(string name, int age, string gender )
        {
            this.Name = name;
            this.Age = age;
            this.Gender = gender;
        }



        /*
         abstract methods
        overridden in all animals types classes
         */

        public abstract string Eat();

        public abstract string Sound();

        public abstract string Sleep();

        /*
      virtual method
     overridden in Mammal and Reptile
      */
        public virtual void DisplayInfo()
        {
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Age: {Age}");
            Console.WriteLine($"Gender: {Gender}");
       

        }

    }
}

