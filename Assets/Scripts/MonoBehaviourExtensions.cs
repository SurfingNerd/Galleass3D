using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace Galleass3D
{
    public static class MonoBehaviourExtensions 
    {
        public static GameObject FindRecursiveByName(this GameObject go, string name)
        {
            for (int i = 0; i < go.transform.childCount; i++)
            {
                Transform childTransform = go.transform.GetChild(i);
                if (childTransform.name == name)
                    return childTransform.gameObject;
            }

            for (int i = 0; i < go.transform.childCount; i++)
            {
                Transform childTransform = go.transform.GetChild(i);
                return FindRecursiveByName(childTransform.gameObject, name);
            }

            return null;
        }

        
        public static T GetSingleComponentFromActiveScene<T>(bool includeInactive = false)
        where T : class
        {
            T result = null;

            foreach(GameObject rootObject in UnityEngine.SceneManagement.SceneManager.GetActiveScene().GetRootGameObjects())
            {
                T potentialResult = rootObject.GetComponentInChildren<T>(includeInactive);
                if (potentialResult != null)
                {
                    if (result != null)
                    {
                        Debug.LogError("More than one Component of type: " + typeof(T).Name + " found. This could result in expected behavior.");
                    }
                    else
                    {
                        result = potentialResult;
                    }
                }
            }
            return result;
        }
    }


}