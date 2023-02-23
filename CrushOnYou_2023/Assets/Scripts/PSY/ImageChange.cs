using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ImageChange : MonoBehaviour
{
    public GameObject red, green, blue, purple, pink, yellow;
    public List<GameObject> characters;
    public Sprite[] redImg, greenImg, blueImg, purpleImg, pinkImg, yellowImg;
    public List<Sprite[]> images;
    public bool isIntro = true;

    // Start is called before the first frame update
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

    public void SetImage(int pp, bool like){
        for(int i=0; i<characters.Count; i++){
            characters[i].SetActive(false);
        }

        if(isIntro){
            characters[pp].GetComponent<Image>().sprite = images[pp][0];
            characters[pp].SetActive(true);
            return;
        }

        if(pp<characters.Count){
            characters[pp].SetActive(true);

            if(like){
                characters[pp].GetComponent<Image>().sprite = images[pp][1];
            }
            else{
                characters[pp].GetComponent<Image>().sprite = images[pp][2];
            }
        }

    }

}
