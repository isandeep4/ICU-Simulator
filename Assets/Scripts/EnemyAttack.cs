using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyAttack : MonoBehaviour
{
    public GameObject Target;
    NavMeshAgent agent;
    public float StoppingDistance = 1.0f;
    float Destination;
    Animator animator;
    public LaodPreviousScript previousLevel;
    // Start is called before the first frame update
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        animator = GetComponent<Animator>();
        agent.SetDestination(Target.transform.position);
    }

    // Update is called once per frame
    void Update()
    {
        
        Destination = Vector3.Distance(Target.transform.position, transform.position);

        if (Destination < StoppingDistance) 
        {
            Attack();
        }
    }
    void Attack()
    {
        animator.SetBool("Attack", true);
        Invoke("LoadPrevlevel", 10.0f);
    }
    void LoadPrevlevel()
    {
        previousLevel.ActionCompleted = true;
    }
}
