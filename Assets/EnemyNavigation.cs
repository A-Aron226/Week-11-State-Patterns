using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using UnityEngine.AI;

public class EnemyNavigation : MonoBehaviour
{
    NavMeshAgent agent;
    [SerializeField] float wanderLocation;

    Vector3 staatingLocation;
    // Start is called before the first frame update
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        staatingLocation = transform.position;

        GetRandomPoint();
    }

    // Update is called once per frame
    void Update()
    {
    }

    [ContextMenu("Move to Random Location")] //Testing if function works as intended

    public void GoToRandomPosition()
    {
        agent.SetDestination(GetRandomPoint());
    }
    Vector3 GetRandomPoint()
    {
        Vector3 offset = new Vector3(Random.Range(-wanderLocation, wanderLocation), 0, Random.Range(-wanderLocation, wanderLocation)); //Random position the enemy object can move toward.

        NavMeshHit hit;

        bool gotPoint = NavMesh.SamplePosition(staatingLocation + offset, out hit, 1, NavMesh.AllAreas);

        if (gotPoint)
        {
            return hit.position;
        }

        return Vector3.zero;
    }
}
