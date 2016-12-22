using UnityEngine;
using System.Collections;

public class FallSubject : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.GetComponent<PrefabType>().prefabType == "Player")
            GetComponent<MeshRenderer>().enabled = false;
    }
}
