using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NavMeshMovement : MonoBehaviour
{
    public Transform[] path;
    Animator animator;
    UnityEngine.AI.NavMeshAgent agent;
    public Transform currentTarget;
    //public var targets : Transform[];
    // public var navigation : NavMeshAgent;
    private int i = 0;

    void Start()
    {
        animator = GetComponent<Animator>();
        agent = GetComponent<UnityEngine.AI.NavMeshAgent>();
        agent.destination = path[i].position;
        animator.SetBool("Walk", true);
    }

    void Update()
    {
        var dist = Vector3.Distance(path[i].position, transform.position);
        currentTarget = path[i];

        //if npc reaches its destination (or gets close)...
        if (dist < 0.5f)
        {
            if (i < path.Length - 1)
            { //negate targets[0], since it's already set in destination.
                i++; //change next target
                agent.destination = path[i].position; //go to next target by setting it as the new destination
            }
        }
    }
}
