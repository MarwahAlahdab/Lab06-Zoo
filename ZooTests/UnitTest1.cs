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
}
