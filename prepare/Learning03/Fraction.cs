public class Fraction 
{
    private int _numerator;
    private int _denominator;

    public Fraction()
    {
        _numerator = 1;
        _denominator = 1;
    }
    public Fraction(int numerator)
    {
        _numerator = numerator;
        _denominator = 1;
    }
    public Fraction(int numerator, int denominator)
    {
        _numerator = numerator;
        _denominator = denominator;
    }
    public int GetTop()
    {
        return _numerator;
    }
    public void SetTop(int numerator)
    {
        _numerator = numerator;
    }
    public int GetBottom()
    {
        return _denominator;
    }
    public void SetBottom(int denominator)
    {
        _denominator = denominator;
    }
    public string GetFractionString()
    {
        return ($"{_numerator}/{_denominator}");
    }
    public double GetDecimalValue()
    {
        double result = (double)_numerator / _denominator;
        return  result;
    }

}