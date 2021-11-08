using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NewTextController : MonoBehaviour
{

    public GameObject Text;

    public GameObject Camera;

    public GameObject Helicopter;

    public bool HelicopterMoveWithPlayer = false;

    public float HeliSpeed = 0.5f;

    // Use this for initialization
    void Start ()
    {
        Camera.SetActive(false);

    }
	
	// Update is called once per frame
	void Update () 
    {
        
        if (Text.activeSelf == true && Input.GetKeyDown(KeyCode.Mouse1))
        {
            Destroy(GameObject.FindGameObjectWithTag("Player"));
            Camera.SetActive(true);
            HelicopterMoveWithPlayer = true;
        }

        if (HelicopterMoveWithPlayer == true) //LEAVING WITH THE PLAYER
        {
            Helicopter.transform.position = transform.position + transform.forward * HeliSpeed;
            Helicopter.transform.position = transform.position + transform.up * HeliSpeed;
            SceneManager.LoadScene("7");
            
        }

    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            Text.SetActive(true);
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            Text.SetActive(false);
        }
    }
}
