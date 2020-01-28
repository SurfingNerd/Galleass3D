using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class MoveShip : MonoBehaviour
{
    UnityEngine.AI.NavMeshAgent m_navMeshAgent;
    UnityEngine.GameObject m_target;

    GameObject m_water;

    public float m_RaycastCheckDistance = 10000000;

    public float surfaceOffset = 0.1f;

    private LayerMask m_waterayerMask;

    // Start is called before the first frame update
    void Start()
    {
        m_target = GameObject.FindWithTag("Finish");
        m_navMeshAgent = GetComponent<UnityEngine.AI.NavMeshAgent>();
        m_navMeshAgent.SetDestination(m_target.transform.position);
        m_water = GameObject.FindGameObjectWithTag("Water");

        m_waterayerMask = LayerMask.GetMask("Default");
        Debug.Log("Water: " + m_waterayerMask.value);

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Debug.LogWarning("Mouse down 0!");
            
// 			RaycastHit hitInfo;


			// // 0.1f is a small offset to start the ray from inside the character
			// // it is also good to note that the transform position in the sample assets is at the base of the character
			// if (Physics.Raycast(transform.position + (Vector3.up * 0.1f), Vector3.down, out hitInfo, m_RaycastCheckDistance))
			// {
			// 	m_GroundNormal = hitInfo.normal;
			// 	m_IsGrounded = true;
			// 	m_Animator.applyRootMotion = true;
			// }

            //             if (!Input.GetMouseButtonDown(0))
            // {
            //     return;
            // }

            
            if (Camera.main == null) 
            {
                Debug.LogWarning("There is no main camera!");
                return;
            }

            

            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

#if UNITY_EDITOR
			// helper to visualise the ground check ray in the scene view
			Debug.DrawLine( ray.origin, ray.direction * 1000, Color.green, 1.5f);
#endif  

            foreach(RaycastHit hit in Physics.RaycastAll(ray, m_RaycastCheckDistance, m_waterayerMask.value, QueryTriggerInteraction.Ignore))
            {
                Debug.Log("Sailing to position: " +  hit.transform.position);
                bool setDestinationResult = m_navMeshAgent.SetDestination(new Vector3(hit.point.x, m_water.transform.position.y, hit.point.z));

                if (!setDestinationResult) 
                {
                    Debug.LogWarning("Unable to sail to demanded position");
                }
                

                // if(hit.transform.CompareTag("Water"))
                // {
                //     Debug.Log("Sailing to position: " +  hit.transform.position);
                //     m_navMeshAgent.SetDestination(transform.position);
                // }
                // else
                // {
                //     Debug.Log("Hit something else! ", hit.transform.gameObject);
                // }
            }

            // if (setTargetOn != null)
            // {
            //     setTargetOn.SendMessage("SetTarget", transform);
            // }
        }
    }
}
