using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.AI;

public class Movement : MonoBehaviour
{
    public GameObject[] wayPoints;
    private NavMeshAgent agent;
    private int waypoint;

    // Start is called before the first frame update
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        waypoint = 0;
        agent.SetDestination(wayPoints[waypoint].transform.position);
    }

    // Update is called once per frame
    void Update()
    {
        if (agent && agent.remainingDistance < 0.2f)
        {
            waypoint = (waypoint + 1) % wayPoints.Length;
            if (wayPoints[waypoint])
                agent.SetDestination(wayPoints[waypoint].transform.position);
        }

    }
}