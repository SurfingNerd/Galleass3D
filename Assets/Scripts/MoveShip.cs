using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class MoveShip : MonoBehaviour
{
     UnityEngine.AI.NavMeshAgent m_navMeshAgent;
     UnityEngine.GameObject m_target;

    // Start is called before the first frame update
    void Start()
    {
        m_target = GameObject.FindWithTag("Finish");
        m_navMeshAgent = GetComponent<UnityEngine.AI.NavMeshAgent>();
        m_navMeshAgent.SetDestination(m_target.transform.position);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
