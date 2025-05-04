public static class RotationalCipher
{
    private const string Chars = "abcdefghijklmnopqrstuvwxyz";
    public static string Rotate(string text, int shiftKey)
    {
        var key = ShiftString(Chars, shiftKey % Chars.Length);
        var result = new char[text.Length];
        for (var i = 0; i < text.Length; i++)
        {
            var c = text[i];
            if (!Chars.Contains(char.ToLower(c)))
            {
                result[i] = c;
                continue;
            }
            var isLower = char.IsLower(c);
            var index = Chars.IndexOf(Char.ToLower(c), StringComparison.OrdinalIgnoreCase);
            result[i] = isLower ? key[index] : char.ToUpper(key[index]);
        }
        return new string(result);
    }
    private static string ShiftString(string t, int i) => i == 0 ? t : string.Concat(t.AsSpan(i), t.AsSpan(0, i));
}