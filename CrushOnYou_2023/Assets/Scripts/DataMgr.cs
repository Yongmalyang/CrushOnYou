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
    public int[] loveGauge; // ���� ������ �󸶳� �����ϴ���
    public int coin; // 에너지
    public Character currentCharacter; // 현재 캐릭터

    
}
