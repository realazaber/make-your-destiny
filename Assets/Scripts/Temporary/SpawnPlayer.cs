using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPlayer : MonoBehaviour
{

    public GameObject Player;

    // Use this for initialization
    void Start ()
    {
        if(Player.activeSelf == false)
        {
            Player.SetActive(true);
        }
            

    }
	
	// Update is called once per frame
	void Update ()
    {
		
	}
}
