using System;
using System.Collections.Generic;
using System.Linq;

public class DndCharacter
{
    public DndCharacter()
    {
        Strength = Ability();
        Dexterity = Ability();
        Constitution = Ability();
        Intelligence = Ability();
        Wisdom = Ability();
        Charisma = Ability();
        Hitpoints = Modifier(Constitution) + 10;
    }
    public int Strength { get; }
    public int Dexterity { get; }
    public int Constitution { get; }
    public int Intelligence { get; }
    public int Wisdom { get; }
    public int Charisma { get; }
    public int Hitpoints { get; }

    public static int Modifier(int score)
    {
        float result = ((float)score - 10) / 2;
        return result < 0 ? (int)Math.Round(result, MidpointRounding.AwayFromZero) : (int)Math.Round(result, MidpointRounding.ToZero);
    }

    public static int Ability()
    {
        var diceRollResults = new List<int>();
        var random = new Random();
        for (int i = 0; i < 4; i++)
        {
            int diceRoll = random.Next(1, 7);
            diceRollResults.Add(diceRoll);
        }
        return diceRollResults.Sum() - diceRollResults.Min();
    }

    public static DndCharacter Generate()
    {
        return new DndCharacter();
    }
}
