using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class SpecialKid : MonoBehaviour {

    public NavMeshAgent enemyNavMeshAgent; //creates a public NavMeshAgent variable called enemyNavMeshAgent

    public GameObject PlayerTarget; //creates a public gameobject called PlayerTarget

    public bool PlayerInRange = true; //creates a public bool called Player1InRange and sets it to false

    public GameObject OpenedDoor;
    // Use this for initialization
    void Start()
    {
        enemyNavMeshAgent = GetComponent<NavMeshAgent>(); //Tells the variable to read from the NAvMesh Agent attached to it
        PlayerTarget = GameObject.FindGameObjectWithTag("Player"); //tells the object attached to this script to look for anything with the tag Player_1
    }

    // Update is called once per frame
    void Update()
    {

        if (OpenedDoor != null && PlayerInRange == true) //Checks if the player is in range and if they exist
        {
            enemyNavMeshAgent.destination = PlayerTarget.transform.position; //go to player position
        }


    }

    //Plays once when an object with a rigidbody enters the trigger
    

    //Plays once when an object with a rigidbody exits the trigger
   
}
