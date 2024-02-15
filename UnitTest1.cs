using System;
using Lab2; // Make sure to include the namespace of your Lab2 project
namespace Lab2Test;
public class Lab2Tests
{
    [Fact]
    public void TestMinimumOfTwoNumbers()
    {
        // Arrange
        int a = 5;
        int b = 10;
        int expectedMinimum = 5;

        // Act
        Lab lab = new Lab();
        int actualMinimum = lab.FindMinimum(a, b);

        // Assert
        Assert.Equal(expectedMinimum, actualMinimum);
    }

    [Fact]
    public void TestMinimumOfThreeNumbers()
    {
        // Arrange
        int a = 15;
        int b = 10;
        int c = 20;
        int expectedMinimum = 10;

        // Act
        Lab lab = new Lab();
        int actualMinimum = lab.FindMinimum(a, b, c);

        // Assert
        Assert.Equal(expectedMinimum, actualMinimum);
    }
}
