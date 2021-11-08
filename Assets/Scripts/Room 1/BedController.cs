using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BedController : MonoBehaviour
{

    public GameObject BedText;

    public GameObject Player;
    //public GameObject InBed;
    public GameObject CameraInBed;
    public GameObject PlayerCamera;
    public GameObject InBedText;
    public bool InBed = false;
    public GameObject GetInBedText;

    // Use this for initialization
    void Start ()
    {
        BedText.SetActive(false);
        CameraInBed.SetActive(false);
        InBedText.SetActive(false);
    }
	
	// Update is called once per frame
	void Update ()
    {
        if(PlayerCamera == null)
            PlayerCamera = Camera.main.gameObject;
        
        
        if ((BedText.activeSelf && Input.GetKeyDown(KeyCode.Mouse0)))
        {
            //set the players transfrom to the InBedTransform;
            //Player.transform.position = InBed.transform.position;
            //Player.transform.rotation = InBed.transform.rotation;
            //Player.GetComponent<Rigidbody>().isKinematic = true;


            //getting into bed
            PlayerCamera.SetActive(false);
            CameraInBed.SetActive(true);
            InBedText.SetActive(true);
            BedText.SetActive(true);
            GetInBedText.SetActive(false);
            InBed = true; 
        }

        //if (BedText.activeSelf && Input.GetKeyDown(KeyCode.Mouse1))
        //{
            //SceneManager.LoadScene("Died");
          //  InBed = false;
        //}

        if (InBedText.activeSelf && Input.GetKeyDown(KeyCode.Mouse2))
        {
            CameraInBed.SetActive(false);
            PlayerCamera.SetActive(true);
            BedText.SetActive(false);
            GetInBedText.SetActive(false);
            InBedText.SetActive(false);
            InBed = false;
        }

        if (InBed == true && Input.GetKeyDown(KeyCode.Mouse1))
        {
            Destroy(GameObject.FindGameObjectWithTag("Player"));
            SceneManager.LoadScene("Died");
        }

        if (InBed == false && Input.GetKeyDown(KeyCode.Mouse1))
        {
            
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            BedText.SetActive(true);
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            BedText.SetActive(false);
        }
    }
}
