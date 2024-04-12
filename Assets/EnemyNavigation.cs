using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.AI;

public class EnemyNavigation : MonoBehaviour
{
    //code for AI to wander around, and chase
    NavMeshAgent agent;
    float wanderLocation = 10;
    Transform targetLocation;

    float elapsed = 0;

    Vector3 startingLocation;
    // Start is called before the first frame update
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        startingLocation = transform.position;
        targetLocation = FindObjectOfType<FPSController>().transform;

        GetRandomPoint();
    }

    // Update is called once per frame
    void Update()
    {
        agent.SetDestination(targetLocation.position);
    }
    /*public void ChaseLocation() //used in StateWanderObjectPursue
    {
        targetLocation.GetComponent<FPSController>(); //Gets controller component
        agent.SetDestination(targetLocation.position); //Chases player
    }*/

    [ContextMenu("Move to Random Location")] //Testing if function works as intended

    public void GoToRandomPosition()
    {
        agent.SetDestination(GetRandomPoint());
    }
    public Vector3 GetRandomPoint()
    {
        Vector3 offset = new Vector3(Random.Range(-wanderLocation, wanderLocation), 0, Random.Range(-wanderLocation, wanderLocation)); //Random position the enemy object can move toward.

        NavMeshHit hit;

        bool gotPoint = NavMesh.SamplePosition(startingLocation + offset, out hit, 1, NavMesh.AllAreas);

        if (gotPoint)
        {
            return hit.position;
        }

        elapsed += Time.deltaTime;

        if (elapsed > 2)
        {
            GetRandomPoint();
        }

        return Vector3.zero;
    }
}
