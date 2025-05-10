public static class PrimeFactors
{
    public static long[] Factors(long number)
    {
        var factors = new List<long>();

        for (long i = 2; i <= number; i++)
        {
            while (number % i == 0)
            {
                factors.Add(i);
                number /= i;
            }
        }
        return [.. factors];
    }
}