using Zoo;

internal class Program
{
    private static void Main(string[] args)
    {
        Zoo.Zoo zoo = new Zoo.Zoo();

        //Adding Animal to the zoo

        zoo.AddAnimal(new Lion("Simba", 5, "Male", 4));
        zoo.AddAnimal(new Cat("LoLo", 3, "Female", 4));
        zoo.AddAnimal(new Dog("Buddy", 4, "Male", 4));
        zoo.AddAnimal(new Turtle("Speedy", 10, "Female",4));
        zoo.AddAnimal(new Snake("s1", 8, "Male",0));


        zoo.DisplayAnimals();
        zoo.SearchByName("simBa");



        Mammal lion = new Lion("l1", 5, "Male", 4);
        Mammal cat = new Cat("c2", 3, "Female", 4);
        Mammal dog = new Dog("d2", 4, "Male", 4);
        Reptile turtle = new Turtle("t2", 10, "Female",4);
        Reptile snake = new Snake("s2", 8, "Male",0);

        lion.Eat();
        cat.Sleep();
        turtle.Sound();
        Console.WriteLine("snake is dangerous? "+snake.IsDangerous);
        snake.LayEggs();
        cat.GiveBirth();





    }
}