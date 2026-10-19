namespace Task2;

public class Polynomial
{
    private readonly double[] _coefficients;

    public int Degree => _coefficients.Length - 1;

    public double this[int index] => _coefficients[index];
    
    public Polynomial(params double[] coefficients)
    {
       _coefficients = coefficients;
    }

    public override string ToString()
    {
        string result = "";
        for (int i = 0; i <= _coefficients.Length - 1; i++)
        {
            if (i != 0)
            {
                result += " + " + _coefficients[i];
            }
            else
            {
                result += _coefficients[i];

            }

            if (i == 1)
            {
                result += "x";
            }
            else if (i > 1)
            {
                result += "x^" + i;
            }
        }
        return result;
    }

    public double Calculate(double x)
    {
        double result = 0;

        for (int i = 0; i <= _coefficients.Length - 1; i++)
        {
            result += _coefficients[i] * Math.Pow(x, i);
        }
        return result;
    }

    public static Polynomial operator +(Polynomial a, Polynomial b)
    {
        double[] array = new double [Math.Max(a._coefficients.Length, b._coefficients.Length)];
        for (int i = 0; i <= array.Length - 1; i++)
        {
            double aValue;
            if (i < a._coefficients.Length)
            {
                aValue = a._coefficients[i];
            }
            else
            {
                aValue = 0;
            }

            double bValue;
            if (i < b._coefficients.Length)
            {
                bValue = b._coefficients[i];
            }
            else
            {
                bValue = 0;
            }
            array[i] = aValue + bValue;
        }
        return new Polynomial(array);
    }

    public static Polynomial operator -(Polynomial a, Polynomial b)
    {
        double[] array = new double[Math.Max(a._coefficients.Length, b._coefficients.Length)];
        for (int i = 0; i < array.Length; i++)
        {
            double aValue;
            if (i < a._coefficients.Length)
            {
                aValue = a._coefficients[i];
            }
            else
            {
                aValue = 0;
            }

            double bValue;
            if (i < b._coefficients.Length)
            {
                bValue = b._coefficients[i];
            }
            else
            {
                bValue = 0;
            }

            array[i] = aValue - bValue;
        }
        return new Polynomial(array);
    }
}
