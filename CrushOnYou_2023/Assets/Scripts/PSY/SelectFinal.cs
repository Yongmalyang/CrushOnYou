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
        
        int like = LoveList[DataController.Instance.gameData.finalLover][6]; 
        //0:배드A, 1:배드B, 2:노멀A, 3:노멀B, 4:진엔딩
        int endingNum;

        if (DataController.Instance.gameData.myLover == DataController.Instance.gameData.finalLover) //내가 선택한 친구면
        {
            if (like >= 100)
            {
                endingNum = 4;
                DataController.Instance.gameData.endingNum = endingNum;
                Debug.Log(endingNum);
            }
            else
            {
                endingNum = 2;
                DataController.Instance.gameData.endingNum = endingNum;
                Debug.Log(endingNum);
            }
        }
        else
        {
            endingNum = 3;
            DataController.Instance.gameData.endingNum = endingNum;
            Debug.Log(endingNum);
        }
     
            
            EndingButton.SetActive(true); //엔딩 화면으로 넘어가는 버튼
        
    }
}

