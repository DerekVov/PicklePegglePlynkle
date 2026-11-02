using UnityEngine;
using Unity.VisualScripting.FullSerializer;

public static class Scorekeeper
{
    private static int score = 0;

    
    // add points
    public static void Add(int amount)
    {
        score = score + amount;
        MonoBehaviour.print(score);
    }

    public static int GetScore()
    {
        return score;
    }

   
    public static void Reset()
    {
        score = 0;
    }
}
