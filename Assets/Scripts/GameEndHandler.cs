using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class GameEndHandler : MonoBehaviour
{
    public Animator anim;
    private void Awake()
    {
        anim = GetComponent<Animator>();
    }
    public void AgainPlayButtonClicked()
    {
        SceneManager.LoadScene("MainScene");
    }
    //private void Start()
    //{
    //    anim.SetTrigger("IsGameTriggered");
    //}
 
}
