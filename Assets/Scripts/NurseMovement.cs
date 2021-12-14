using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NurseMovement : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform target;
    public AudioClip firstClip;
    public AudioClip secondClip;
    public AudioClip thirdClip;
    UnityEngine.AI.NavMeshAgent agent;
    Animator animator;
    AudioSource monitor_Sound;

    void Start()
    {
        agent = GetComponent<UnityEngine.AI.NavMeshAgent>();
        agent.destination = target.position;
        monitor_Sound = GetComponent<AudioSource>();
        animator = GetComponent<Animator>();
        animator.SetBool("Walk", true);
    }
    void Update()
    {
        if (!agent.pathPending)
        {
            if (agent.remainingDistance <= agent.stoppingDistance)
            {
                if (!agent.hasPath || agent.velocity.sqrMagnitude == 0f)
                {
                    animator.SetBool("Walk", false);
                }
            }
        }
    }
    void OnTriggerEnter(Collider other)
    {
        Invoke("PlayFirstClip", 5.0f);
        //Invoke("PlayThirdClip", 30.0f);
    }
    void PlayFirstClip()
    {
        monitor_Sound.clip = firstClip;
        monitor_Sound.Play();
    }
}
