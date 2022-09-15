using System;

public abstract class SeedUtility
{
    public static String GenerateRandomSeed()
    {
        return UnityEngine.Random.Range(0, int.MaxValue).ToString();
    }

    public static void SetSeed(string seed)
    {
        int seedInt;

        // check if the seed made with numbers
        if (int.TryParse(seed, out int result))
            seedInt = result;
        else
            seedInt = seed.GetHashCode();

        UnityEngine.Random.InitState(seedInt);
    }

    public static UnityEngine.Random.State GetRandomState()
    {
        return UnityEngine.Random.state;
    }

    public static void SetRandomState(UnityEngine.Random.State state)
    {
        UnityEngine.Random.state = state;
    }
}