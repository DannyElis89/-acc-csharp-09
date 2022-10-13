using FluentAssertions;

namespace greet.Test
{
  public class UnitTest1
  {
    [Theory(DisplayName = "Deve retornar \"Olá\"")]
    [InlineData("Olá")]
    public void TestGreet(string expected)
    {
      string result = Class1.Greet();
      _ = result.Should().Be(expected);
    }
  }
}
