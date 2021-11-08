using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrisonLockController : MonoBehaviour
{

    public GameObject OpenedDoor;


    public GameObject ClosedDoor;

    public bool DoorOpened = false;

    // Use this for initialization
    void Start ()
    {
        ClosedDoor.SetActive(true);
        OpenedDoor.SetActive(false);

    }
	
	// Update is called once per frame
	void Update ()
    {
		if (DoorOpened == true)
        {
            ClosedDoor.SetActive(false);
            OpenedDoor.SetActive(true);
        }
	}

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Bullet")
        {
            DoorOpened = true;   
        }
    }
}
