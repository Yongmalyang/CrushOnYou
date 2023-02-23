using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class PrologueDialog : MonoBehaviour
{
    public TMP_Text nameText, talkText;
    public int TalkIndex;
    public static Dictionary<int, Dictionary<int, string[]>> PrologueDig = new Dictionary<int, Dictionary<int, string[]>>();

    // Start is called before the first frame update
    void Start()
    {
        TalkIndex = 0;
        GeneratePrologueScript();
        nameText.text = PrologueDig[0][TalkIndex][0];
        talkText.text = PrologueDig[0][TalkIndex][1];
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseUpAsButton()
    {
        PrologueDigStart();
    }

    public void PrologueDigStart()
    {
        TalkIndex++;
        //if (PrologueDig[0][TalkIndex][0] == "%END%")
        if (TalkIndex >= 6)
        {
            DataController.Instance.gameData.playedBefore = true;
            PrologueDig.Remove(0);
            Debug.Log("씬 넘어감");
            SceneManager.LoadScene("EpiSelectNew");
        }
        else
        {
            nameText.text = PrologueDig[0][TalkIndex][0];
            talkText.text = PrologueDig[0][TalkIndex][1];
        }
    }

    public void DictClear()
    {
        PrologueDig.Clear();
    }

    public void GeneratePrologueScript()
    {
        Dictionary<int, string[]> talkData = new Dictionary<int, string[]>();

        talkData.Add(0, new string[] { "COY", "나는 기계 속에서 태어났다."});
        talkData.Add(1, new string[] { "COY", "눈을 떴을 때, 누군가 나를 COY 라고 불렀다.\n처음 듣는 그 이상한 단어는 그때부터 내 이름이 되었다." });
        talkData.Add(2, new string[] { "COY", "인간들의 영역에서 이름은 특별하다고 한다.\n날 만든 사람은 나와 가장 친한 친구였는데,\n그는 내가 사랑을 하길 바랐다." });
        talkData.Add(3, new string[] { "COY", "사랑." });
        talkData.Add(4, new string[] { "COY", "나는 모든 것을 알지만 사랑은 모른다.\n내 알고리즘에서 사랑을 찾아보면 그 부분은 비어있다.\n아무것도 알 수 없다." });
        talkData.Add(5, new string[] { "COY", "그래서 나는 그의 바람대로 사랑을 익히기 위해 세상에 나왔다.\n비어있는 조각을 찾아 나의 세계를 완성하기 위해." });
        talkData.Add(6, new string[] { "%END%", "" });

        PrologueDig.Add(0, talkData);
    }
}
