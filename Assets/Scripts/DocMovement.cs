using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class DocMovement : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject flashLight;
    public Transform goal;
    NavMeshAgent agent;
    Animator animator;
    AudioSource audio_source;
    //bool walking;

    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        audio_source = GetComponent<AudioSource>();
        animator = GetComponent<Animator>();
        //Invoke("PlayEmergencyAudio", 20.0f);
    }
   
    public IEnumerator WalkAnimation()
    {
        agent.destination = goal.position;
        animator.SetBool("DWalk", true);
        yield return StartCoroutine(MeasureHB());
        //yield return new WaitForSeconds(1.5f);
        //StartCoroutine(MeasureHB();

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
                    // StartCoroutine(MeasureHB());
                }
            }
        }

    }
    public IEnumerator MeasureHB()
    {
        //flashLight.SetActive(true);
        animator.SetBool("HeartBeat", true);
        yield return new WaitForSeconds(1.5f);
        //yield return StartCoroutine(TalkAnimation());
        //Invoke("TalkAnimation", 1.0f); 
        //yield return null;
    }
    //public IEnumerator TalkAnimation()
    //{
    //    flashLight.SetActive(false);
    //    //animator.SetBool("HeartBeat", false);
    //    animator.SetBool("Talk", true);
    //    audio_source.Play();
    //    yield return null;
    //}
}
