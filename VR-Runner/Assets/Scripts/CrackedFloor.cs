using UnityEngine;
using System.Collections;

public class CrackedFloor : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnCollisionEnter(Collision collision)
    {
        foreach (ContactPoint contact in collision.contacts)
        {
            if(contact.otherCollider.gameObject.GetComponent<PrefabType>().prefabType == "Player")
            {
                Rigidbody rigidBody = GetComponent<Rigidbody>();
                rigidBody.isKinematic = false;
                rigidBody.useGravity = true;
            }
        }
    }
}
