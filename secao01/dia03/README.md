# Aceleração em C#
## C# - Do zero ao Deploy
### Dia 03:  Aplicando testes com xUnit desde cedo

#### Aplicando testes com xUnit
* Criação de um projeto `.NET` do tipo `xUnit`;
  ~~~shell
  dotnet new xunit -o <Nome do projeto>
  ~~~

  * Exemplos de código:
    * Função a ser testada:
    ~~~c#
    public static int Sum(int number1, int number2)
    {
      var result = number1 + number2;
      return result;
    }

    Sum(3, 3) // deve retornar 6
    Sum(-10, 3) // deve retornar -7
    Sum(77, 33) // deve retornar 110
    ~~~

    * Teste da função:
    ~~~c#
    [Fact]
    public void TestSum()
    {
      Assert.Equal(Sum(77, 33), 110);
    }
    ~~~

* Biblioteca `FluentAssertions`:
  * Testes mais legíveis;
  * Instalação:
    ~~~shell
    dotnet add package FluentAssertions --version 6.5.1
    dotnet restore
    ~~~
    * Teste da função com a FluentAssertions:
    ~~~c#
    [Fact]
    public void TestSumFluent()
    {
        result = Sum(77, 33)
        result.Should().Be(110)
    }
    ~~~

* Os `data annotations`:
  * Marcadores para:
    * Identificação dos testes;
    * Descrição dos testes;
    * Passagem de parâmetros para a função;

  * `[FACT]`: *data annotation* que indica que o teste  é invariante quanto aos parâmetros de entrada;
    ~~~c#
    [Fact]
    public void TestSumFluent()
    {
      result = Sum(77, 33)
      result.Should().Be(110)
    }
    ~~~

  * `[THEORY]`: nos permite passar diversos valores para a função de teste utilizando outra *data annotation* chamada de `[InLineData()]`.
    ~~~c#
    [Theory(DisplayName = "Deve somar corretamente as entradas.")]
    [InlineData(3, 3, 6)]
    [InlineData(-10, 3, -7)]
    [InlineData(77, 33, 110)]

    public void TestSumFluent(int entry1, int entry2, int expected)
    {
        result = Sum(entry1, entry2)
        result.Should().Be(expected)
    }
    ~~~
