namespace MyApp.Tests;

public class LeapYearTests
{
    
    [Fact]
    public void Check_If_Divisible_By_Four()
    {
        // Arrange 
            int input = 1624;
            var leapYear = new LeapYear();

        // Act
            var result = leapYear.IsLeapYear(input);

        // Assert
            result.Should().Be(true);

    }   

    [Fact]
    public void Check_If_Divisible_By_Hundred()
    {
        // Arrange 
            int input = 800;
            var leapYear = new LeapYear();

        // Act
            var result = leapYear.IsLeapYear(input);

        // Assert
            result.Should().Be(true);

    }   

     [Fact]
    public void Check_If_Divisible_By_Four_Hundred()
    {
        // Arrange 
            int input = 2000;
            var leapYear = new LeapYear();

        // Act
            var result = leapYear.IsLeapYear(input);

        // Assert
            result.Should().Be(true);
    }

    [Fact]
    public void Check_If_Leap_Year()
    {
        // Arrange
            int input = 1624;
            var leapYear = new LeapYear();

        // Act
            var result = leapYear.IsLeapYear(input);

        // Assert
            result.Should().Be(true);
    }

    [Fact]
    public void Check_If_Parsable_Correct_Input()
    {
        // Arrange
            string input = "1000";
            var leapYear = new LeapYear();

        // Act
            var result = leapYear.isParsable(input);

        // Assert
            result.Should().Be(true);
    }

    public void Check_If_Parsable_Incorrect_Input()
    {
        // Arrange
            string input = "Hello";
            var leapYear = new LeapYear();

        // Act & Assert
            Assert.Throws<FormatException>(
                () => leapYear.isParsable(input));
        
    }


}