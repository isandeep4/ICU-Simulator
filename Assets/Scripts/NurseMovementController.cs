using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NurseMovementController : MonoBehaviour
{
    public Transform goal;
    public GameObject injection;
    UnityEngine.AI.NavMeshAgent agent;
    Animator animator;
    public GameManagerScript gameManagerScript;
    public LevelLoaderScript levelLoader;
    //AudioSource emergency_Sound;
    //bool walking;

    void Start()
    {
        agent = GetComponent<UnityEngine.AI.NavMeshAgent>();
        //emergency_Sound = GetComponent<AudioSource>();
        animator = GetComponent<Animator>();
        //Invoke("PlayEmergencyAudio", 20.0f);
    }

    public IEnumerator RunAnimation()
    {
        agent.destination = goal.position;
        animator.SetBool("DWalk", true);
        yield return null;
        Inject();
        //yield return StartCoroutine(Inject());


    }
    void Update()
    {
        if (!agent.pathPending)
        {
            if (agent.remainingDistance <= agent.stoppingDistance)
            {
                if (!agent.hasPath || agent.velocity.sqrMagnitude == 0f)
                {
                    animator.SetBool("DWalk", false);
                }
            }
        }

    }
    void Inject()
    {
        //injection.SetActive(true);
        animator.SetBool("Bend", true);
        Invoke("InjectAnimationOff", 25.0f);
    }
    void InjectAnimationOff()
    {
        animator.SetBool("Bend", false);
        gameManagerScript.DeactivateObjects();
        //gameManagerScript.PlayLevelLoaderAnimation();
    }

}
