public static class FoodChain
{
    private const string Song = """
    I know an old lady who swallowed a fly.
    I don't know why she swallowed the fly. Perhaps she'll die.

    I know an old lady who swallowed a spider.
    It wriggled and jiggled and tickled inside her.
    She swallowed the spider to catch the fly.
    I don't know why she swallowed the fly. Perhaps she'll die.

    I know an old lady who swallowed a bird.
    How absurd to swallow a bird!
    She swallowed the bird to catch the spider that wriggled and jiggled and tickled inside her.
    She swallowed the spider to catch the fly.
    I don't know why she swallowed the fly. Perhaps she'll die.

    I know an old lady who swallowed a cat.
    Imagine that, to swallow a cat!
    She swallowed the cat to catch the bird.
    She swallowed the bird to catch the spider that wriggled and jiggled and tickled inside her.
    She swallowed the spider to catch the fly.
    I don't know why she swallowed the fly. Perhaps she'll die.

    I know an old lady who swallowed a dog.
    What a hog, to swallow a dog!
    She swallowed the dog to catch the cat.
    She swallowed the cat to catch the bird.
    She swallowed the bird to catch the spider that wriggled and jiggled and tickled inside her.
    She swallowed the spider to catch the fly.
    I don't know why she swallowed the fly. Perhaps she'll die.

    I know an old lady who swallowed a goat.
    Just opened her throat and swallowed a goat!
    She swallowed the goat to catch the dog.
    She swallowed the dog to catch the cat.
    She swallowed the cat to catch the bird.
    She swallowed the bird to catch the spider that wriggled and jiggled and tickled inside her.
    She swallowed the spider to catch the fly.
    I don't know why she swallowed the fly. Perhaps she'll die.

    I know an old lady who swallowed a cow.
    I don't know how she swallowed a cow!
    She swallowed the cow to catch the goat.
    She swallowed the goat to catch the dog.
    She swallowed the dog to catch the cat.
    She swallowed the cat to catch the bird.
    She swallowed the bird to catch the spider that wriggled and jiggled and tickled inside her.
    She swallowed the spider to catch the fly.
    I don't know why she swallowed the fly. Perhaps she'll die.

    I know an old lady who swallowed a horse.
    She's dead, of course!
    """;
    public static string Recite(int verseNumber)
    {
        return Song.Split(["\n\n"], StringSplitOptions.RemoveEmptyEntries)[verseNumber - 1].Trim();
    }

    public static string Recite(int startVerse, int endVerse)
    {
        return string.Join("\n\n", Song.Split(["\n\n"], StringSplitOptions.RemoveEmptyEntries)
            .Skip(startVerse - 1)
            .Take(endVerse - startVerse + 1)
            .Select(verse => verse.Trim()));
    }
}