using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerShoot : MonoBehaviour
{
    public GameObject Player_Gun;
    public GameObject Player_Bullet; //Refers to Player 1 shell prefab
    public GameObject Player_Gun_Chamber;

    public GameObject ReadiedGun;
    public GameObject Emptygun;

    
    public GameObject ReadiedGun_NotShotGunThingo;
    public GameObject ReadiedGun_ShotGunThingo;

    public GameObject Empty_NotShotGunThingo;
    public GameObject Empty_ShotGunThingo;

    public Transform Player_BulletSpawnLocation; //Creates Spawn location for Player 1 shell
    public float Player_FireForce; //Speed of shell
    public KeyCode Player_FireKey = KeyCode.Mouse3; //Key used to fire shell
    public AudioClip GunShootSound; //Reference to an audio clip
    public AudioClip EmptyGunShootSound; //Reference to an audio clip
    public int PlayerAmmo;
    public GameObject Enemy;

    void Start()
    {
            ReadiedGun_ShotGunThingo.SetActive(false);
            ReadiedGun_NotShotGunThingo.SetActive(true);
    }
    // Update is called once per frame
    void Update()
    {
        if (PlayerAmmo > 0)
        {
            ReadiedGun.SetActive(true);
            Emptygun.SetActive(false);
        }
        if (Input.GetKeyDown(Player_FireKey) && PlayerAmmo > 0 && Player_Gun.activeSelf) //Checks if fire key is pressed and if player has ammo
        {
            ReadiedGun_ShotGunThingo.SetActive(true);
            ReadiedGun_NotShotGunThingo.SetActive(false);

            Debug.Log("Player Fire Key");

            PlayerAmmo = PlayerAmmo - 1; //reduce ammo by 1

            AudioSource.PlayClipAtPoint(GunShootSound, transform.position); //Play the Audio Clip

            GameObject Player_BulletInstance = Instantiate(Player_Bullet, Player_BulletSpawnLocation.position, Player_BulletSpawnLocation.rotation) as GameObject; //Shoot the shell

            Player_BulletInstance.GetComponent<Rigidbody>().velocity = Player_FireForce * Player_BulletSpawnLocation.forward;

            Destroy(Player_BulletInstance, 10);

            Player_Gun_Chamber.transform.Rotate(Vector3.up, 5 * Time.deltaTime);  
        }
        if (PlayerAmmo <= 0)
        {
            //Player_Gun.SetActive(false);
            //Enemy.SetActive(true);
            ReadiedGun.SetActive(false);
            Emptygun.SetActive(true);
        }
        if (PlayerAmmo <= 0 && Input.GetKeyDown(Player_FireKey))
        {
            //Player_Gun.SetActive(false);
            //Enemy.SetActive(true);
            AudioSource.PlayClipAtPoint(EmptyGunShootSound, transform.position); //Play the Audio Clip
            //ReadiedGun_ShotGunThingo.SetActive(true);
            //ReadiedGun_NotShotGunThingo.SetActive(false);
            Empty_ShotGunThingo.SetActive(true);
            Empty_NotShotGunThingo.SetActive(false); 
        }
        if (Input.GetKeyUp(Player_FireKey) && PlayerAmmo <= 0)
        {
            Empty_ShotGunThingo.SetActive(false);
            Empty_NotShotGunThingo.SetActive(true);
        }
        if (Input.GetKeyUp(Player_FireKey) && PlayerAmmo >= 1)
        {
            ReadiedGun_ShotGunThingo.SetActive(false);
            ReadiedGun_NotShotGunThingo.SetActive(true);
        }
    }
}