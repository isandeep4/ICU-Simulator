using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DocAnimatorController : MonoBehaviour
{
    public Transform goal;
    Animator animator;
    AudioSource audio_source;
    UnityEngine.AI.NavMeshAgent agent;
    // Start is called before the first frame update
    void Start()
    {
        audio_source = GetComponent<AudioSource>();
        animator = GetComponent<Animator>();
        agent = GetComponent<UnityEngine.AI.NavMeshAgent>();
    }
    public IEnumerator RunAnimation()
    {
        agent.destination = goal.position;
        animator.SetBool("Run", true);
        Invoke("Talk",1.0f);
        yield return null;
        //yield return new WaitForSeconds(5.0f);

    }
    // Update is called once per frame
    void Update()
    {
        if (!agent.pathPending)
        {
            if (agent.remainingDistance <= agent.stoppingDistance)
            {
                if (!agent.hasPath || agent.velocity.sqrMagnitude == 0f)
                {
                    animator.SetBool("Run", false);
                }
            }
        }
    }
    void Talk()
    {
        animator.SetBool("Dtalk", true);
        audio_source.Play();
        //yield return null;
    }
}
