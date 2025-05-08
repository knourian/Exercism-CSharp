public enum Classification
{
    Perfect,
    Abundant,
    Deficient
}

public static class PerfectNumbers
{
    public static Classification Classify(int number)
    {
        ArgumentOutOfRangeException.ThrowIfLessThanOrEqual(number, 0);

        int sumOfDivisors = SumOfDivisors(number);

        if (sumOfDivisors == number)
        {
            return Classification.Perfect;
        }
        else if (sumOfDivisors > number)
        {
            return Classification.Abundant;
        }
        else
        {
            return Classification.Deficient;
        }
    }

    private static int SumOfDivisors(int number)
    {
        int sum = 0;
        for (int i = 1; i <= number / 2; i++)
        {
            if (number % i == 0)
            {
                sum += i;
            }
        }
        return sum;
    }
}
