using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DoorController : MonoBehaviour
{
    public GameObject Lock;

    public bool CanGoInBasement = false;

    public GameObject Baddy;

    // Use this for initialization
    void Start ()
    {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        if (Lock == null)
        {
            CanGoInBasement = true;
            Baddy = null;
        }


            	
	}

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player" && CanGoInBasement == true)
        {
            SceneManager.LoadScene("3");
        }
    }
}
