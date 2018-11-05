using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class SteeringBehaviour : MonoBehaviour {
    [SerializeField]
    private NavMeshAgent _agent;


    private void Start()
    {
        _agent.updateRotation = false;
    }

    void Update () {

        if (!_agent.hasPath) return;

        Vector3 direction = _agent.steeringTarget - transform.position;

        Quaternion rotation = Quaternion.RotateTowards(transform.rotation, Quaternion.LookRotation(direction), 2);

        transform.rotation = rotation;

        _agent.velocity = transform.forward * _agent.speed;
	}
}
