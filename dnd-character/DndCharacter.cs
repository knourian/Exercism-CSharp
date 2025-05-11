using System.Security.Cryptography;

public class DndCharacter
{
    private DndCharacter(int strength, int dexterity, int constitution, int intelligence, int wisdom, int charisma, int hitpoints)
    {
        Strength = strength;
        Dexterity = dexterity;
        Constitution = constitution;
        Intelligence = intelligence;
        Wisdom = wisdom;
        Charisma = charisma;
        Hitpoints = hitpoints;
    }


    public int Strength { get; }
    public int Dexterity { get; }
    public int Constitution { get; }
    public int Intelligence { get; }
    public int Wisdom { get; }
    public int Charisma { get; }
    public int Hitpoints { get; }

    public static int Modifier(int score) => (int)Math.Floor((score - 10) / 2.0);

    public static int Ability()
    {
        var rolls = new int[4];
        for (var i = 0; i < 4; i++)
        {
            rolls[i] = GetDiceRoll();
        }

        Array.Sort(rolls);
        return rolls[1] + rolls[2] + rolls[3];
    }

    public static DndCharacter Generate()
    {
        var strength = Ability();
        var dexterity = Ability();
        var constitution = Ability();
        var intelligence = Ability();
        var wisdom = Ability();
        var charisma = Ability();
        var hitpoints = 10 + Modifier(constitution);
        return new DndCharacter(strength, dexterity, constitution, intelligence, wisdom, charisma, hitpoints);
    }

    private static int GetDiceRoll() => RandomNumberGenerator.GetInt32(1, 7);
}

