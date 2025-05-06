public static class CollatzConjecture
{
    public static int Steps(int number)
    {
        ArgumentOutOfRangeException.ThrowIfLessThanOrEqual(number, 0);
        int steps = 0;
        while (number > 1)
        {
            if (number % 2 == 0)
            {
                number /= 2;
            }
            else
            {
                number = number * 3 + 1;
            }
            steps++;
        }
        return steps;
    }
}