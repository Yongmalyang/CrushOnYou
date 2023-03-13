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
        red.name = "가영이";
        red.personality = new string[] { "단순한","솔직한", "열정적인" };

        green.name = "서준이";
        green.personality = new string[] { "어른스러운", "다정한", "신중한"};

        blue.name = "테오";
        blue.personality = new string[] { "냉철한", "예민한", "똑똑한" };

        purple.name = "유이";
        purple.personality = new string[] { "차분한", "차가운", "자신만의 세계가 확고한" };

        pink.name = "하나";
        pink.personality = new string[] { "사교적인", "장난기 많은", "애교 많은" };

        yellow.name = "시우";
        yellow.personality = new string[] { "사나워 보이는", "수줍음이 많은", "감성적인" };

        chars = new Character[] { red, green, blue, purple, pink, yellow };

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
