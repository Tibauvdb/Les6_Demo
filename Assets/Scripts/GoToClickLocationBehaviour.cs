using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class GoToClickLocationBehaviour : MonoBehaviour/*, IListener */{
    [SerializeField]
    private NavMeshAgent _agent;

    public void ClickedAt(Vector3 position)
    {
        _agent.destination = position;
    }

    
}
