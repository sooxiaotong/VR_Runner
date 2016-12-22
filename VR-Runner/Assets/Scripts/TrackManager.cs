using UnityEngine;
using System.Collections;

public class TrackManager : MonoBehaviour, MilestoneObserver {

    //remove becoz can refer to a component in editor instead.
    //ResourcesFactory resourcesFactory;

    public ResourcesFactory resourcesFactory;
    SegmentAssembler segmentAssembler;

    System.Random rand = new System.Random();
    Queue segmentHolderQueue;
    Queue segmentType;

	// Use this for initialization
	void Start () {
        //remove becoz can refer to a component in editor instead.
        //resourcesFactory = GetComponent<ResourcesFactory>();

        segmentAssembler = new SegmentAssembler(ref resourcesFactory);
	}
	
	// Update is called once per frame
	void Update () {

    }

    void generateTrack()
    {
        segmentHolderQueue.Dequeue();
        segmentType.Dequeue();

        SegmentType nextSegmentType = TrackGenerationUtility.randomizeSegmentType();

        segmentType.Enqueue(nextSegmentType);

        segmentHolderQueue.Enqueue(segmentAssembler.generateSegment(nextSegmentType));
    }

    public void beginGame()
    {

    }

    public void reset()
    {
        segmentHolderQueue.Clear();
    }

    public void noticeMilestone()
    {
        generateTrack();
    }

}
