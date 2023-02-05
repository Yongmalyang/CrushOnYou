using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System;

public class DataController : MonoBehaviour
{

    static GameObject _container;
    static GameObject Container
    {
        get
        {
            return _container;
        }
    }

    static DataController _instance;
    public static DataController Instance                                                   //해당 스크립트를 어디에서든 불러올 수 있게끔 하는 함수 
    {
        get
        {
            if (!_instance)
            {
                _container = new GameObject();
                _container.name = "DataController";
                _instance = _container.AddComponent(typeof(DataController)) as DataController;
                DontDestroyOnLoad(_container);
            }
            return _instance;
        }
    }

    public GameData _gameData;
    public GameData gameData
    {
        get
        {
            if (_gameData == null)
            {

                LoadGameData();
                ToGameJson();
            }
            return _gameData;
        }
    }

    public void LoadGameData()                                                                                                                  //게임 데이터 불러오기
    {
        string filePath = Path.Combine(Application.dataPath, "Scripts/GameDataManagement/GameData.json");


        if (File.Exists(filePath))
        {
            print(filePath);
            string FromJsonData = File.ReadAllText(filePath);
            _gameData = JsonUtility.FromJson<GameData>(FromJsonData);
        }
        else
        {
            ToGameJson();

        }
    }
    System.IO.StreamWriter SW = null;


    [ContextMenu("To Game Json")]
    public void ToGameJson()
    {
        string jsonData = JsonUtility.ToJson(gameData, true);
        string path = Path.Combine(Application.dataPath, "Scripts/GameDataManagement/GameData.json");
        File.WriteAllText(path, jsonData);
    }

    void OnApplicationQuit()
    {
        ToGameJson();
    }

    void Start()
    {
        if (PlayerPrefs.HasKey("key") == true)
        {
            if (gameObject.name == "DataControllerF")
                GameObject.Find("DataControllerF").SetActive(false);
        }

        if (PlayerPrefs.HasKey("key") == false) // 최초실행이면
        {
            PlayerPrefs.SetInt("key", PlayerPrefs.GetInt("key", 0)); //최초실행시 여기 저장...
            //Debug.Log("최초실행");

            ToGameJson(); 

            if (gameObject.name == "DataControllerF")
                GameObject.Find("DataControllerF").SetActive(false);
        }


    }

    IEnumerator SaveGameData()
    {
        while (true)
        {
            string path = Path.Combine(Application.dataPath, "Scripts/GameDataManagement/GameData.json");
            File.WriteAllText(path, JsonUtility.ToJson(gameData, true));
            try
            {
                SW = new System.IO.StreamWriter(path);
            }
            catch (Exception exp)
            {
                UnityEngine.Debug.Log(exp);
            }
            finally
            {
                if (SW != null)
                {
                    SW.Close();
                }
            }



            yield return new WaitForSeconds(0.5f);
        }

    }

    [System.Serializable]
    public class GameData
    {
        public bool playedBefore = false;
        public List<Character> CharacterList = new List<Character>();

    }

    [System.Serializable]
    public class Character
    {
        public Character(string _name, string _profile)
        {
            name = _name;
            profile = _profile;
        }

        public string name;
        public string profile;

    }
}