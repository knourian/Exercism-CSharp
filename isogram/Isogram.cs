public static class Isogram
{
    public static bool IsIsogram(string word)
    {
        var map = new Dictionary<char, int>();
        foreach (var c in word.ToLower())
        {
            if (Char.IsWhiteSpace(c))
                continue;
            if (c == '-')
                continue;
            map[c] = map.TryGetValue(c, out int oldValue) ? oldValue + 1 : 1;
        }
        var resutl = map.Count == 0 || map.Values.Max() <= 1;

        return resutl;
    }
}
