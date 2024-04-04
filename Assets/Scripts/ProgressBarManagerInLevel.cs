using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class ProgressBarManagerInLevel : MonoBehaviour
{
    public Slider slider;
    public void ProgressBarLoading()
    {
        StartCoroutine("LoadAscynchronously");
    }
    IEnumerator LoadAscynchronously(int sceneIndex)
    {
        AsyncOperation operation = SceneManager.LoadSceneAsync(sceneIndex);
        while (!operation.isDone)
        {
            float progress=Mathf.Clamp01(operation.progress/.9f);
            slider.value=progress;
            //Debug.Log(operation.progress);
            yield return null;
        }
    }
}
