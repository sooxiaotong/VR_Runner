using UnityEngine;
using System.Collections;

public class PatternUtility{

    public static void horizontalLinePatternizer(ref ArrayList arrayList, int[] rowNumber, int maxNumber, ResourceItemType itemType, bool isTrack)
    {
        if (isTrack)
        {
            foreach (int row in rowNumber)
            {
                horizontalLineTrackAndItemInserter(ref arrayList, row, itemType);
            }

            if (rowNumber[rowNumber.Length - 1] < maxNumber - 1)
            {
                horizontalLineTrackAndItemInserter(ref arrayList, rowNumber[rowNumber.Length - 1], itemType);
            }
        }
        else
        {
            foreach(int row in rowNumber)
            {
                foreach(ArrayList al in arrayList)
                {
                    if(al.Count < maxNumber)
                    {
                        for (int i = al.Count; i < maxNumber; i++)
                            al.Add(ResourceItemType.NONE);
                    }

                    al[row] = itemType;
                }
            }
        }
    }

    static void horizontalLineTrackAndItemInserter(ref ArrayList arrayList, int row, ResourceItemType itemType)
    {
        int mediumTrackNum = row / 2;
        int shortTrackNum = row % 2;

        foreach (ArrayList al in arrayList)
        {
            for (int i = 0; i < mediumTrackNum; i++)
                al.Add(ResourceItemType.MEDIUM_TRACK);
            for (int i = 0; i < shortTrackNum; i++)
                al.Add(ResourceItemType.SHORT_TRACK);

            al.Add(itemType);
        }
    }
}
