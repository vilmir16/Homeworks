namespace Task3.Tests;

public class EuclideTests
{
    [Fact]
    public void NormalParametersEuclideanGcd()
    {
        Assert.Equal(25, EuclideanGcd.Calculate(100, 75));
    }

    [Fact]
    public void CalculateWithOutElapsed()
    {
        int result = EuclideanGcd.Calculate(100, 75, out TimeSpan elapsed);
        
        Assert.Equal(25, result);
        Assert.True(elapsed >= TimeSpan.Zero);
    }

    [Fact]
    public void CalculateWithThreeParametersAndElapsed()
    {
        int result = EuclideanGcd.Calculate(12, 18, 24, out TimeSpan elapsed);
        
        Assert.Equal(6, result);
        Assert.True(elapsed >= TimeSpan.Zero);
    }

    [Fact]
    public void CalculateWithFourParameters()
    {
        int result = EuclideanGcd.Calculate(12, 18, 24, 30);
        
        Assert.Equal(6, result);
    }

    [Fact]
    public void CalculateWithZeroParameters()
    {
        int result = EuclideanGcd.Calculate();
        
        Assert.Equal(0, result);
    }

    [Fact]
    public void CalculateWithParamsAndElapsed()
    {
        int result = EuclideanGcd.Calculate(out TimeSpan elapsed, 12, 18, 24, 30);
        
        Assert.Equal(6, result);
        Assert.True(elapsed >= TimeSpan.Zero);
    }

    [Fact]
    public void CalculatWithFirstZeroParameter()
    {
        int result = EuclideanGcd.Calculate(0, 5);
        
        Assert.Equal(5, result);
    }
    
    [Fact]
    public void CalculatWithSecondZeroParameter()
    {
        int result = EuclideanGcd.Calculate(5, 0);
        
        Assert.Equal(5, result);
    }
    
    [Fact]
    public void CalculateWithTwoZeroParameters()
    {
        int result = EuclideanGcd.Calculate(0, 0);
        
        Assert.Equal(0, result);
    }

    [Fact]
    public void CalculateWithMinusParameter()
    {
        int result = EuclideanGcd.Calculate(12, -18);

        Assert.Equal(6, Math.Abs(result));
    }
    
    [Fact]
    public void CalculateParameter()
    {
        int result = EuclideanGcd.Calculate(12, -18);

        Assert.Equal(6, result);
    }
}
