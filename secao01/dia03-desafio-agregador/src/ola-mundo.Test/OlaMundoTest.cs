using Xunit;
using FluentAssertions;
// using ola_mundo;
using System.IO;
using System;

namespace ola_mundo.Test;

public class OlaMundoTest
{
  [Theory(DisplayName = "Deve exibir Olá, Mundo!")]
  [InlineData("Olá, Mundo!")]
  public void TestOlaMundo(string Expected)
  {
    var result = HelloWorld2.Greet();
    result.Should().Be(Expected);
  }
}
