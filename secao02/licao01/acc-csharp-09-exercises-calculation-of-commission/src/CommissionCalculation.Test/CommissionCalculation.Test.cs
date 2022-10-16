using FluentAssertions;
using System.Globalization;

namespace CommissionCalculation.Test
{
  public class CommissionCalculatorTest
  {
    [Theory(DisplayName = "Deve calcular corretamente o salário e armazenar o resultado no atributo FinalSalary.")]
    [InlineData(1200, 2, 60000, 3500)]
    public void TestCalculateFinalSalary(decimal fixedSalary, int amountCarsSold, decimal totalSalesValue, decimal expectedFinalSalary)
    {
      Thread.CurrentThread.CurrentCulture = new CultureInfo("en-US", false);
      CommissionCalculator commissionCalculator = new CommissionCalculator();
      commissionCalculator.CalculateFinalSalary(fixedSalary, amountCarsSold, totalSalesValue);
      _ = commissionCalculator.FinalSalary.Should().Be(expectedFinalSalary);
    }

    [Theory(DisplayName = "Deve exibir corretamente a mensagem de salário final.")]
    [InlineData("Jorge", "maio", new string[] {
        "O colaborador Jorge neste mês de maio obteve o salário final de R$0.00 referente à:",
        "SALARIO FIXO: R$0.00",
        "TOTAL DE CARROS VENDIDOS: 0",
        "VALOR TOTAL DE VENDAS NO MES: R$0.00",
        "COMISSÃO POR CARROS VENDIDOS: R$0.00",
        "COMISSÃO DE 3% DO TOTAL DE VENDAS: R$0.00"
    })]
    public void TestShowFinalSalary(string contributorName, string month, string[] expectedMessage)
    {
      Thread.CurrentThread.CurrentCulture = new CultureInfo("en-US", false);
      CommissionCalculator commissionCalculator = new CommissionCalculator();

      using StringWriter NewOutput = new StringWriter();
      Console.SetOut(NewOutput);

      commissionCalculator.ShowFinalSalary(contributorName, month);
      string[] result = NewOutput.ToString().Split(Environment.NewLine, StringSplitOptions.RemoveEmptyEntries);
      for (int i = 0; i < result.Length; i++)
      {
        _ = result[i].Should().BeEquivalentTo(expectedMessage[i]);
      }
    }
  }
}
