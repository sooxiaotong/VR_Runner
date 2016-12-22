using UnityEngine;
using System.Collections;

public class ResourcesFactory : MonoBehaviour {

    //TrackManager implemented MilestoneObserver
    public TrackManager trackManager;

    //only one player and cameraholder can be there in the scene.
    public GameObject player;
    public GameObject cameraHolder;

    //For initation of MilestoneSubject
    private MilestoneObserver milestoneObserver;

    private GameObject shortTrack;
    private GameObject mediumTrack;
    private GameObject longTrack;
    private GameObject coin;
    private GameObject crackedFloor;
    private GameObject milestoneSubject;
    private GameObject fallSubject;
    private GameObject segmentHolder;
    private GameObject laneHolder;

    // Use this for initialization
    void Start () {

        milestoneObserver = trackManager as MilestoneObserver;

        shortTrack = Instantiate(Resources.Load("TrackBuildingBlocks/Short_Track")) as GameObject;
        mediumTrack = Instantiate(Resources.Load("TrackBuildingBlocks/Medium_Track")) as GameObject;
        longTrack = Instantiate(Resources.Load("TrackBuildingBlocks/Long_Track")) as GameObject;
        coin = Instantiate(Resources.Load("TrackBuildingBlocks/Coin")) as GameObject;
        crackedFloor = Instantiate(Resources.Load("TrackBuildingBlocks/Cracked_Floor")) as GameObject;
        milestoneSubject = Instantiate(Resources.Load("TrackBuildingBlocks/MilestoneSubject")) as GameObject;
        fallSubject = Instantiate(Resources.Load("TrackBuildingBlocks/FallSubject")) as GameObject;
        segmentHolder = Instantiate(Resources.Load("TrackBuildingBlocks/SegmentHolder")) as GameObject;
        laneHolder = Instantiate(Resources.Load("TrackBuildingBlocks/LaneHolder")) as GameObject;

        //player = Instantiate(Resources.Load("TrackBuildingBlocks/PlayerHolder")) as GameObject;
        //cameraHolder = Instantiate(Resources.Load("TrackBuildingBlocks/CameraHolder")) as GameObject;

        shortTrack.SetActive(false);
        mediumTrack.SetActive(false);
        longTrack.SetActive(false);
        coin.SetActive(false);
        crackedFloor.SetActive(false);
        milestoneSubject.SetActive(false);
        fallSubject.SetActive(false);
        segmentHolder.SetActive(false);
        laneHolder.SetActive(false);
        //player.SetActive(false);
        //cameraHolder.SetActive(false);
    }
	
	// Update is called once per frame
	void Update () {
	    
	}

    public GameObject cloneShortTrack()
    {
        return Instantiate(shortTrack);
    }

    public GameObject cloneMediumTrack()
    {
        return Instantiate(mediumTrack);
    }

    public GameObject cloneLongTrack()
    {
        return Instantiate(longTrack);
    }

    public GameObject cloneCoin()
    {
        return Instantiate(coin);
    }

    public GameObject cloneCrackedFloor()
    {
        return Instantiate(crackedFloor);
    }

    public GameObject cloneMilestoneSubject()
    {
        GameObject clonedMilestoneSubject =  Instantiate(milestoneSubject);
        clonedMilestoneSubject.GetComponent<MilestoneSubject>().addObserver(ref milestoneObserver);
        return clonedMilestoneSubject;
    }

    public GameObject cloneFallSubject()
    {
        return Instantiate(fallSubject);
    }

    public GameObject cloneLaneHolder()
    {
        return Instantiate(laneHolder);
    }

    public GameObject cloneSegmentHolder()
    {
        return Instantiate(segmentHolder);
    }

    public GameObject getPlayer()
    {
        return player;
    }

    public GameObject getCamera()
    {
        return cameraHolder;
    }
}
