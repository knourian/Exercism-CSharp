public class Anagram
{
    private string _baseWord;
    public Anagram(string baseWord)
    {
        _baseWord = baseWord;
    }

    public string[] FindAnagrams(string[] potentialMatches)
    {
        var sortedBaseWord = string.Concat(_baseWord.ToLower().OrderBy(x => x));
        return potentialMatches
            .Where(candidate =>
                !_baseWord.Equals(candidate, StringComparison.OrdinalIgnoreCase) &&
                candidate.Length == _baseWord.Length &&
                string.Concat(candidate.ToLower().OrderBy(x => x)) == sortedBaseWord)
            .ToArray();
    }
}