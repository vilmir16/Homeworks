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

    [Fact]
    public void ProductTwoPolynomial()
    {
        Polynomial a = new Polynomial(1, 1);
        Polynomial b = new Polynomial(2, 3);

        Polynomial c = a * b;

        Assert.Equal("2 + 5x + 3x^2", c.ToString());
    }

    [Fact]
    public void TrueEqualsInvalidPolynomial()
    {
        Polynomial a = new Polynomial(1, 1);
        Polynomial b = new Polynomial(1, 1);


        Assert.True(a.Equals(b));
    }

    [Fact]
    public void FalseEqualsInvalidPolynomial()
    {
        Polynomial a = new Polynomial(1, 2);
        Polynomial b = new Polynomial(1, 3);

        Assert.False(a.Equals(b));
    }

    [Fact]
    public void EqualsOfGetHashCode()
    {
        Polynomial a = new Polynomial(1, 2);
        Polynomial b = new Polynomial(1, 2);

        Assert.Equal(a.GetHashCode(), b.GetHashCode());
    }

    [Fact]
    public void EqualOperatorTrue()
    {
        Polynomial a = new Polynomial(1, 2);
        Polynomial b = new Polynomial(1, 2);

        Assert.True(a == b);
    }

    [Fact]
    public void ReverseEqualOperatorTrue()
    {
        Polynomial a = new Polynomial(1, 2);
        Polynomial b = new Polynomial(1, 3);

        Assert.True(a != b);
    }

    [Fact]
    public void NullOperator()
    {
        Polynomial a = new Polynomial(1, 2);

        Assert.False(a == null);
    }

    [Fact]
    public void NullEqualOperator()
    {
        Polynomial? a = null;
        Polynomial b = new Polynomial(1, 2);

        Assert.False(a == b);
    }

    [Fact]
    public void ExpectedDegree()
    {
        Polynomial a = new Polynomial(3, 2, 5);

        Assert.Equal(2, a.Degree);
    }

    [Fact]
    public void IndexerReturnsCoefficients()
    {
        Polynomial a = new Polynomial(3, 2, 5);

        Assert.Equal(3, a[0]);
        Assert.Equal(2, a[1]);
        Assert.Equal(5, a[2]);
    }

    [Fact]
    public void IndexOutOfRangeException()
    {
        Polynomial a = new Polynomial(3, 2, 5);

        Assert.Throws<IndexOutOfRangeException>(() => a[5]);
    }

    [Fact]
    public void EmptyPolynomialDegree()
    {
        Polynomial a = new Polynomial();

        Assert.Equal(-1, a.Degree);
    }

    [Fact]
    public void NegativePolynomial()
    {
        Polynomial a = new Polynomial(1, -2, 3);

        Assert.Equal("1 - 2x + 3x^2", a.ToString());
    }
}
