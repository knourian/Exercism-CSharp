public static class AllYourBase
{
    public static int[] Rebase(int inputBase, int[] inputDigits, int outputBase)
    {
        if (inputBase < 2 || outputBase < 2)
            throw new ArgumentException("Base must be greater than 1.");
        if (inputDigits.Any(x => x < 0))
            throw new ArgumentException("Digits must be non-negative.");
        if (inputDigits.Any(x => x >= inputBase))
            throw new ArgumentException($"Digits must be less than the input base {inputBase}.");
        var number = ConvertFromBase(inputDigits, inputBase);
        return ConvertToBase(number, outputBase);
    }

    private static int[] ConvertToBase(int number, int baseValue)
    {
        if (number == 0) return new[] { 0 };
        var digits = new List<int>();
        while (number > 0)
        {
            digits.Add(number % baseValue);
            number /= baseValue;
        }
        digits.Reverse();
        return digits.ToArray();
    }
    private static int ConvertFromBase(int[] digits, int baseValue)
    {
        int number = 0;
        for (int i = 0; i < digits.Length; i++)
        {
            number = number * baseValue + digits[i];
        }
        return number;
    }
}