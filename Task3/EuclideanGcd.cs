using System.Diagnostics;
namespace Task3;

public static class EuclideanGcd
{
    public static int Calculate(int a, int b)
    {
        int c = 0;
        while (b != 0)
        {
            c = a % b;
            a = b;
            b = c;
        }
        return Math.Abs(a);
    }

    public static int Calculate(int a, int b, out TimeSpan elapsed)
    {
        Stopwatch sw = Stopwatch.StartNew();
        int result = Calculate(a, b);
        sw.Stop();
        elapsed = sw.Elapsed;
        return result;
    }

    public static int Calculate(int a, int b, int c, out TimeSpan elapsed)
    {
        Stopwatch sw = Stopwatch.StartNew();
        int firstTwoParams = Calculate(a, b);
        int secondResult = Calculate(firstTwoParams, c);
        sw.Stop();
        elapsed = sw.Elapsed;
        return secondResult;
    }

    public static int Calculate(params int[] numbers)
    {
        int result = 0;
        for (int i = 0; i < numbers.Length; i++)
        {
            result = Calculate(result, numbers[i]);
        }

        return result;
    }

    public static int Calculate(out TimeSpan elapsed, params int[] numbers)
    {
        Stopwatch sw = Stopwatch.StartNew();
        int result = Calculate(numbers);
        sw.Stop();
        elapsed = sw.Elapsed;
        return result;
    }
    
}
