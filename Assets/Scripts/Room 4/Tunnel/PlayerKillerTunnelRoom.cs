using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerKillerTunnelRoom : MonoBehaviour
{

    private AudioSource source;

    //public GameObject ClosedDoor;

	// Use this for initialization
	void Start ()
    {
        source = GetComponent<AudioSource>();

    }
	
	// Update is called once per frame
	void Update () {
		
	}



    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player" )
        {
            Destroy(GameObject.FindGameObjectWithTag("Player"));
            SceneManager.LoadScene("MainMenu");
        }
    }
}
