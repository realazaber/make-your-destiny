using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RemoveBaddyIfGunExist : MonoBehaviour
{

    public GameObject Baddy;

    public GameObject Gun;

    public bool BaddyMustDie = false;


	// Use this for initialization
	void Start ()
    {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
		if (BaddyMustDie == true)
        {
            Destroy(Baddy);
        }
	}

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Baddy" && Gun.activeSelf == true)
        {
            Destroy(Baddy);
        }

    }
}
