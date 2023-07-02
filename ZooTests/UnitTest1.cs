using Zoo;

namespace ZooTests;

public class UnitTest1
{
    [Fact]
    public void Lion_TestEatBehavior()
    {
        // Arrange
        Lion lion = new Lion("lion", 5, "Male", 4);

        // Act
        string behavior = lion.Eat();

        // Assert
        Assert.Equal("The lion is eating.", behavior);
    }

    [Fact]
    public void Cat_TestSleepBehavior()
    {
        // Arrange
        Cat cat = new Cat("kitty", 3, "Female", 4);

        // Act
        string behavior = cat.Sleep();

        // Assert
        Assert.Equal("The cat is Sleeping.", behavior);
    }



    [Fact]
    public void Dog_TestEatBehavior()
    {
        // Arrange
        Dog dog = new Dog("doggo", 4, "Male", 4);

        // Act
        string behavior = dog.Eat();

        // Assert
        Assert.Equal("The dog is eating.", behavior);
    }

    [Fact]
    public void Turtle_TestSleepBehavior()
    {
        // Arrange
        Turtle turtle = new Turtle("Speed", 10, "Female",4);

        // Act
        string behavior = turtle.Sleep();

        // Assert
        Assert.Equal("The turtle is sleeping.", behavior);
    }

    [Fact]
    public void Snake_TestSoundBehavior()
    {
        // Arrange
        Snake snake = new Snake("snake", 8, "Male",0);

        // Act
        string behavior = snake.Sound();

        // Assert
        Assert.Equal("The snake hisses.", behavior);
    }





    //Lab7

    


    //    Test that the classes that implement the interface actually implement it

    [Fact]
    public void ImplementInterface_Test()
    {
        // Arrange
        Lion lion = new Lion("scar", 8, "Male", 4);
        Cat cat = new Cat("Blue", 3, "Female", 4);
        Turtle turtle = new Turtle("toto", 2, "Female", 4);

        // Act
        string result1 = lion.Run();
        string result2 = lion.Swim();
        string result3 = cat.Run();
        string result4 = turtle.Swim();

        // Assert
        Assert.Equal("The lion is running.", result1);
        Assert.Equal("The lion is swimming.", result2);
        Assert.Equal("The cat is running.", result3);
        Assert.Equal("The turtle is swimming.", result4);
    }





    //Test inheritance
    [Fact]
    public void SnakeInheritsReptile()
    {
        Snake snake = new Snake("soso", 3, "Male", 0);

        
        Assert.True(snake is Reptile);
    }




    //Test Polymorphism
    //Prove methods have been overridden

    [Fact]
    public void PolymorphismTest()
    {
     
        Animal lion = new Lion("l1", 5, "Male", 4);
        Animal cat = new Cat("c1", 3, "Female", 4);
        Animal turtle = new Turtle("t1", 10, "Female", 4);

        // Act
        string lionSound = lion.Sound();
        string catSound = cat.Sound();
        string turtleSound = turtle.Sound();

        // Assert
        Assert.Equal("The lion is roaring.", lionSound);
        Assert.Equal("The cat is meowing.", catSound);
        Assert.Equal("The turtle does not make sound.", turtleSound);
    }




    //Prove that one of your concrete animals is an Animal

    [Fact]
    public void LionIsAnimalTest()
    {
        Cat cat = new Cat("Roro", 5, "Female", 4);

       
        Assert.True(cat is Animal);
    }


}
