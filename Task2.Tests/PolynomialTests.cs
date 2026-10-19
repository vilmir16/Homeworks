namespace Task2.Tests;

public class PolynomialTests
{
    [Fact]
    public void Normal()
    {
        Polynomial p = new Polynomial(3, 2, 5);

        string result = p.ToString();

        Assert.Equal("3 + 2x + 5x^2", result);
    }

    [Fact]
    public void NormalWithX()
    {
        Polynomial p = new Polynomial(3, 2, 5);

        double result = p.Calculate(3);
        
        Assert.Equal(54, result);
    }

    [Fact]
    public void SumTwoPolynomial()
    {
        Polynomial a = new Polynomial(1, 1);
        Polynomial b = new Polynomial(2, 0, 4);
        
        Polynomial c = a + b;
        
        Assert.Equal("3 + 1x + 4x^2", c.ToString());
        
    }

    [Fact]
    public void SubstractionTwoPolynomial()
    {
        Polynomial a = new Polynomial(3, 2, 5);
        Polynomial b = new Polynomial(1, 0);
        
        Polynomial c = a - b;
        
        Assert.Equal("2 + 2x + 5x^2", c.ToString());
    }
}
