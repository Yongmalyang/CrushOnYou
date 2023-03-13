using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum Card
{
    card1, card2, card3
}


public class SelectMgr : MonoBehaviour
{
    public static SelectMgr instance;

    private void Awake()
    {
        if (instance == null) instance = this;
        else if (instance != null) return;
        DontDestroyOnLoad(gameObject);
    }

    public int Qnum;
    public int energy; // ���� ������
    
    public Card currentCard; // �÷��̾� ĳ����

}


