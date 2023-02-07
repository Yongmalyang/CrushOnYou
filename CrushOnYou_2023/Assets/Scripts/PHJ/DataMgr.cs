using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum Character
{
    red, green, blue, purple, pink
}

public class DataMgr : MonoBehaviour
{
    public static DataMgr instance;
    private void Awake()
    {
        if(instance == null) instance=this;
        else if(instance != null) return;
        DontDestroyOnLoad(gameObject);
    }

    public int[] loveWho; // 누가 누구를 좋아하는지
    public int[] loveGauge; // 누가 누구를 얼마나 좋아하는지
    public int energy; // 보유 에너지
    public Character currentCharacter; // 플레이어 캐릭터
    public int turn; // 턴수(추리턴 하루 대화 횟수)
    public int day = 1; // 추리턴 날짜


    
}
