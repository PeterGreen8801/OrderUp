using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelTrigger : MonoBehaviour
{
    // SceneTransitionManager SceneTransitionManager;

    void Start()
    {
        // SceneTransitionManager = GetComponent<SceneTransitionManager>();
    }

    void Update()
    {

    }

    /*
        private void OnTriggerEnter(Collider other)
        {
            if (other.CompareTag("MainCamera"))
            {
                SceneTransitionManager.GoToScene(2);
            }
        }
        */


    public void OnTriggerEnter(Collider other)
    {
        Debug.Log("Trigger Worked");
        SceneTransitionManager.singleton.GoToSceneAsync(2);
    }

    void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Worked!!!!");
        SceneTransitionManager.singleton.GoToSceneAsync(2);
    }

}
