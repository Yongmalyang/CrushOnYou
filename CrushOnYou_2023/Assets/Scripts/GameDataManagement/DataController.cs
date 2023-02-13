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
    public static DataController Instance  //해당 스크립트를 어디에서든 불러올 수 있게끔 하는 함수 
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

        setLove(); //0213 추가

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

    void setLove(){ //0213 추가 공략턴 호감도 생성

        this.gameData.RedLove = new int[7]{0,0,0,0,0,0,0};
        this.gameData.GreenLove = new int[7]{0,0,0,0,0,0,0};
        this.gameData.BlueLove = new int[7]{0,0,0,0,0,0,0};
        this.gameData.PurpleLove = new int[7]{0,0,0,0,0,0,0};
        this.gameData.PinkLove = new int[7]{0,0,0,0,0,0,0};
        this.gameData.YellowLove = new int[7]{0,0,0,0,0,0,0};

    //ooLove = oo의 인덱스 0:red 1:green 2:blue 3:purple 4:pink 5:yellow 6:me 을 향한 호감도

        this.gameData.LoveList.Add(DataController.Instance.gameData.RedLove); 
        this.gameData.LoveList.Add(DataController.Instance.gameData.GreenLove);
        this.gameData.LoveList.Add(DataController.Instance.gameData.BlueLove);
        this.gameData.LoveList.Add(DataController.Instance.gameData.PurpleLove);
        this.gameData.LoveList.Add(DataController.Instance.gameData.PinkLove);
        this.gameData.LoveList.Add(DataController.Instance.gameData.YellowLove);

        for(int i=0; i<6; i++){
            for(int j=0; j<7; j++){
                this.gameData.LoveList[i][j] = UnityEngine.Random.Range(2,6)*10;
            }
            this.gameData.LoveList[i][i] = 0;
            if(this.gameData.loveWho[i] != 7){
                this.gameData.LoveList[i][this.gameData.loveWho[i]] = UnityEngine.Random.Range(6,8)*10;
            }
        }
    }

    [System.Serializable]
    public class GameData
    {
        public bool playedBefore = false;
        public List<Character> CharacterList = new List<Character>();

#region 0213추가 공략턴 데이터
        public int myLover; //내가 공략할 사람
        public int myPlace; //내가 선택한 장소
        public int maxTurn; //최대 턴(14)
        public int turn; //현재 턴
        public int[] place; //캐릭터별 장소
        public int[] count; //장소별
        public int finalLover; //최종 이어질 사람
        public int endingNum; //엔딩 종류 
        //0:선택한사람+해피 1:선택한사람+노말 2:선택한사람+새드 3: 선택x+해피 4:선택x+노말 5:선택x+새드 6:아무도날안좋아함

        public int[] loveWho; //임시로 넣음 추리턴에서 받아와야됨!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!

        public List<int[]> LoveList = new List<int[]>(); //호감도 저장 리스트

        public int[] RedLove; 
        public int[] GreenLove;
        public int[] BlueLove;
        public int[] PurpleLove;
        public int[] PinkLove;
        public int[] YellowLove;
#endregion

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