using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.SceneManagement;

public class Police : MonoBehaviour
{
    public NavMeshAgent agent;
    public Transform player;
    public LayerMask whatIsPlayer;

    //See if the player is in range
    public float sightRange;
    public bool playerIsInRange;

    [SerializeField] AudioSource detectedSFX;
    private void Awake()
    {
        player = GameObject.Find("Player").transform;
        agent = GetComponent<NavMeshAgent>();
    }

    private void Update()
    {
        //Check for sight in range
        playerIsInRange = Physics.CheckSphere(transform.position, sightRange, whatIsPlayer);

        if (playerIsInRange)
        {
            ChasePlayer();
            if(playerIsInRange == true)
            {
                detectedSFX.enabled = true;
            }
        }

        if (playerIsInRange == false)
        {
            detectedSFX.enabled = false;
        }
    }

    private void ChasePlayer()
    {
        transform.LookAt(player);
        agent.SetDestination(player.position);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag("Player"))
        {
            SceneManager.LoadScene("GameOver");
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
        }
    }
}
