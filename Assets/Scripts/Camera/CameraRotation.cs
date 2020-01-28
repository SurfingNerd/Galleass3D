using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraRotation : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
         
    }

    // Update is called once per frame
    void Update()
    {
        int cameraChange = 0;
        if (Input.GetKeyDown(KeyCode.PageDown))
        {
            cameraChange = -1;
        } else if (Input.GetKeyDown(KeyCode.PageUp))
        {
            cameraChange = 1;
        }

        if (cameraChange != 0) 
        {
            List<Camera> listCameras = new List<Camera>();
            foreach(GameObject rootObject in UnityEngine.SceneManagement.SceneManager.GetActiveScene().GetRootGameObjects())
            {
                listCameras.AddRange(rootObject.GetComponentsInChildren<Camera>(true));
            }

            Debug.Log("#Cameras: " + listCameras.Count);

            int currentActiveCam = -1;

            for (int i = 0; i < listCameras.Count ; i++)
            {
                Camera thisCam = listCameras[i];
                if (thisCam.enabled)
                {
                    currentActiveCam = i;
                    thisCam.enabled = false;
                    break;
                }
            }

            if (currentActiveCam + cameraChange >= listCameras.Count)
            {
                listCameras[0].enabled = true;
            }
            else if (currentActiveCam + cameraChange < 0)
            {
                listCameras[listCameras.Count - 1].enabled = true;
            }
            else 
            {
                listCameras[currentActiveCam + cameraChange].enabled = true;                
            }
        }
        
        // for (int i = 0; i < objects.Length; i++)
        // {
        //     objects[i].SetActive(i == nextactiveobject);
        // }        
    }
}
