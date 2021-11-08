using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WalkieTalkieController : MonoBehaviour
{
    public AudioClip WalkieTalkieSound;

    public GameObject WalkieTalkie;

    public GameObject Button;

    public GameObject ButtonDown;

    public GameObject SpecialAction;

    // Use this for initialization
    void Start ()
    {
        
        Button.SetActive(true);
        ButtonDown.SetActive(false);
        SpecialAction.SetActive(false);

    }
	
	// Update is called once per frame
	void Update ()
    {
		if (WalkieTalkie.activeSelf == true && Input.GetKeyDown(KeyCode.E))
        {
            AudioSource.PlayClipAtPoint(WalkieTalkieSound, transform.position);
            Button.SetActive(false);
            ButtonDown.SetActive(true);
        }
        if (Input.GetKeyUp(KeyCode.E))
        {
            Button.SetActive(true);
            ButtonDown.SetActive(false);
        }

        if (WalkieTalkie.activeSelf == true)
        {
            SpecialAction.SetActive(false);
        }
        
	}
}
