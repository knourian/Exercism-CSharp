using System.Text;

public static class Acronym
{
    public static string Abbreviate(string phrase)
    {
        var words = phrase.Split([' ', '-', '_'], StringSplitOptions.RemoveEmptyEntries);
        return string.Join("", words.Select(x => x.ToUpper().First()).ToArray());
    }
}