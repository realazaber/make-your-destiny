using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PotionController : MonoBehaviour
{
    public GameObject PlayerEnterBrewingStand;

    public GameObject DrinkAmazeText;

    public GameObject Potion_Left;

    public GameObject Potion_Left_Empty;

    public GameObject Potion_Right;

    public GameObject Potion_Right_Empty;

    //public GameObject DeathWall;

    public GameObject Potion_Amaze;

    public GameObject Empty_Potion_Amaze;

    public AudioClip NothingHappens;

    public AudioClip YouDie;

    public AudioClip IntendedGoal;


    public bool CanBrew = false;

    public bool StandUsed = false;

    public bool DrankGoodPotion = false;

    public bool DrankAmazePotion = false;
	// Use this for initialization
	void Start ()
    {
        PlayerEnterBrewingStand.SetActive(false);
        Potion_Amaze.SetActive(false);
        DrinkAmazeText.SetActive(false);
        //DeathWall.SetActive(false);

    }
	
	// Update is called once per frame
	void Update ()
    {
		if (CanBrew == true && StandUsed == false && DrankAmazePotion == false)
        {
            if (Input.GetKeyDown(KeyCode.Alpha1))
            {
                PlayerEnterBrewingStand.SetActive(false);
                AudioSource.PlayClipAtPoint(NothingHappens, transform.position);
                StandUsed = true;
                Potion_Left.SetActive(false);
                Potion_Left_Empty.SetActive(true);
            }
            if (Input.GetKeyDown(KeyCode.Alpha2))
            {
                PlayerEnterBrewingStand.SetActive(false);
                AudioSource.PlayClipAtPoint(YouDie, transform.position);
                StandUsed = true;
                Potion_Right.SetActive(false);
                Potion_Right_Empty.SetActive(true);
                //DeathWall.SetActive(true);
            }
            if (Input.GetKeyDown(KeyCode.Alpha3))
            {
                DrankGoodPotion = true;
                PlayerEnterBrewingStand.SetActive(false);
                AudioSource.PlayClipAtPoint(IntendedGoal, transform.position);
                StandUsed = false;
                Potion_Left.SetActive(false);
                Potion_Right.SetActive(false);
                Potion_Amaze.SetActive(true);
                DrinkAmazeText.SetActive(true);
            }
            if (Input.GetKeyDown(KeyCode.Alpha3))
            {
                //DrankGoodPotion = true;
                
                PlayerEnterBrewingStand.SetActive(false);
                AudioSource.PlayClipAtPoint(IntendedGoal, transform.position);
                //StandUsed = true;
                Potion_Left.SetActive(false);
                Potion_Right.SetActive(false);
                Potion_Amaze.SetActive(true);
                DrinkAmazeText.SetActive(true);                
                
                Debug.Log("DRANK GUD SHITE");
            }

            if (Potion_Amaze.activeSelf == true && Input.GetKeyDown(KeyCode.Alpha4))
            {
                Debug.Log("DRIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIINK");
                DrankGoodPotion = true;
                PlayerEnterBrewingStand.SetActive(false);
                AudioSource.PlayClipAtPoint(IntendedGoal, transform.position);
                StandUsed = true;
                Potion_Left.SetActive(false);
                Potion_Right.SetActive(false);
                Potion_Amaze.SetActive(false);
                Empty_Potion_Amaze.SetActive(true);
                DrinkAmazeText.SetActive(false);
                DrankAmazePotion = true;
            } 
        }
	}

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player" && StandUsed == false)
        {
            PlayerEnterBrewingStand.SetActive(true);
            CanBrew = true;
        }
        if (other.gameObject.tag == "Player" && DrankGoodPotion == true)
        {
            DrinkAmazeText.SetActive(true);
            PlayerEnterBrewingStand.SetActive(false);
            CanBrew = true;
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            PlayerEnterBrewingStand.SetActive(false);
            DrinkAmazeText.SetActive(false);
            CanBrew = false;
        }
    }
}
