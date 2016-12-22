using UnityEngine;
using System.Collections;

public class MilestoneSubject : MonoBehaviour {

    private MilestoneObserver[] milestoneObserver;
    private const int observerSize = 1;

	// Use this for initialization
	void Start () {
        milestoneObserver = new MilestoneObserver[observerSize];
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.GetComponent<PrefabType>().prefabType == "Player")
            noticeObserver();
    }

    void noticeObserver()
    {
        for(int i = 0; i < observerSize; i++)
        {
            milestoneObserver[i].noticeMilestone();
        }
    }

    public void addObserver(ref MilestoneObserver milestoneObserver)
    {
        this.milestoneObserver[0] = milestoneObserver;
    }
}
