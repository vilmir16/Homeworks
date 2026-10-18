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
    
}
