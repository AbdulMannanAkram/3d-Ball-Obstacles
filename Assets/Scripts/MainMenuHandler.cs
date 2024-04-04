using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class MainMenuHandler : MonoBehaviour
{
    //private string playerName = "PlayerName";
    //public InputField nameInputfield;
    //public Text playerNametext;

    //private void Start()
    //{
    //    if (PlayerPrefs.HasKey(playerName))
    //    {
    //        //nameInputfield.text =  PlayerPrefs.GetString(playerName);
    //        playerNametext.text = "Name : " + PlayerPrefs.GetString(playerName);
    //        Debug.Log(PlayerPrefs.GetString(playerName));
    //    }
    //}
    //public void createNewUserName()
    //{
    //    saveUserName();
    //   // username=nameInputfield.text;
    //}
    //public void saveUserName()
    //{
    //    //if (nameInputfield.isFocused && Input.anyKeyDown)
    //    //{
    //    //    Debug.Log("User is typing");
    //    //}

    //    // if (Input.anyKeyDown)
    //    // {
    //        PlayerPrefs.SetString(playerName, nameInputfield.text);
    //        Debug.Log("After Setting Player Name " + PlayerPrefs.GetString(playerName));
    //        Start();
    //     //  }
    //}
    //private void Awake()
    //{
    //    PlayerPrefs.DeleteAll();
    //}
    public void OnPlayButton()
    {
        Debug.Log("On Playing Game");
        SceneManager.LoadScene("MainScene");
    }
    public void OnQuitButton()
    {
        Debug.Log("Game Quit executes");
        Application.Quit();
    }

    //string username
    //{
    //    get { return PlayerPrefs.GetString(playerName); }
    //    set { PlayerPrefs.SetString(playerName, nameInputfield.text);Start(); }
    //}


    //private GameDataSaveHandler obj=new GameDataSaveHandler();
    //private GameDataSavehandler createSaveGameObjects()
    //{
    //    GameDataSaveHandler saveGameObj = new GameDataSaveHandler();
    //    int i = 0;
    //}
}