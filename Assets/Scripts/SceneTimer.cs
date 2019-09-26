using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneTimer : MonoBehaviour
{
    public SceneController sceneManager;

    private void Update()
    {
        float sceneTime = Time.timeSinceLevelLoad;

        if (sceneTime >= 20)
        {
            sceneManager.LoadNextScene();
        }
    }
}
