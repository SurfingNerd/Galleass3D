using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class MoveShip : MonoBehaviour
{
    UnityEngine.AI.NavMeshAgent m_navMeshAgent;
    

    GameObject m_water;

    public float m_RaycastCheckDistance = 10000000;

    //public float surfaceOffset = 0.1f;

    private LayerMask m_waterlayerMask;

    // Start is called before the first frame update
    void Start()
    {
        m_navMeshAgent = GetComponent<UnityEngine.AI.NavMeshAgent>();
        if (m_navMeshAgent == null)
        {
            throw  new UnityException("MoveShip Script is expected to be place on a GameObject containing a NavMeshAgent.");
        }

        m_water = GameObject.FindGameObjectWithTag("Water");
        if (m_water == null)
        {
            throw new UnityException("Expected to find a GameObject with Tag Water for Navigation.");
        }
    
        m_waterlayerMask = LayerMask.GetMask("Default");
        Debug.Log("Water: " + m_waterlayerMask.value);

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

            // problem: there might be more than 1 active cameras in the scene. 
            // i could not find a decent way on hour to get the camera that was used for clicking.

            Camera cam = Galleass3D.MonoBehaviourExtensions.GetSingleComponentFromActiveScene<Galleass3D.Camera.CameraRotation>().activeCam;
            

            //Camera cam = Galleass3D.MonoBehaviourExtensions.GetSingleComponentFromActiveScene<Camera>();

            if (cam == null) 
            {
                Debug.LogWarning("There is no current camera!");
                return;
            }

            Debug.Log("Current Camera: " + cam.name);
            Ray ray = cam.ScreenPointToRay(Input.mousePosition);

#if UNITY_EDITOR
			// helper to visualise the ground check ray in the scene view
			Debug.DrawLine(ray.origin, ray.direction * m_RaycastCheckDistance, Color.green, 1.5f);
#endif  

            foreach(RaycastHit hit in Physics.RaycastAll(ray, m_RaycastCheckDistance, m_waterlayerMask.value, QueryTriggerInteraction.Ignore))
            {
                Vector3 finalPos = new Vector3(hit.point.x, m_water.transform.position.y, hit.point.z);
                Debug.Log("Sailing to position: " + finalPos);
                bool setDestinationResult = m_navMeshAgent.SetDestination(finalPos);

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
