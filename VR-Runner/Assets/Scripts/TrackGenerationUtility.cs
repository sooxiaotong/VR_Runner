using UnityEngine;
using System;
using System.Collections;

public class TrackGenerationUtility : ScriptableObject{

    public static readonly int MAX_UNITS_BLOCK_PER_LANE = 8;

    static Array segmentType = Enum.GetValues(typeof(SegmentType));
    static Array patternType = Enum.GetValues(typeof(PatternType));
    static Array limitedPatternType = Enum.GetValues(typeof(LimitedPatternType));
    static Array ResourceItemType = Enum.GetValues(typeof(ResourceItemType));
    static System.Random rand = new System.Random();

    public static SegmentType randomizeSegmentType()
    {
        return (SegmentType)segmentType.GetValue(rand.Next(segmentType.Length));
    }

    public static PatternType randomizePatternType()
    {
        return (PatternType)patternType.GetValue(rand.Next(patternType.Length));
    }

    public static LimitedPatternType getLimitedPatternType()
    {
        return (LimitedPatternType)limitedPatternType.GetValue(rand.Next(limitedPatternType.Length));
    }

    public static ArrayList generateArrayListWithThreeEmptyArrayLists()
    {
        ArrayList trackSeq = new ArrayList(3);

        for(int i = 0; i < 3; i++)
        {
            trackSeq.Add(new ArrayList());
        }

        return trackSeq;
    }

    public static bool shouldPatternizeOrNot()
    {
        if (rand.Next(0, 2) == 1)
            return true;
        return false;
    }

    public static int randomNumber(int min, int max)
    {
        return rand.Next(min, max + 1);
    }
}
