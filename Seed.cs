using System;

public class Seed
{
    public Seed(string seed)
    {
        _seed = seed;
        interruptAction(() =>
        {
        // init seed and convert to random state
            SeedUtility.SetSeed(_seed);
            _seedRandomState = UnityEngine.Random.state;
        });
    }

    private string _seed;
    private UnityEngine.Random.State _seedRandomState;

    public string GetSeed() => _seed;

    /// <summary>
    /// 
    /// </summary>
    /// <param name="minInclusive"></param>
    /// <param name="maxExclusive"></param>
    /// <returns>Returns a random integer within [minInclusive..maxInclusive] (range is inclusive).</returns>
    public int RandomNumber(int minInclusive, int maxExclusive)
    {
        int randomNum = 0;
        interruptAction(() =>
        {
            randomNum = UnityEngine.Random.Range(minInclusive, maxExclusive);
        });
        return randomNum;
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="minInclusive"></param>
    /// <param name="maxExclusive"></param>
    /// <returns>Returns a random float within [minInclusive..maxInclusive] (range is inclusive).</returns>
    public float RandomNumber(float minInclusive, float maxExclusive)
    {
        float randomNum = 0;
        interruptAction(() =>
        {
            randomNum = UnityEngine.Random.Range(minInclusive, maxExclusive);
        });
        return randomNum;
    }

    /// <summary>
    /// Interrupt the current random state and run action with another seed random state.
    /// After the interruption random state will be restored.
    /// </summary>
    /// <param name="action"></param>
    private void interruptAction(Action action)
    {
        // backup current random state
        UnityEngine.Random.State randomState_Backup = SeedUtility.GetRandomState();

        // restore seed random state
        SeedUtility.SetRandomState(_seedRandomState);
        // run action
        action();
        // record seed random state
        _seedRandomState = SeedUtility.GetRandomState();

        // restore backup
        SeedUtility.SetRandomState(randomState_Backup);
    }
}