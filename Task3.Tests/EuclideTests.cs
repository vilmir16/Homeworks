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
}
