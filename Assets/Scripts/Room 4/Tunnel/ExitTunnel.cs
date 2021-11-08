using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExitTunnel : MonoBehaviour
{
    public GameObject OpenedDoor;

    public GameObject PlayerKiller;

    public bool KidsFree = false;

    
	// Use this for initialization
	void Start ()
    {
        OpenedDoor.SetActive(false);

    }
	
	// Update is called once per frame
	void Update ()
    {
		
	}

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player" && OpenedDoor.activeSelf == false)
        {
            KillPlayer();
        }
    }

    void KillPlayer()
    {
        PlayerKiller.SetActive(true);
    }
}
