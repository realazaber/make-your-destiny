using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DoNotKillMe : MonoBehaviour
{
    public GameObject Player;

    public static GameObject sm_instance = null;

    // Use this for initialization
    void Start ()
    {
        

    }
	
	// Update is called once per frame
	void Update ()
    {
		
	}

    void Awake()
    {
        sm_instance = null;
        if (sm_instance)
        {
            Destroy(sm_instance);
        }
        else
        {
            sm_instance = Player.gameObject;
            DontDestroyOnLoad(Player.gameObject);
        }

    }
}
