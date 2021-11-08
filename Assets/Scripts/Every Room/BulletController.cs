using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletController : MonoBehaviour
{

    public GameObject BasementDoor;

    public int BulletSpeed;

	// Use this for initialization

    void Update()
    {
        transform.position = transform.position + transform.forward * BulletSpeed;
    }


    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "DoorToBaseMentLock")
        {
            BasementDoor.SetActive(false);
        }
    }
}
