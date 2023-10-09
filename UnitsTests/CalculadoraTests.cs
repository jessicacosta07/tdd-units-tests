using UnitsTestsConsole.Services;

namespace UnitsTests;

public class CalculadoraTests
{
    [Theory]
    [InlineData(1, 2, 3)]
    [InlineData(4, 4, 8)]
    public void Somar(int num1, int num2, int result)
    {
        Calculadora calc = new Calculadora();
        int resultado = calc.Somar(num1, num2);

        Assert.Equal(result, resultado);
    }

    [Theory]
    [InlineData(4, 1, 3)]
    [InlineData(5, 2, 3)]
    public void Subtrair(int num1, int num2, int result)
    {
        Calculadora calc = new Calculadora();
        int resultado = calc.Subtrair(num1, num2);

        Assert.Equal(result, resultado);
    }

    [Theory]
    [InlineData(2, 2, 4)]
    [InlineData(4, 4, 16)]
    public void Multiplicar(int num1, int num2, int result)
    {
        Calculadora calc = new Calculadora();
        int resultado = calc.Multiplicar(num1, num2);

        Assert.Equal(result, resultado);
    }

    [Theory]
    [InlineData(4, 2, 2)]
    [InlineData(6, 2, 3)]
    public void Dividir(int num1, int num2, int result)
    {
        Calculadora calc = new Calculadora();
        int resultado = calc.Dividir(num1, num2);

        Assert.Equal(result, resultado);
    }
    [Fact]
    public void DividirPorZero()
    {
        Calculadora calc = new Calculadora();

        Assert.Throws<DivideByZeroException>(
            () => calc.Dividir(3, 0)
        );
    }

    [Fact]
    public void Historico()
    {
        Calculadora calc = new Calculadora();

        calc.Somar(1, 2);
        calc.Somar(3, 4);
        calc.Somar(5, 4);
        calc.Dividir(4, 2);
        calc.Dividir(3, 1);
        calc.Dividir(4, 2);
        var lista = calc.Historico();
        Assert.Equal(0, lista.Count);
    }
}