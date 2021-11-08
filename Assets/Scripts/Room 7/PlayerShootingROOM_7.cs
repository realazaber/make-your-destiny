using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShootingROOM_7 : MonoBehaviour 
{
	public int PlayerAmmo = 12;
	public int BulletSpeed = 5;

	public AudioClip GunShootSound;
    public AudioClip EmptyGunShootSound;

    public GameObject Not_Shoot_Hammer;
	public GameObject Not_Shoot_Trigger;

	public GameObject Has_Ammo_Slide;
	public GameObject No_Ammo_Slide;	

	public GameObject Shoot_Hammer;
	public GameObject Shoot_Trigger;

	public GameObject Bullet;
	public Transform Bullet_Spawn;

	// Use this for initialization
	void Start () 
	{
		Not_Shoot_Hammer.SetActive(true);
		Shoot_Hammer.SetActive(false);
		Not_Shoot_Trigger.SetActive(true);
		Shoot_Trigger.SetActive(false);
		Has_Ammo_Slide.SetActive(true);
		No_Ammo_Slide.SetActive(false);
	}
	
	// Update is called once per frame
	void Update () 
	{
		if (Input.GetKeyDown(KeyCode.Mouse2))
		{
			Not_Shoot_Hammer.SetActive(false);
			Shoot_Hammer.SetActive(true);
			Not_Shoot_Trigger.SetActive(false);
			Shoot_Trigger.SetActive(true);
		}

		if (Input.GetKeyDown(KeyCode.Mouse2) && PlayerAmmo > 0)
		{
			Debug.Log("Player Fire Key");

            PlayerAmmo = PlayerAmmo - 1; //reduce ammo by 1

            AudioSource.PlayClipAtPoint(GunShootSound, transform.position); //Play the Audio Clip

            GameObject Player_BulletInstance = Instantiate(Bullet, Bullet_Spawn.position, Bullet_Spawn.rotation) as GameObject; //Shoot the shell

            Player_BulletInstance.GetComponent<Rigidbody>().velocity = BulletSpeed * Bullet_Spawn.forward;

            Destroy(Player_BulletInstance, 10);
		}

		if (Input.GetKeyDown(KeyCode.Mouse2) && PlayerAmmo <= 0)
		{
            AudioSource.PlayClipAtPoint(EmptyGunShootSound, transform.position); //Play the Audio Clip
        }  
        
        if (PlayerAmmo <= 0)
        {
            Has_Ammo_Slide.SetActive(false);
            No_Ammo_Slide.SetActive(true);
        }          

		if (Input.GetKeyUp(KeyCode.Mouse2))
		{
			Not_Shoot_Hammer.SetActive(true);
			Shoot_Hammer.SetActive(false);
			Not_Shoot_Trigger.SetActive(true);
			Shoot_Trigger.SetActive(false);
            
            

        }
	}
}
