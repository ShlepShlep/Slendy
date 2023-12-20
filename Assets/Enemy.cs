using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Enemy : MonoBehaviour
{
    public Transform target;
    public float speed = 5;
    public float viewDistance;
    public float wanderDistance;
    public int chance;

    Rigidbody rb;
    NavMeshAgent agent;
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
    }
    void Update()
    {
        agent.speed = speed;
        var distance = Vector3.Distance(transform.position, target.position);

        if(distance < viewDistance)
        {
            agent.destination = target.position;
        }
        else
        {
            if(Random.Range(0, chance) == 1)
            {
                var offset = Random.insideUnitSphere * wanderDistance;
                agent.destination = transform.position + offset;
            }
            
        }

        if (distance < 1f)
        {
            //jumpscare
        }
        
    }
}
