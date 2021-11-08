using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewHelicopterController : MonoBehaviour
{
    public bool HasSavedKids = false;

    public bool HasGudPotion = false;

    public bool DoesNotHaveGudPotion = true;

    public bool HasGoneInNewPositon = false;

    public bool HasWalkieTalkie = false;

    public bool HelicopterMoveAway = false;

    public float HeliSpeed = 0.5f;

    public AudioClip GoodSound;

    public AudioClip BadSound;

    private AudioSource source;

    public GameObject Baddies;

    public GameObject PositionOnGround;

    public GameObject TextBox;

    // Use this for initialization
    void Start ()
    {
        Baddies.SetActive(true);
        TextBox.SetActive(false);

        source = GetComponent<AudioSource>();
    }
	
	// Update is called once per frame
	void Update ()
    {
        if (HasWalkieTalkie == true)
        {
            if (HasSavedKids == true && Input.GetKeyDown(KeyCode.E))
            {
                transform.position = PositionOnGround.transform.position;
                HasGoneInNewPositon = true;
                if (HasGudPotion == false)
                {
                    AudioSource.PlayClipAtPoint(BadSound, transform.position);
                    //PLAY BAD SOUND HERE
                    Baddies.SetActive(true);
                    HelicopterMoveAway = true;
                }

                if (HasGudPotion == true)
                {
                    AudioSource.PlayClipAtPoint(GoodSound, transform.position);
                    //PLAY GUD SOUND HERE
                    TextBox.SetActive(true);
                }
            }
           if (HelicopterMoveAway == true)//LEAVING WITHOUT THE PLAYER
            {
                transform.position = transform.position + transform.up * HeliSpeed;
                transform.position = transform.position + transform.forward * HeliSpeed;
                source.Play();
            }

        }
	}

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "SavedKids")
        {
            HasSavedKids = true;
        }

        if (other.gameObject.tag == "CanGoOnHeli")
        {
            HasGudPotion = true;
        }

        if (other.gameObject.tag == "Walkietalkie")
        {
            HasWalkieTalkie = true;
        }




    }
}
