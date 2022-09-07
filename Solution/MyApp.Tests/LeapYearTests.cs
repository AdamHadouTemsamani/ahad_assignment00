namespace MyApp.Tests;

using LeapYear;

public class LeapYearTests
{
    
    [Fact]
    public void Check_If_Divisible_By_Four()
    {
        // Arrange 
            int input = 1624;
            var leapYear = new LeapYearClass();

        // Act
            var result = LeapYearClass.IsLeapYear(input);

        // Assert
            result.Should().Be(true);

    }   

    [Fact]
    public void Check_If_Divisible_By_Hundred()
    {
        // Arrange 
            int input = 2200;
            var leapYear = new LeapYearClass();

        // Act
            var result = LeapYearClass.IsLeapYear(input);

        // Assert
            result.Should().Be(true);

    }   

     [Fact]
    public void Check_If_Divisible_By_Four_Hundred()
    {
        // Arrange 
            int input = 2000;

        // Act
            var result = LeapYearClass.IsLeapYear(input);

        // Assert
            result.Should().Be(true);
    }

    [Fact]
    public void Check_If_Leap_Year()
    {
        // Arrange
            int input = 1624;
            var leapYear = new LeapYearClass();

        // Act
            var result = LeapYearClass.IsLeapYear(input);

        // Assert
            result.Should().Be(true);
    }

    [Fact]
    public void Check_If_Parsable_Correct_Input()
    {
        // Arrange
            string input = "1000";
        // Act
            var result = LeapYearClass.IsParsable(input);

        // Assert
            result.Should().Be(true);
    }
    
    [Fact]
    public void Check_If_Parsable_Incorrect_Input()
    {
        // Arrange
            string input = "Hello";
            
        // Act
            var result = LeapYearClass.IsParsable(input);
        
        // Assert
            result.Should().Be(false);
        
    }


}