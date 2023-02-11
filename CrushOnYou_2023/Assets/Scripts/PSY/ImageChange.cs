using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ImageChange : MonoBehaviour
{
    public GameObject red, green, blue, yellow, pink, purple;
    public List<GameObject> characters;
    public Sprite[] redImg, greenImg, blueImg, yellowImg, pinkImg, purpleImg;
    public List<Sprite[]> images;

    // Start is called before the first frame update
    void Start()
    {
        red = GameObject.FindGameObjectWithTag("red");
        green = GameObject.FindGameObjectWithTag("green");
        blue = GameObject.FindGameObjectWithTag("blue");
        purple = GameObject.FindGameObjectWithTag("purple");
        pink = GameObject.FindGameObjectWithTag("pink");
        yellow = GameObject.FindGameObjectWithTag("yellow");

        characters = new List<GameObject>{red, green, blue, yellow, pink, purple};
        
        redImg = Resources.LoadAll<Sprite>("RedImage");
        greenImg = Resources.LoadAll<Sprite>("GreenImage");
        blueImg = Resources.LoadAll<Sprite>("BlueImage");
        yellowImg = Resources.LoadAll<Sprite>("YellowImage");
        pinkImg = Resources.LoadAll<Sprite>("PinkImage");
        purpleImg = Resources.LoadAll<Sprite>("PurpleImage");

        images = new List<Sprite[]>{redImg, greenImg, blueImg, yellowImg, pinkImg, purpleImg};

        for(int i=0; i<characters.Count; i++){
            characters[i].SetActive(false);
        }
    }

    public void SetImage(int pp, bool like){
        for(int i=0; i<characters.Count; i++){
            characters[i].SetActive(false);
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
