using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;

public class EndingManager : MonoBehaviour
{
    public GameObject red, blue, green, purple, pink, yellow;
    List<GameObject> characters;

    public List<int []> LoveList;
    public List<int> tempLover;
    public List<int> favorites;
    public GameObject EndingButton;

    // Start is called before the first frame update
    void Start()
    {
        LoveList = DataController.Instance.gameData.LoveList;
        
        favorites = new List<int>();
        tempLover = new List<int>();
        characters = new List<GameObject>{red, green, blue, purple, pink, yellow};
        SetFavorites();
        SetTempLover();
        SetEnding();
    }

    void SetFavorites(){
        
        for(int i=0; i<6; i++){
            
            int max = 0;
            for(int j=0; j<7; j++){
                if(LoveList[i][j]>=LoveList[i][max]){
                    max = j;
                }
            }

            if(max == 6) favorites.Add(i);
        }

        Debug.Log(favorites.Count);
    }

    void SetTempLover(){

        if(favorites.Count == 0){
            DataController.Instance.gameData.finalLover = 6; //걍 배드
            DataController.Instance.gameData.endingNum = 6;
        }
        else{
            int max = 0;
            for(int i=0; i<favorites.Count; i++){
                
                //Debug.Log(favorites[i]);
                //Debug.Log(LoveList[max][6]);
                if(LoveList[favorites[i]][6] > LoveList[max][6]){
                    max = favorites[i];
                    tempLover.Clear();
                    tempLover.Add(favorites[i]);
                }
                else if(LoveList[favorites[i]][6] == LoveList[max][6]){
                    max = favorites[i];
                    tempLover.Add(favorites[i]);
                }
            }
        }

        Debug.Log(tempLover.Count);
    }

    void SetEnding(){
        if(tempLover.Count == 1){
            DataController.Instance.gameData.finalLover = tempLover[0];
            int like = LoveList[tempLover[0]][6];
            int endingNum;
            if(like < 50) endingNum = 6;
            else if(like>=50 && like<70){
                if(DataController.Instance.gameData.myLover == DataController.Instance.gameData.finalLover){
                    endingNum = 2;
                }
                else endingNum = 5;
            }
            else if(like>=70 && like<90){
                if(DataController.Instance.gameData.myLover == DataController.Instance.gameData.finalLover){
                    endingNum = 1;
                }
                else endingNum = 4;
            }
            else{
                if(DataController.Instance.gameData.myLover == DataController.Instance.gameData.finalLover){
                    endingNum = 0;
                }
                else endingNum = 3;
            }

            DataController.Instance.gameData.endingNum = endingNum;
            Debug.Log(endingNum);
        }
        else if(tempLover.Count == 0) return;
        else{
            EndingButton.SetActive(false);
            for(int i=0; i<characters.Count; i++){
                if(tempLover.Contains(i)){
                    characters[i].SetActive(true);
                }
            }
        }
    }

    public void LoadEnding(){
        SceneManager.LoadScene("Ending_PSY");
    }



}
