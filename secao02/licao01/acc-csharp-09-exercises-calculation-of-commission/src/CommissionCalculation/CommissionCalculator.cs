namespace CommissionCalculation
{
  public class CommissionCalculator
  {
    public const decimal CommissionPerCarSold = 250;
    public decimal FixedSalary { get; set; }
    public int AmountCarsSold { get; set; }
    public decimal TotalSalesValue { get; set; }
    public decimal FinalSalary { get; set; }

    public void CalculateFinalSalary(decimal fixedSalary, int amountCarsSold, decimal totalSalesValue)
    {
      FixedSalary = fixedSalary;
      AmountCarsSold = amountCarsSold;
      TotalSalesValue = totalSalesValue;

      decimal finalSalary = fixedSalary;

      finalSalary += CommissionPerCarSold * amountCarsSold;
      finalSalary += totalSalesValue * 0.03m;

      FinalSalary = finalSalary;
    }

    public void ShowFinalSalary(string contributorName, string month)
    {
      Console.WriteLine($"O colaborador {contributorName} neste mês de {month} obteve o salário final de R${FinalSalary:F2} referente à:");
      Console.WriteLine($"SALARIO FIXO: R${FixedSalary:F2}");
      Console.WriteLine($"TOTAL DE CARROS VENDIDOS: {AmountCarsSold}");
      Console.WriteLine($"VALOR TOTAL DE VENDAS NO MES: R${TotalSalesValue:F2}");
      Console.WriteLine($"COMISSÃO POR CARROS VENDIDOS: R${CommissionPerCarSold * AmountCarsSold:F2}");
      Console.WriteLine($"COMISSÃO DE 3% DO TOTAL DE VENDAS: R${TotalSalesValue * 0.03m:F2}");
    }
  }
}
