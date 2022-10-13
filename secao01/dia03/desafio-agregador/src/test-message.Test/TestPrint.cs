using Xunit;
using FluentAssertions;
using System.IO;
using System;

namespace test_message.Test;

public class TestPrint
{
    [Theory(DisplayName = "Deve imprimir a mensagem passada como parâmetro")]
    [InlineData("Olá", "Olá")]
    [InlineData("Teste 01", "Teste 01")]
    [InlineData("Teste 02", "Teste 02")]
    [InlineData("Teste 03", "Teste 03")]
    [InlineData("Teste 04", "Teste 04")]
    [InlineData("Teste 05", "Teste 05")]
    public void TestPrintMsgSucess(string Send, string Expected)
    {
      using (var NewOutput = new StringWriter())
    {
      Console.SetOut(NewOutput);

      Message.PrintMsg(Send);

      string result = NewOutput.ToString().Trim();

      result.Should().Be(Expected);
    }
    }
}
