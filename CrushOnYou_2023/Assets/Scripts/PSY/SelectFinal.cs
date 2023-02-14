using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class SelectFinal : MonoBehaviour
{
    public int CharIndex; //캐릭터 인덱스
    public GameObject EndingButton;
    public GameObject characters;
    List<int []> LoveList;

    void Start(){
        LoveList = DataController.Instance.gameData.LoveList;
    }
    public void Select() { //후보 캐릭터 선택했을 때 실행되는 함수

        DataController.Instance.gameData.finalLover = CharIndex; //선택한 캐릭터의 번호 저장
        
        int like = LoveList[DataController.Instance.gameData.finalLover][6]; //선택한 캐릭터 호감도에 따라 엔딩 결정
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
            
            EndingButton.SetActive(true); //엔딩 화면으로 넘어가는 버튼
        
    }
}

