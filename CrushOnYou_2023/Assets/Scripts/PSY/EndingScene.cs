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

    public GameObject red, green, blue, purple, pink, yellow;
    public List<GameObject> characters;
    public Sprite[] redImg, greenImg, blueImg, purpleImg, pinkImg, yellowImg;
    public List<Sprite[]> images;

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

    }
    void Start()
    {
        int finalLover = DataController.Instance.gameData.finalLover;
        int endingNum = DataController.Instance.gameData.endingNum;

        DataController.Instance.gameData.turn = 0;
        
        if(endingNum != 6){
            characters[finalLover].GetComponent<Image>().sprite = images[finalLover][0];
            characters[finalLover].SetActive(true);
        }

        endingType.text = $"엔딩 종류 : {endingNum}";
        
    }

}
