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
            var program = Assembly.Load(nameof(MyApp));
            program.EntryPoint?.Invoke(null, new[] { Array.Empty<string>() });

        // Assert
            var output = writer.GetStringBuilder().ToString().TrimEnd();
            output.Should().Be("C#, Hello World!");

    }
}