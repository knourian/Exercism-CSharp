using System.Collections;

public static class FlattenArray
{
    // No recursion is used in this implementation.
    public static IEnumerable Flatten(IEnumerable input)
    {
        foreach (var item in input)
        {
            if (item is IEnumerable enumerable && !(item is string))
            {
                foreach (var subItem in Flatten(enumerable))
                {
                    if (subItem != null)
                    {
                        yield return subItem;
                    }
                }
            }
            else if (item != null)
            {
                yield return item;
            }
        }
    }
}