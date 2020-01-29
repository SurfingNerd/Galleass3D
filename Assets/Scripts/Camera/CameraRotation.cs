using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace Galleass3D.Camera
{
    public class CameraRotation : MonoBehaviour
    {

        public UnityEngine.Camera activeCam;

        // Start is called before the first frame update
        void Start()
        {
            
            activeCam = UnityEngine.Camera.main;

            Debug.Log("MainCamera active and enabled? " + activeCam.isActiveAndEnabled);
        }

        bool IsGameObjectRootedActive(GameObject go) 
        {
            if (go == null)
            {
                return true;
            }

            return go.activeInHierarchy;
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
                List<UnityEngine.Camera> listCameras = new List<UnityEngine.Camera>();
                foreach(GameObject rootObject in UnityEngine.SceneManagement.SceneManager.GetActiveScene().GetRootGameObjects())
                {
                    foreach(UnityEngine.Camera inSceneCamera in rootObject.GetComponentsInChildren<UnityEngine.Camera>(true)) 
                    {
                        if (inSceneCamera.gameObject.transform.parent == null /*~ all root cameras*/ 
                            || IsGameObjectRootedActive(inSceneCamera.gameObject.transform.parent.gameObject))
                        {
                            listCameras.Add(inSceneCamera);
                            //inSceneCamera.gameObject.transform.parent
                        }
                        //we only pick up cameras that are rooted under active objects
                        //if ()

                    }
                }

                Debug.Log("#Cameras: " + listCameras.Count);

                int currentActiveCam = -1;

                for (int i = 0; i < listCameras.Count ; i++)
                {
                    UnityEngine.Camera thisCam = listCameras[i];
                    if (thisCam.enabled)
                    {
                        currentActiveCam = i;
                        thisCam.enabled = false;
                        break;
                    }
                }

                if (currentActiveCam + cameraChange >= listCameras.Count)
                {
                    activeCam = listCameras[0];
                    activeCam.enabled = true;
                    
                }
                else if (currentActiveCam + cameraChange < 0)
                {
                    activeCam = listCameras[listCameras.Count - 1];
                    activeCam.enabled = true;
                }
                else 
                {
                    activeCam = listCameras[currentActiveCam + cameraChange];
                    activeCam.enabled = true;                
                }
            }
            
            // for (int i = 0; i < objects.Length; i++)
            // {
            //     objects[i].SetActive(i == nextactiveobject);
            // }        
        }
    }
}