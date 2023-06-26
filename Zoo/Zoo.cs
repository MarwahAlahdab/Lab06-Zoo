using System;
using static System.Reflection.Metadata.BlobBuilder;

namespace Zoo
{
    public class Zoo
    {

        public List<Animal> animals = new List<Animal>();

        public Zoo()
        {
            animals = new List<Animal>();
        }



        public void AddAnimal(Animal animal)
        {
            animals.Add(animal);
            Console.WriteLine($"{animal.Name} has been added to the zoo");
        }





        public void DisplayAnimals()
        {
          
            foreach (var animal in animals)
            {
                animal.DisplayInfo();
                Console.WriteLine();
            }
        }







        public void SearchByName(string name)
        {

            foreach (var animal in animals)
            {
                if (animal.Name.ToLower().Contains(name.ToLower()))
                    Console.Write($"{animal.Name} is found!");
                Console.WriteLine();
            }
        }



    }
}

