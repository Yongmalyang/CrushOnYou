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

    public int[] loveWho; // ���� ������ �����ϴ���
    public int[] loveGauge; // ���� ������ �󸶳� �����ϴ���
    public int energy; // ���� ������
    public Character currentCharacter; // �÷��̾� ĳ����
    public int turn; // �ϼ�(�߸��� �Ϸ� ��ȭ Ƚ��)
    public int day = 1; // �߸��� ��¥


    
}
