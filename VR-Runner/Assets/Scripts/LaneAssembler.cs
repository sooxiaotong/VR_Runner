using UnityEngine;
using System.Collections;

public class LaneAssembler : ScriptableObject
{
    GameObject[] laneComponents = new GameObject[8];
    ResourcesFactory resourcesFactory;

    public LaneAssembler(ref ResourcesFactory resourcesFactory)
    {
        this.resourcesFactory = resourcesFactory;
    }

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    GameObject generateLane()
    {
        return resourcesFactory.cloneLaneHolder();
    }


}
