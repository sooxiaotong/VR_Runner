using UnityEngine;
using System.Collections;

public class SegmentAssembler : ScriptableObject {

    SegmentSequenceGenerator segmentSequenceGenerator = new SegmentSequenceGenerator();
    ResourcesFactory resourcesFactory;
    LaneAssembler laneAsembler;

    public SegmentAssembler(ref ResourcesFactory resourcesFactory)
    {
        this.resourcesFactory = resourcesFactory;
        laneAsembler = new LaneAssembler(ref resourcesFactory);
    }

    public GameObject generateSegment(SegmentType segmentType)
    {
        PatternType patternType = TrackGenerationUtility.randomizePatternType();

        GameObject segment = resourcesFactory.cloneSegmentHolder();

        segmentSequenceGenerator.generateTrack(segmentType);

        return segment;
    }
}
