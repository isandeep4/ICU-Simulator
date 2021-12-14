using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class NurseMovement3 : MonoBehaviour
{
    public Transform[] path;
    Animator animator;
    //NavMeshAgent agent;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        //agent = GetComponent<NavMeshAgent>();
        StartCoroutine(FollowPath());
    }
    IEnumerator FollowPath()
    {
        foreach (Transform waypoint in path)
        {
            yield return StartCoroutine(Move(waypoint.position, 2));
        } 
    }
    IEnumerator Move(Vector3 destination, float speed)
    {
        while(transform.position != destination)
        {
            //agent.SetDestination(destination);
            transform.position = Vector3.MoveTowards(transform.position, destination, speed * Time.deltaTime);
            transform.rotation = Quaternion.LookRotation(destination);
            animator.SetBool("Walk", true);
            yield return null;
        }
        
    }


}
