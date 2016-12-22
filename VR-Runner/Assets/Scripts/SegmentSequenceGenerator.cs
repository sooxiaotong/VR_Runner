using UnityEngine;
using System;
using System.Collections;

public class SegmentSequenceGenerator : ScriptableObject {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public ArrayList generateTrack(SegmentType segmentType)
    {
        switch(segmentType)
        {
            case SegmentType.HolelessTrack:
                return generateHoleslessTrackSequence();
            case SegmentType.TrackWithMinimalAmountOfHoles:
                return generateTrackWithMinimalHoles();
            case SegmentType.TrackWithMediumAmountOfHoles:
                return generateTrackWithMediumAmountOfHoles();
            case SegmentType.TrackWithMostAmountOfHoles:
                return generateTrackWithMostHoles();
        }

        return generateHoleslessTrackSequence();
    }

    ArrayList generateHoleslessTrackSequence()
    {
        ArrayList trackSeq = TrackGenerationUtility.generateArrayListWithThreeEmptyArrayLists();

        foreach(ArrayList al in trackSeq)
        {
            for (int i = 0; i < 2; i++)
                al.Add(ResourceItemType.LONG_TRACK);
        }

        return trackSeq;
    }

    ArrayList generateTrackWithMinimalHoles()
    {
        ArrayList trackSeq = TrackGenerationUtility.generateArrayListWithThreeEmptyArrayLists();

        //patterned means the track will have one straigh line of holes horizontally or 1 holes vertically
        if(TrackGenerationUtility.shouldPatternizeOrNot())
        {
            switch(TrackGenerationUtility.getLimitedPatternType())
            {
                case LimitedPatternType.HORIZONTALLINE:
                    int firstRow = TrackGenerationUtility.randomNumber(0, 4);
                    int[] rowsOfHole = new int[2] {firstRow , TrackGenerationUtility.randomNumber(firstRow + 2, 8) };
                    PatternUtility.horizontalLinePatternizer(ref trackSeq, rowsOfHole, TrackGenerationUtility.MAX_UNITS_BLOCK_PER_LANE, ResourceItemType.HOLE, true);
                    break;
                case LimitedPatternType.ZIGZAG_LEFT:

                    break;
            }
        }
        else
        {

        }

        return trackSeq;
    }

    ArrayList generateTrackWithMediumAmountOfHoles()
    {
        ArrayList trackSeq = TrackGenerationUtility.generateArrayListWithThreeEmptyArrayLists();

        return trackSeq;
    }

    ArrayList generateTrackWithMostHoles()
    {
        ArrayList trackSeq = TrackGenerationUtility.generateArrayListWithThreeEmptyArrayLists();

        return trackSeq;
    }
}
