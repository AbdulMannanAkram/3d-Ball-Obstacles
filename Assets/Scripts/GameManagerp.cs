//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;
//using UnityEngine.SceneManagement;
//public class GameManager : MonoBehaviour
//{
//    public GameObject loadingGame;
//    List<AsyncOperation> sceneLoading = new List<AsyncOperation>();
//    void LoadGame()
//    {
//        loadingGame.gameObject.SetActive(true);
//        //loadingGame.Add
//        sceneLoading.Add(SceneManager.LoadSceneAsync("MainScene"));
//        StartCoroutine("GetSceneLoadProgress");
//    }
//    float totalSceneProgress;
//    public IEnumerator GetSceneLoadProgress()
//    {
//        for (int i = 0; i < sceneLoading.Count; i++)
//        {
//            while (!sceneLoading[i].isDone)
//            {
//                foreach(AsyncOperation operation in sceneLoading)
//                {
//                    totalSceneProgress += operation.progress;
//                }
//                totalSceneProgress = totalSceneProgress / sceneLoading.Count;
//                yield return null;
//            }
//        }
//        loadingGame.gameObject.SetActive(false);
//    }
//}
