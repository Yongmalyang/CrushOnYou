using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataManager : MonoBehaviour
{
    public static DataManager Data;
    private void Awake() {

        setLove();
        if(Data == null){
            Data = this;
        }
        else if(Data != null) return;
        DontDestroyOnLoad(gameObject);
    }

    public int myLover; //내가 공략할 사람
    public int myPlace; //내가 선택한 장소
    public int maxTurn; //최대 턴(14)
    public int turn; //현재 턴
    public int[] place; //캐릭터별 장소
    public int[] count; //장소별 인원수

    public List<int[]> LoveList = new List<int[]>(); //호감도 저장 리스트

#region 
    public int[] RedLove; 
    public int[] GreenLove;
    public int[] BlueLove;
    public int[] YellowLove;
    public int[] PinkLove;
    public int[] PurpleLove;
#endregion
    void setLove(){ //임의로 설정, 나중에 랜덤으로 수정 필요
   
    //ooLove = oo의 인덱스 0:red 1:green 2:blue 3:yellow 4:pink 5:purple 을 향한 호감도

        RedLove = new int[7]{0,70,20,20,20,20,20};
        GreenLove = new int[7]{20,0,70,20,20,20,20};
        BlueLove = new int[7]{20,20,0,70,20,20,20};
        YellowLove = new int[7]{20,20,20,0,70,20,20};
        PinkLove = new int[7]{20,20,20,20,0,70,20};
        PurpleLove = new int[7]{20,20,20,20,20,0,70};

        LoveList.Add(RedLove); 
        LoveList.Add(GreenLove);
        LoveList.Add(BlueLove);
        LoveList.Add(YellowLove);
        LoveList.Add(PinkLove);
        LoveList.Add(PurpleLove);
    }

}
