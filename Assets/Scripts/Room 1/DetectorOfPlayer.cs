using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DetectorOfPlayer : MonoBehaviour
{
    public GameObject Text;

    public GameObject Result;

    public GameObject GetItem;

    public GameObject HandGunInPlayer;

    public AudioClip ClickedOnce;

    public bool InTrigger = false;

    public bool IsOpen = false;

    // Use this for initialization
    void Start ()
    {
        Text.SetActive(false);
        Result.SetActive(false);
    }
	
	// Update is called once per frame
	void Update ()
    {

        if (HandGunInPlayer == null)
        {
            HandGunInPlayer = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerShoot>().Player_Gun;
        }
        

        if (InTrigger == true && Input.GetKeyDown(KeyCode.Mouse0))
        {
            Result.SetActive(true);

            GetItem.SetActive(true);

            IsOpen = true;

        }

        if (InTrigger == true && IsOpen == true)
        {
            GetItem.SetActive(true);
            Text.SetActive(false);

        }

        if (Result.activeSelf && Input.GetKeyDown(KeyCode.Mouse0))
        {
            HandGunInPlayer.SetActive(true);
        }





        if (InTrigger == false)
            {
                Result.SetActive(false);

                IsOpen = false;
        }
	}

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player" && !HandGunInPlayer.activeSelf)
        {
            Text.SetActive(true);
            InTrigger = true;

        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            Text.SetActive(false);
            InTrigger = false;
            GetItem.SetActive(false);
        }
    }
}
