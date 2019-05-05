using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CenterCameraAround : MonoBehaviour
{
    public GameObject CameraPositionObject;

    //object GetCameraFromScene()
    //{
    //    //return gameObject.transform.
    //}
    Vector3 m_originalPosition;
    Quaternion m_originalRotation;

    public UnityEngine.Animation m_CameraMovementAnimation;

    // Start is called before the first frame update
    void Start()
    {
        m_originalPosition = Camera.main.transform.position;
        m_originalRotation = Camera.main.transform.rotation;
    }

    // Update is called once per frame
    void Update()
    {
        if (m_CameraMovementAnimation != null && m_CameraMovementAnimation.isPlaying)
        {
            //m_CameraMovementAnimation.Get
        }
    }

    void DriveCameraToObject()
    {
        if (m_CameraMovementAnimation != null  && !m_CameraMovementAnimation.isPlaying)
        {
            m_CameraMovementAnimation.Play();
        }
    }
}
