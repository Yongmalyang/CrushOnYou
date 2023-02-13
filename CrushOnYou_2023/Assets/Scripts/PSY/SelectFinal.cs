using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectFinal : MonoBehaviour
{
    public int CharIndex;
    public GameObject EndingButton;
    public GameObject characters;
    List<int []> LoveList;

    void Start(){
        LoveList = DataController.Instance.gameData.LoveList;
    }
    public void Select() {

        DataController.Instance.gameData.finalLover = CharIndex; //선택한 캐릭터의 번호 저장
        
        int like = LoveList[DataController.Instance.gameData.finalLover][6];
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
            characters.SetActive(false);
            EndingButton.SetActive(true);
        
    }
}

