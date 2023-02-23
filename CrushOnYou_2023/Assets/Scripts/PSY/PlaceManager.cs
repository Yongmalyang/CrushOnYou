using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlaceManager : MonoBehaviour
{
    public GameObject BackPanel;
    public Sprite[] Backgrounds;
    //private GameObject CamObject;

    // Start is called before the first frame update
    void Awake()
    {
        if(DataController.Instance.gameData.maxTurn == DataController.Instance.gameData.turn){ 
            SceneManager.LoadScene("SelectFinal_PSY");
        }//14턴 진행하면 엔딩화면으로 이동
        whereToGo();
        Backgrounds = Resources.LoadAll<Sprite>("PlaceSceneBack");
        ManageFromTurn();
        //CamObject = GameObject.Find("Main Camera");
    }

    void whereToGo(){
        
        int[] place = new int[6]; 
        //red, green, blue, purple, pink, yellow 순서
        //0:교실, 1:복도, 2:도서관, 3:음악실, 4:미술실, 5:체육관
        
        int[] count = new int[6] {0,0,0,0,0,0};

        for(int i = 0; i<place.Length; i++){

            while(true){
                place[i] = Random.Range(0, place.Length); //랜덤으로 장소 결정
                if(count[place[i]]<2){ //한 장소에 2명 이상 못가게
                    count[place[i]]++;
                    break;
                }
            }
            
        }
        DataController.Instance.gameData.count = count;
        DataController.Instance.gameData.place = place;
    }
    void ManageFromTurn(){
        
        if(DataController.Instance.gameData.turn<5){
            BackPanel.GetComponent<Image>().sprite = Backgrounds[0];
            Debug.Log("실행1");
            //CamObject.GetComponent<MusicOperator>().PlayBGM("D-15");
        }
        else if(DataController.Instance.gameData.turn<10){
            BackPanel.GetComponent<Image>().sprite = Backgrounds[1];
            Debug.Log("실행2");
            //CamObject.GetComponent<MusicOperator>().PlayBGM("D-10");
        }
        else{
            BackPanel.GetComponent<Image>().sprite = Backgrounds[2];
            Debug.Log("실행2");
            //CamObject.GetComponent<MusicOperator>().PlayBGM("D-10");

        }
    }

}
