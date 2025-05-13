using System.Text;

public static class RunLengthEncoding
{
    public static string Encode(string input)
    {
        if (string.IsNullOrEmpty(input))
            return string.Empty;

        var result = new StringBuilder();
        int count = 1;

        for (int i = 1; i < input.Length; i++)
        {
            if (input[i] == input[i - 1])
            {
                count++;
            }
            else
            {
                AppendEncoded(result, input[i - 1], count);
                count = 1;
            }
        }

        AppendEncoded(result, input[^1], count);
        return result.ToString();
    }

    public static string Decode(string input)
    {
        if (string.IsNullOrEmpty(input))
            return string.Empty;

        var result = new StringBuilder();
        int count = 0;

        foreach (char c in input)
        {
            if (char.IsDigit(c))
            {
                count = count * 10 + (c - '0');
            }
            else
            {
                result.Append(count > 0 ? new string(c, count) : c.ToString());
                count = 0;
            }
        }

        return result.ToString();
    }

    private static void AppendEncoded(StringBuilder result, char character, int count)
    {
        if (count > 1)
            result.Append(count);
        result.Append(character);
    }
}
