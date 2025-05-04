using System.Linq;

public static class Pangram
{
    private const string Alphabet = "abcdefghijklmnopqrstuvwxyz";
    public static bool IsPangram(string input)
    {
        if (string.IsNullOrEmpty(input))
        {
            return false;
        }
        return Alphabet.All(c => input.ToLowerInvariant().Contains(c));
    }
}
