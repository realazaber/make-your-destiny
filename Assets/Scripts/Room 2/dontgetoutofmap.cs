using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dontgetoutofmap : MonoBehaviour
{
    public GameObject Spawn;

    public GameObject Player;

	// Use this for initialization
	void Start () {
		
	}

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            other.gameObject.transform.position = Spawn.transform.position;
        }
    }
}
