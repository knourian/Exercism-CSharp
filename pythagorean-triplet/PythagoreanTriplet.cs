public static class PythagoreanTriplet
{
    public static IEnumerable<(int a, int b, int c)> TripletsWithSum(int sum)
    {
        for (int a = 1; a < sum / 3; a++)
        {
            for (int b = a + 1; b < sum / 2; b++)
            {
                int c = sum - a - b;
                if (a * a + b * b == c * c)
                {
                    yield return (a, b, c);
                }
            }
        }
    }
}