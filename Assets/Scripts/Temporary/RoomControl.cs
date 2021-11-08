using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RoomControl : MonoBehaviour
{
    public GameObject ThePlayer;

	// Use this for initialization
	void Start ()
    {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
		if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            SceneManager.LoadScene("Died");
        }
        if (Input.GetKeyDown(KeyCode.Mouse1))
        {
            SceneManager.LoadScene("1");
            Destroy(ThePlayer);
        }
    }

}
