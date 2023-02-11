using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataManager : MonoBehaviour
{
    // 수정함!!

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

    public int[] loveWho; //추리턴에서 받아와야됨!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!

    public List<int[]> LoveList = new List<int[]>(); //호감도 저장 리스트

#region 
    public int[] RedLove; 
    public int[] GreenLove;
    public int[] BlueLove;
    public int[] PurpleLove;
    public int[] PinkLove;
    public int[] YellowLove;
#endregion
    void setLove(){

        RedLove = new int[7]{0,0,0,0,0,0,0};
        GreenLove = new int[7]{0,0,0,0,0,0,0};
        BlueLove = new int[7]{0,0,0,0,0,0,0};
        PurpleLove = new int[7]{0,0,0,0,0,0,0};
        PinkLove = new int[7]{0,0,0,0,0,0,0};
        YellowLove = new int[7]{0,0,0,0,0,0,0};

    //ooLove = oo의 인덱스 0:red 1:green 2:blue 3:yellow 4:pink 5:purple 6:me 을 향한 호감도

        LoveList.Add(RedLove); 
        LoveList.Add(GreenLove);
        LoveList.Add(BlueLove);
        LoveList.Add(PurpleLove);
        LoveList.Add(PinkLove);
        LoveList.Add(YellowLove);

        for(int i=0; i<6; i++){
            for(int j=0; j<7; j++){
                LoveList[i][j] = Random.Range(2,6)*10;
            }
            LoveList[i][i] = 0;
            if(loveWho[i] != 7){
                LoveList[i][loveWho[i]] = Random.Range(6,8)*10;
            }
        }
    }

}
