using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReviveBaddy : MonoBehaviour
{

    public GameObject Baddy;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        if (GameObject.FindGameObjectsWithTag("Gun") == null)
        {
            if (Baddy.activeSelf == false)
            {
                Baddy.SetActive(true);
            }
        }
    }
}
