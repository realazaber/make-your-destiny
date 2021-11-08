using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EyesContoller : MonoBehaviour
{

    public GameObject EyesInDistance;

    public GameObject DoorLock;

    public bool DoorLockActive = true;

    

	// Use this for initialization
	void Start ()
    {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        if (DoorLock == null)
        {
            DoorLockActive = true;
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (DoorLockActive == false)
        {
            Destroy(EyesInDistance);
        }

        //if (other.gameObject.tag == "Bullet")
        //{
         //   Destroy(EyesInDistance);
        //}
    }
    
}
