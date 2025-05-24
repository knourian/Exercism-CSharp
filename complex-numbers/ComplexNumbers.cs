
public static class ComplexNumberExtensions
{
    public static ComplexNumber Add(this ComplexNumber a, int b) => a.Add(new ComplexNumber(b, 0));
    public static ComplexNumber Sub(this ComplexNumber a, int b) => a.Sub(new ComplexNumber(b, 0));
    public static ComplexNumber Mul(this ComplexNumber a, int b) => a.Mul(new ComplexNumber(b, 0));
    public static ComplexNumber Div(this ComplexNumber a, int b) => a.Div(new ComplexNumber(b, 0));
}


public struct ComplexNumber
{
    private readonly double _real;
    private readonly double _imaginary;
    public ComplexNumber(double real, double imaginary)
    {
        _real = real;
        _imaginary = imaginary;
    }

    public double Real() => _real;

    public double Imaginary() => _imaginary;

    public ComplexNumber Mul(ComplexNumber other)
    {
        var newReal = _real * other._real - _imaginary * other._imaginary;
        var newImaginary = _real * other._imaginary + _imaginary * other._real;
        return new ComplexNumber(newReal, newImaginary);
    }

    public ComplexNumber Add(ComplexNumber other)
    {
        var newReal = _real + other._real;
        var newImaginary = _imaginary + other._imaginary;
        return new ComplexNumber(newReal, newImaginary);
    }

    public ComplexNumber Sub(ComplexNumber other)
    {
        var newReal = _real - other._real;
        var newImaginary = _imaginary - other._imaginary;
        return new ComplexNumber(newReal, newImaginary);
    }

    public ComplexNumber Div(ComplexNumber other)
    {
        if (other._real == 0 && other._imaginary == 0)
            throw new DivideByZeroException("Cannot divide by zero complex number.");

        var denominator = other._real * other._real + other._imaginary * other._imaginary;
        var newReal = (_real * other._real + _imaginary * other._imaginary) / denominator;
        var newImaginary = (_imaginary * other._real - _real * other._imaginary) / denominator;
        return new ComplexNumber(newReal, newImaginary);
    }

    public double Abs()
    {
        return Math.Sqrt(_real * _real + _imaginary * _imaginary);
    }

    public ComplexNumber Conjugate()
    {
        return new ComplexNumber(_real, -_imaginary);
    }

    public ComplexNumber Exp()
    {
        var expReal = Math.Exp(_real);
        return new ComplexNumber(expReal * Math.Cos(_imaginary), expReal * Math.Sin(_imaginary));
    }
}