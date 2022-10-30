using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Police : MonoBehaviour
{
    public NavMeshAgent agent;
    public Transform player;
    public LayerMask whatIsPlayer;

    //See if the player is in range
    public float sightRange;
    public bool playerIsInRange;

    private void Awake()
    {
        player = GameObject.Find("Player").transform;
        agent = GetComponent<NavMeshAgent>();
    }

    private void Update()
    {
        //Check for sight in range
        playerIsInRange = Physics.CheckSphere(transform.position, sightRange, whatIsPlayer);

        if (playerIsInRange) ChasePlayer();
    }

    private void ChasePlayer()
    {
        transform.LookAt(player);
        agent.SetDestination(player.position);
    }


}
