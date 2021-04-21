using System;

public class DndCharacter
{
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
        if (result < 0)
        {
            return (int)Math.Round(result, MidpointRounding.AwayFromZero);
        }
        else
        {
            return (int)Math.Round(result, MidpointRounding.ToZero);
        }            
    }

    public static int Ability() 
    {
        throw new NotImplementedException("You need to implement this function.");
    }

    public static DndCharacter Generate()
    {
        throw new NotImplementedException("You need to implement this function.");
    }
}
