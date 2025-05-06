public static class RealNumberExtension
{
    public static double Expreal(this int realNumber, RationalNumber r)
    {
        return r.Expreal(realNumber);
    }
}

public struct RationalNumber
{
    private int Numerator;
    private int Denominator;
    public RationalNumber(int numerator, int denominator)
    {
        ArgumentOutOfRangeException.ThrowIfEqual(denominator, 0);
        Numerator = numerator;
        Denominator = denominator;
        Reduce();
    }

    public static RationalNumber operator +(RationalNumber r1, RationalNumber r2)
    {
        var newNumerator = r1.Numerator * r2.Denominator + r2.Numerator * r1.Denominator;
        var newDenominator = r1.Denominator * r2.Denominator;
        return new RationalNumber(newNumerator, newDenominator);
    }

    public static RationalNumber operator -(RationalNumber r1, RationalNumber r2)
    {
        var newNumerator = r1.Numerator * r2.Denominator - r2.Numerator * r1.Denominator;
        var newDenominator = r1.Denominator * r2.Denominator;
        return new RationalNumber(newNumerator, newDenominator);
    }

    public static RationalNumber operator *(RationalNumber r1, RationalNumber r2)
    {
        var newNumerator = r1.Numerator * r2.Numerator;
        var newDenominator = r1.Denominator * r2.Denominator;
        return new RationalNumber(newNumerator, newDenominator);
    }

    public static RationalNumber operator /(RationalNumber r1, RationalNumber r2)
    {
        var newNumerator = r1.Numerator * r2.Denominator;
        var newDenominator = r1.Denominator * r2.Numerator;
        return new RationalNumber(newNumerator, newDenominator);
    }

    public RationalNumber Abs()
    {
        Numerator = Math.Abs(Numerator);
        Denominator = Math.Abs(Denominator);
        return this;
    }

    public RationalNumber Reduce()
    {
        if (Denominator < 0)
        {
            Numerator = -Numerator;
            Denominator = -Denominator;
        }

        if (Numerator == 0)
        {
            Denominator = 1;
            return this;
        }

        var gcd = GCD(Numerator, Denominator);
        Numerator /= gcd;
        Denominator /= gcd;
        return this;
    }

    public RationalNumber Exprational(int power)
    {
        var newNumerator = power < 0 ? Math.Pow(Denominator, -power) : Math.Pow(Numerator, power);
        var newDenominator = power < 0 ? Math.Pow(Numerator, -power) : Math.Pow(Denominator, power);
        return new RationalNumber((int)newNumerator, (int)newDenominator);
    }

    public double Expreal(int baseNumber)
    {
        return Math.Pow(baseNumber, (double)Numerator / Denominator);
    }

    private static int GCD(int a, int b)
    {
        a = Math.Abs(a);
        b = Math.Abs(b);

        while (b != 0)
        {
            var temp = b;
            b = a % b;
            a = temp;
        }
        return a;
    }
}