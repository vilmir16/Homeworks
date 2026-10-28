namespace Task1.Tests;

public class SearchAlgorithmsTests
{
    [Fact]
    public void BinarySearch_TargetInMiddle_ReturnsIndex()
    {
        int[] array = { 1, 3, 5, 7, 9 };

        int result = SearchAlgorithms.BinarySearch(array, 5);

        Assert.Equal(2, result);
    }

    [Fact]
    public void BinarySearch_TargetIsFirt_ReturnsIndex()
    {
        int[] array = { 1, 3, 5, 7, 9 };

        int result = SearchAlgorithms.BinarySearch(array, 1);

        Assert.Equal(0, result);
    }

    [Fact]
    public void BinarySearch_TargetIsLast_ReturnsIndex()
    {
        int[] array = { 1, 3, 5, 7, 9 };

        int result = SearchAlgorithms.BinarySearch(array, 9);

        Assert.Equal(4, result);
    }

    [Fact]
    public void BinarySearch_NoTarget_ReturnsMinusOne()
    {
        int[] array = { 1, 3, 5, 7, 9 };
        int result = SearchAlgorithms.BinarySearch(array, 10);
        Assert.Equal(-1, result);
    }

    [Fact]
    public void BinarySearch_EmptyArray_ReturnsMinusOne()
    {
        int[] array = { };
        int result = SearchAlgorithms.BinarySearch(array, 10);
        Assert.Equal(-1, result);
    }

    [Fact]
    public void BinarySearch_OneElement_ReturnsIndex()
    {
        int[] array = { 10 };
        int result = SearchAlgorithms.BinarySearch(array, 10);
        Assert.Equal(0, result);
    }

    [Fact]
    public void BinarySearch_OneWrongElement_ReturnsMinusOne()
    {
        int[] array = { 10 };
        int result = SearchAlgorithms.BinarySearch(array, 5);
        Assert.Equal(-1, result);
    }

    [Fact]
    public void BinarySearch_FindString_ReturnsIndex()
    {
        string[] array = { "a", "b", "c" };
        int result = SearchAlgorithms.BinarySearch(array, "b");
        Assert.Equal(1, result);
    }

    [Fact]
    public void BinarySearch_FindDouble_ReturnsIndex()
    {
        double[] array = { 10.11, 10.12, 10.13 };
        int result = SearchAlgorithms.BinarySearch(array, 10.12);
        Assert.Equal(1, result);
    }
}
