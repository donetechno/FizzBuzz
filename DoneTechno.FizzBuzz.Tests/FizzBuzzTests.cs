namespace DoneTechno.FizzBuzz.Tests;

public class FizzBuzzTests
{
    [Fact]
    public void GivenConsole_ShouldPrintFizzBuzz()
    {
       // Arrange
            var writer = new StringWriter();        
            Console.SetOut(writer); 

            // Act
            new Program().Run();

            // Assert
            var sb = writer.GetStringBuilder();
            Assert.Equal("Hello World!", sb.ToString().Trim());
    }
}