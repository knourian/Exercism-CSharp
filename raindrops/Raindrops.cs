using System.Text;

public static class Raindrops
{
    public static string Convert(int number)
    {
        var builder = new StringBuilder();
        if (number % 3 == 0)
        {
            builder.Append("Pling");
        }
        if (number % 5 == 0)
        {
            builder.Append("Plang");
        }
        if (number % 7 == 0)
        {
            builder.Append("Plong");
        }

        if (number % 3 != 0 && number % 5 != 0 && number % 7 != 0)
        {
            builder.Append(number);
        }

        return builder.ToString();
    }
}