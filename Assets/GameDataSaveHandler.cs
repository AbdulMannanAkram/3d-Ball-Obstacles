using System.Collections;
using System.IO;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
//private IEnumerable<GameObject> targets;
public class GameDataSaveHandler:MonoBehaviour
{
    string playernameprefs = "playerName";
  //  string playerLevel = "playerLevel";
    List <PlayerData> playerDataList;
    PlayerData currentPlayerDataObj;
    [SerializeField]
    private InputField playerName;
    int count;
    private bool isPlayerFoundinList=false;
    public Text activePlayerNameText;
    private bool found;


    private void Awake()
    {
      //  PlayerPrefs.DeleteAll();
        //PlayerPrefs.DeleteKey(playernameprefs);
        currentPlayerDataObj = new PlayerData();
        playerDataList = new List<PlayerData>();
        found = false;
        count = 0;
    }

    public void getStoredDataPlayer()
    {
        Debug.Log("Submit Button triggers");
        if (PlayerPrefs.HasKey(playernameprefs)==false)
        {
            currentPlayerDataObj.playerName = playerName.text;
            currentPlayerDataObj.playerLevel = 1;

            playerDataList.Add(currentPlayerDataObj);
            activePlayerNameText.text = "Name : " + currentPlayerDataObj.playerName;
            Debug.Log("Player not found in the list");
        }
        else
        {
            Debug.Log("Else part executes & some player name is already exist");
            //if has key playerprefs lead to Has Key 
            string myPlayerList = PlayerPrefs.GetString(playernameprefs);
            Debug.Log("Value in Player Prefs is : "+myPlayerList);
            PlayerListContainer containList = JsonUtility.FromJson<PlayerListContainer>(myPlayerList);
            playerDataList = containList.playerslist;
            foreach (PlayerData players in playerDataList)
            {
                Debug.Log("Within Foreach Loop");
                ++count;
                if (players.playerName == playerName.text)
                {
                    isPlayerFoundinList = true;
                    currentPlayerDataObj.playerName = players.playerName;
                    currentPlayerDataObj.playerLevel = players.playerLevel;
                    found = true;
                }
            }
                if(found==false)
                {
                    currentPlayerDataObj.playerName = playerName.text;
                    currentPlayerDataObj.playerLevel = 1;
                    playerDataList.Add(currentPlayerDataObj);

            }


            Debug.Log("count is : " + count);
            activePlayerNameText.text = "Name : " + currentPlayerDataObj.playerName;
        }
    }
    private void OnApplicationQuit()
    {
        if (isPlayerFoundinList)
        {
            playerDataList[count].playerName = currentPlayerDataObj.playerName;
            playerDataList[count].playerLevel = currentPlayerDataObj.playerLevel;
        }
        PlayerListContainer container = new PlayerListContainer(playerDataList);
        string json = JsonUtility.ToJson(container);
        PlayerPrefs.SetString(playernameprefs, json);

    }





























    //private void Start()
    //{
    //    PlayerData playerDataObj = new PlayerData();
    //    playerDataObj.playerName = "Usman";
    //    playerDataObj.playerLevel = 1;

    //    //////////string json = JsonUtility.ToJson(playerDataObj);
    //    //////////Debug.Log(json);
    //    //////////File.WriteAllText(Application.dataPath + "/saveFile.json",json);
    //    string jsonReader = File.ReadAllText(Application.dataPath + "saveFile.json");
    //    //  PlayerData loadedPlayerData = JsonUtility.FromJson<PlayerData>(jsonReader);
    //    playerDataObj = JsonUtility.FromJson<PlayerData>(jsonReader);
    //    Debug.Log("Loaded player Name is :  " + playerDataObj.playerName);
    //    Debug.Log("Loaded player level is : " + playerDataObj.playerLevel);


    //}
}

//[System.Serializable]
public struct PlayerListContainer
{
    public List<PlayerData> playerslist;
    public PlayerListContainer(List<PlayerData> otherList)
    {
        playerslist = otherList;
    }
}

[System.Serializable]
public class PlayerData
{
    public int playerLevel;
    public string playerName;
}







//////private GameDataSaveHandler obj=new GameDataSaveHandler();
//private GameDataSaveHandler CreateSaveGameObjects()
//{
//    GameDataSaveHandler saveGameObj = new GameDataSaveHandler();
//    int i = 0;
//    foreach (GameObject targetGamObject in saveGameObj)
//    {

//    }
//    return saveGameObj;
//}
