using Xunit;
using FluentAssertions;
namespace Calculator;

public class UnitTest1
{
    [Fact]
    public void Test_SimpleCalculator_Add_Success()
    {
        SimpleCalculator calculator = new SimpleCalculator();
        int first = 2;
        int second = 5; 

        int result = calculator.Add(first, second);

        result.Should().Be(7);
    }

    [Fact]
    public void Test_SimpleCalculator_Subtract_Success()
    {
        SimpleCalculator calculator = new SimpleCalculator();
        int first = 2;
        int second = 5; 

        int result = calculator.Subtract(first, second);

        result.Should().Be(-3);
    }

    [Fact]
    public void Test_SimpleCalculator_Subtract_Argument_Swap_Success()
    {
        SimpleCalculator calculator = new SimpleCalculator();
        int first = 2;
        int second = 5; 

        int result = calculator.Subtract(second, first);

        result.Should().Be(3);
    }

    [Fact]
    public void Test_SimpleCalculator_Multiply_Success()
    {
        SimpleCalculator calculator = new SimpleCalculator();
        int first = 2;
        int second = 5; 

        int result = calculator.Multiply(first, second);

        result.Should().Be(10);
    }

    [Fact]
    public void Test_SimpleCalculator_Divide_Success()
    {
        SimpleCalculator calculator = new SimpleCalculator();
        int first = 10;
        int second = 2; 

        int result = calculator.Divide(first, second);

        result.Should().Be(5);
    }

    [Fact]
    public void Test_SimpleCalculator_Divide_By_Zero_Exception()
    {
        SimpleCalculator calculator = new SimpleCalculator();
        int first = 10;
        int second = 0; 

        //int result = calculator.Divide(first, second);
        var action = () => calculator.Divide(first, second);

        action.Should().Throw<ArgumentException>()
            .WithParameterName("second");
    }

    [Fact]
    public void Test_SimpleCalculator_Mod_Success()
    {
        SimpleCalculator calculator = new SimpleCalculator();

        int first = 4;
        int second = 2; 

        int result = calculator.Mod(first, second);

        result.Should().Be(0);       
    }
}