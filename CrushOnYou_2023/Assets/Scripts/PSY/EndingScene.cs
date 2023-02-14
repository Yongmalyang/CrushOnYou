using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class EndingScene : MonoBehaviour
{
    public GameObject dialogue;
    public GameObject TalkPanel;
    public GameObject NamePanel;
    public GameObject BackPanel;

    public GameObject red, green, blue, purple, pink, yellow;
    public List<GameObject> characters;
    public Sprite[] redImg, greenImg, blueImg, purpleImg, pinkImg, yellowImg;
    //캐릭터별 이미지 여러개일줄 알고 이렇게 했는데 신경안쓰셔도 됩니다...
    public List<Sprite[]> images;
    public Sprite[] Backgrounds;

    public TMP_Text endingType;

    void Awake()
    { 
        red = GameObject.FindGameObjectWithTag("red");
        green = GameObject.FindGameObjectWithTag("green");
        blue = GameObject.FindGameObjectWithTag("blue");
        purple = GameObject.FindGameObjectWithTag("purple");
        pink = GameObject.FindGameObjectWithTag("pink");
        yellow = GameObject.FindGameObjectWithTag("yellow");

        characters = new List<GameObject>{red, green, blue, purple, pink, yellow};
        
        redImg = Resources.LoadAll<Sprite>("RedImage");
        greenImg = Resources.LoadAll<Sprite>("GreenImage");
        blueImg = Resources.LoadAll<Sprite>("BlueImage");
        purpleImg = Resources.LoadAll<Sprite>("PurpleImage");
        pinkImg = Resources.LoadAll<Sprite>("PinkImage");
        yellowImg = Resources.LoadAll<Sprite>("YellowImage");

        images = new List<Sprite[]>{redImg, greenImg, blueImg, purpleImg, pinkImg, yellowImg};

        for(int i=0; i<characters.Count; i++){
            characters[i].SetActive(false);
        }

        Backgrounds = Resources.LoadAll<Sprite>("EndingBackgrounds"); //해당 폴더에 있는 사진들 저장

    }
    void Start()
    {
        int finalLover = DataController.Instance.gameData.finalLover;
        int endingNum = DataController.Instance.gameData.endingNum;

        DataController.Instance.gameData.turn = 0; //턴수 리셋
        
        if(endingNum != 6){ //최최악배드엔딩이 아닌 경우
            characters[finalLover].GetComponent<Image>().sprite = images[finalLover][0]; //최종러버 이미지 가져오기
            characters[finalLover].SetActive(true);//화면에 띄우기
        }

        BackPanel.GetComponent<Image>().sprite = Backgrounds[finalLover*2 + Random.Range(0,2)];
        //최종러버에 따라서 이미지 가져오기(리소스 폴더에 순서대로 담아놓음. 순서 바뀌면 안됨...)
        //ex)최종러버 옐로 -> (인덱스 5)*2 + 0 or 1 -> 10 or 11 번째에 있는 이미지 가져오기 

        endingType.text = $"엔딩 종류 : {endingNum}"; //확인용
        
    }

}
