using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneDebugManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.R))
        {
            UnityEngine.SceneManagement.SceneManager.LoadSceneAsync(UnityEngine.SceneManagement.SceneManager.GetActiveScene().name, UnityEngine.SceneManagement.LoadSceneMode.Single);
        }
        if (Input.GetKey(KeyCode.Escape))
        {
            Application.Quit();
            //UnityEngine.SceneManagement.SceneManager.GetActiveScene()
        }
    }
}
