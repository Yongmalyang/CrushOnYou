using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharProfileforDialog : MonoBehaviour
{

    public static CharProfileforDialog instance;
    public struct Character
    {
        public string name;
        public string[] personality;
    }

    public Character red;
    public Character green;
    public Character blue;
    public Character purple;
    public Character pink;
    public Character yellow;
    public Character[] chars;

    private void Awake()
    {
        if (instance == null) instance = this;
        else if (instance != null) return;
        DontDestroyOnLoad(gameObject);
    }

    // Start is called before the first frame update
    void Start()
    {
        red.name = "������";
        red.personality = new string[] { "�ܼ���","������", "��������" };

        green.name = "������";
        green.personality = new string[] { "�������", "������", "������"};

        blue.name = "�׿�";
        blue.personality = new string[] { "��ö��", "������", "�ȶ���" };

        purple.name = "����";
        purple.personality = new string[] { "������", "������", "�ڽŸ��� ���谡 Ȯ����" };

        pink.name = "�ϳ�";
        pink.personality = new string[] { "�米����", "�峭�� ����", "�ֱ� ����" };

        yellow.name = "�ÿ�";
        yellow.personality = new string[] { "�糪�� ���̴�", "�������� ����", "��������" };

        chars = new Character[] { red, green, blue, purple, pink, yellow };

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
