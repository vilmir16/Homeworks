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
}
