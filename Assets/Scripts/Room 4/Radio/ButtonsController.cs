using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonsController : MonoBehaviour 
{
	public GameObject Button_1_UP;
	public GameObject Button_1_DOWN;
	public AudioClip Button_1_Sound;

	public GameObject Button_2_UP;
	public GameObject Button_2_DOWN;
	public AudioClip Button_2_Sound;

	public GameObject Button_3_UP;
	public GameObject Button_3_DOWN;
	public AudioClip Button_3_Sound;

	public GameObject Button_4_UP;
	public GameObject Button_4_DOWN;
	public AudioClip Button_4_Sound;

	public GameObject InRangeOfRadio;

	public bool CanPressButton = false;

	// Use this for initialization
	void Start () 
	{
		InRangeOfRadio.SetActive(false);

		Button_1_UP.SetActive(true);
		Button_1_DOWN.SetActive(false);
		
		Button_2_UP.SetActive(true);
		Button_2_DOWN.SetActive(false);
		
		Button_3_UP.SetActive(true);
		Button_3_DOWN.SetActive(false);
		
		Button_4_UP.SetActive(true);
		Button_4_DOWN.SetActive(false);
	}
	
	// Update is called once per frame
	void Update () 
	{
		if (CanPressButton == true)
		{
			if (Input.GetKeyDown(KeyCode.Alpha1))
			{
				Button_1_UP.SetActive(false);
				Button_1_DOWN.SetActive(true);
				AudioSource.PlayClipAtPoint(Button_1_Sound, transform.position);
			}
			if (Input.GetKeyUp(KeyCode.Alpha1))
			{
				Button_1_UP.SetActive(true);
				Button_1_DOWN.SetActive(false);
			}

			if (Input.GetKeyDown(KeyCode.Alpha2))
			{
				Button_2_UP.SetActive(false);
				Button_2_DOWN.SetActive(true);
				AudioSource.PlayClipAtPoint(Button_2_Sound, transform.position);
			}
			if (Input.GetKeyUp(KeyCode.Alpha2))
			{
				Button_2_UP.SetActive(true);
				Button_2_DOWN.SetActive(false);
			}

			if (Input.GetKeyDown(KeyCode.Alpha3))
			{
				Button_3_UP.SetActive(false);
				Button_3_DOWN.SetActive(true);
				AudioSource.PlayClipAtPoint(Button_3_Sound, transform.position);
			}
			if (Input.GetKeyUp(KeyCode.Alpha3))
			{
				Button_3_UP.SetActive(true);
				Button_3_DOWN.SetActive(false);
			}

			if (Input.GetKeyDown(KeyCode.Alpha4))
			{
				Button_4_UP.SetActive(false);
				Button_4_DOWN.SetActive(true);
				AudioSource.PlayClipAtPoint(Button_4_Sound, transform.position);
			}
			if (Input.GetKeyUp(KeyCode.Alpha4))
			{
				Button_4_UP.SetActive(true);
				Button_4_DOWN.SetActive(false);
			}
		}
	}

	void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.tag == "Player")
		{
			InRangeOfRadio.SetActive(true);
			CanPressButton = true;
		}
	}

	void OnTriggerExit(Collider other)
	{
		if (other.gameObject.tag == "Player")
		{
			InRangeOfRadio.SetActive(false);
			CanPressButton = false;
		}
	}
}