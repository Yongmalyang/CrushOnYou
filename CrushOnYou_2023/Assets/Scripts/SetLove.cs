using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetLove : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
            setLoveList();
        
        
    }

    public void setLoveList()
    { //0213 추가 공략턴 호감도 생성 함수

        DataController.Instance.gameData.RedLove = new int[7] { 0, 0, 0, 0, 0, 0, 0 };

        DataController.Instance.gameData.GreenLove = new int[7]{0,0,0,0,0,0,0};
        DataController.Instance.gameData.BlueLove = new int[7]{0,0,0,0,0,0,0};
        DataController.Instance.gameData.PurpleLove = new int[7]{0,0,0,0,0,0,0};
        DataController.Instance.gameData.PinkLove = new int[7]{0,0,0,0,0,0,0};
        DataController.Instance.gameData.YellowLove = new int[7]{0,0,0,0,0,0,0};
        DataController.Instance.gameData.CoyLove = new int[7]{0,0,0,0,0,0,0};

        //ooLove = oo의 인덱스 0:red 1:green 2:blue 3:purple 4:pink 5:yellow 6:me 을 향한 호감도
        //ex) RedLove가 {0,10,20,30,40,50,60}일 때 레드의 나를 향한 호감도는 60

        DataController.Instance.gameData.LoveList.Insert(0, DataController.Instance.gameData.RedLove);
        DataController.Instance.gameData.LoveList.Insert(1, DataController.Instance.gameData.GreenLove);
        DataController.Instance.gameData.LoveList.Insert(2, DataController.Instance.gameData.BlueLove);
        DataController.Instance.gameData.LoveList.Insert(3, DataController.Instance.gameData.PurpleLove);
        DataController.Instance.gameData.LoveList.Insert(4, DataController.Instance.gameData.PinkLove);
        DataController.Instance.gameData.LoveList.Insert(5, DataController.Instance.gameData.YellowLove);
        DataController.Instance.gameData.LoveList.Insert(6, DataController.Instance.gameData.CoyLove);

        for(int i=0; i<6; i++){
            for(int j=0; j<7; j++){
                DataController.Instance.gameData.LoveList[i][j] = UnityEngine.Random.Range(2,6)*10;
            }
            DataController.Instance.gameData.LoveList[i][i] = 0;
            if(DataController.Instance.gameData.loveWho[i] != 7){
                DataController.Instance.gameData.LoveList[i][DataController.Instance.gameData.loveWho[i]] = UnityEngine.Random.Range(6,8)*10;
            }
        }
    }
}
