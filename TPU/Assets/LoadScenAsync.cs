using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadScenAsync : MonoBehaviour
{
    public string ScenName;
    public int indexScen = 1;
	void Start () {
	    StartCoroutine(LoadYourAsyncScene());
    }

    IEnumerator LoadYourAsyncScene()
    {
        yield return new WaitForSeconds(0.1f);
        AsyncOperation asyncLoad = SceneManager.LoadSceneAsync(indexScen);
        asyncLoad.allowSceneActivation = false;


        while (!asyncLoad.isDone)
        {
            float progress = Mathf.Clamp01(asyncLoad.progress / 0.9f);
            Debug.Log("Loading progress: " + (progress * 100) + "%");

            if (asyncLoad.progress == 0.9f)
            {
                Debug.Log("Press a key to start");
                yield return new WaitForSeconds(1.5f);
                asyncLoad.allowSceneActivation = true;
            }
        }
    }
}
