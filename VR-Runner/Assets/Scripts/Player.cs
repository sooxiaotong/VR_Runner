using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {

    public GameObject cameraHolder;

    private Rigidbody rigidBody;
    private bool jumpOnce = false;

	// Use this for initialization
	void Start () {
        rigidBody = GetComponent<Rigidbody>();
    }
	
	// Update is called once per frame
	void Update () {
        //camera.transform.position = Vector3.forward * camera.transform.position.z + 0.1f;
        this.transform.Translate(Vector3.forward / 10f);
        cameraHolder.transform.Translate(new Vector3(0f, 0f, 0.1f));

        if (Input.GetKey(KeyCode.A))
        {
            this.transform.Translate(new Vector3(-0.1f, 0f, 0f));
            cameraHolder.transform.Translate(new Vector3(-0.1f, 0f, 0f));
        }

        if (Input.GetKey(KeyCode.D))
        {
            this.transform.Translate(new Vector3(0.1f, 0f, 0f));
            cameraHolder.transform.Translate(new Vector3(0.1f, 0f, 0f));
        }

        if (Input.GetKey(KeyCode.W))
        {
            this.transform.Translate(new Vector3(0f, 0f, 0.1f));
            cameraHolder.transform.Translate(new Vector3(0f, 0f, 0.1f));
        }

        if (Input.GetKey(KeyCode.S))
        {
            this.transform.Translate(new Vector3(0f, 0f, -0.1f));
            cameraHolder.transform.Translate(new Vector3(0f, 0f, -0.1f));
        }

        if(Input.GetKeyDown(KeyCode.Space))
        {
            //this.transform.Translate(new Vector3(0f, 2f, 0f));
            //this.transform.Translate(Vector3.up * 200f * Time.deltaTime);
            if(!jumpOnce)
            {
                rigidBody.AddForce(Vector3.up * 500f);
                jumpOnce = true;
            }
        }
    }



    void OnCollisionEnter(Collision collision)
    {
        foreach (ContactPoint contact in collision.contacts)
        {
            //find name of prefab
            //PrefabUtility.GetPrefabParent(contact.otherCollider.gameObject).name;
            //Debug.Log(contact.thisCollider.name + " hit " + UnityEditor.PrefabUtility.FindPrefabRoot(contact.otherCollider.gameObject).name);
            //Debug.DrawRay(contact.point, contact.normal, Color.white);
            string prefabName = contact.otherCollider.gameObject.GetComponent<PrefabType>().prefabType;
            if (prefabName == "Long_Track" || prefabName == "Medium_Track" || prefabName == "Short_Track")
            {
                jumpOnce = false;
            }
        }
    }


}
