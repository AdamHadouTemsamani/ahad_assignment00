namespace MyApp.Tests;

public class ProgramTests
{
    [Fact]
    public void Print_Hello_World()
    {
        // Arrange
            using var writer = new StringWriter();
            Console.SetOut(writer);

        // Act
            var program = AssemblyLoadEventArgs.Load(nameof(MyApp));
            program.EntryPoint?.Invoke(null, new[] { Array.Empty<string>});

        // Assert
            var output = writer.GetStringBuilder().ToString().TrimEnd();
            output.Should().Be("Hello, World!");

    }


    [Fact]
    public void Check_If_LeapYear()
    {
        // Arrange 
            var program = new Program();

        // Act
            var result = program.IsLeapYear(1000);

        // Assert
            result.Should().Be(false);

    }   
}