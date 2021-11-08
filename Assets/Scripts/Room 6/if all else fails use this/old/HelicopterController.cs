using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelicopterController : MonoBehaviour 
{

	public bool CanCallHeli = false;

	public bool CanNotGoDown = false;

    public bool TookGoodPotion = false;

	public bool CantTakePlayer = false;

	public bool HasGoneInDestination = false;

    public bool HeliHasLeft = false;

	public float HeliSpeed = 0.15f;

	public AudioClip GoingWithPlayer;

	public bool GoodSoundPlayed = false;

	public float HeliSpeedWithoutPlayer = 0.075f;

	public AudioClip GoingWithoutPlayer;

	public bool BadSoundPlayed = false;

	public GameObject HeliNewPosition;

	public GameObject Camera;

	public GameObject Baddies;

	public GameObject PlayerOnHelicopterDetector;
	

	void Start()
	{
		PlayerOnHelicopterDetector.SetActive(false);
		Baddies.SetActive(true);
		//CantTakePlayer = true;
	}
	// Update is called once per frame
	void Update () 
	{
		

		if (PlayerOnHelicopterDetector.activeSelf == true)
		{
			Baddies.SetActive(false);
		}

		if (CanCallHeli == false)
		{
			//Baddies.SetActive(true);
			CantTakePlayer = true;
		}

		if (CanCallHeli == true && CanNotGoDown == false && TookGoodPotion == false && Input.GetKeyDown(KeyCode.E))
        {
            transform.position = HeliNewPosition.transform.position;
			HasGoneInDestination = true;
            Baddies.SetActive(true);
            if (CantTakePlayer == true && HeliHasLeft == false)
			{
                HeliHasLeft = true;
                //transform.position = transform.position + transform.up * HeliSpeedWithoutPlayer;	
				//transform.position = transform.position + transform.forward * HeliSpeedWithoutPlayer;
			}
        }	

		if (Camera.activeSelf == true && TookGoodPotion == true || CantTakePlayer == false && TookGoodPotion == true) //Taking player
		{
			transform.position = transform.position + transform.up * HeliSpeed;	
			transform.position = transform.position + transform.forward * HeliSpeed;
			GoodSoundPlayed = true;
			Baddies.SetActive(false);
			if (GoodSoundPlayed == false)
			{
				AudioSource.PlayClipAtPoint(GoingWithPlayer, transform.position); 
			}
		}

		if (CanCallHeli == true && CanNotGoDown == false && CantTakePlayer == true && HasGoneInDestination == true) //Ditching player
		{
 			//transform.position = transform.position + transform.up * HeliSpeedWithoutPlayer;	
			//transform.position = transform.position + transform.forward * HeliSpeedWithoutPlayer;
			Baddies.SetActive(true);
			BadSoundPlayed = true;
			if (BadSoundPlayed == false)
			{
				AudioSource.PlayClipAtPoint(GoingWithoutPlayer, transform.position);
			}
		}
	}

	void OnTriggerEnter(Collider other)
    {
		if (other.gameObject.tag == "Walkietalkie")
		{
			CanCallHeli = true;
		}

        if (other.gameObject.tag == "CanGoHeli") //when u get good potion
        {
            PlayerOnHelicopterDetector.SetActive(true);
            CantTakePlayer = false;
            TookGoodPotion = true;
        }

        if (other.gameObject.tag == "CanGoOnHelicopter") //save kids
		{
			CantTakePlayer = true;
		}
		
    }
}