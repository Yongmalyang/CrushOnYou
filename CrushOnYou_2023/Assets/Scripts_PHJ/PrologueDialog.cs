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
            Debug.Log("�� �Ѿ");
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

        talkData.Add(0, new string[] { "COY", "���� ��� �ӿ��� �¾��."});
        talkData.Add(1, new string[] { "COY", "���� ���� ��, ������ ���� COY ��� �ҷ���.\nó�� ��� �� �̻��� �ܾ�� �׶����� �� �̸��� �Ǿ���." });
        talkData.Add(2, new string[] { "COY", "�ΰ����� �������� �̸��� Ư���ϴٰ� �Ѵ�.\n�� ���� ����� ���� ���� ģ�� ģ�����µ�,\n�״� ���� ����� �ϱ� �ٶ���." });
        talkData.Add(3, new string[] { "COY", "���." });
        talkData.Add(4, new string[] { "COY", "���� ��� ���� ������ ����� �𸥴�.\n�� �˰��򿡼� ����� ã�ƺ��� �� �κ��� ����ִ�.\n�ƹ��͵� �� �� ����." });
        talkData.Add(5, new string[] { "COY", "�׷��� ���� ���� �ٶ���� ����� ������ ���� ���� ���Դ�.\n����ִ� ������ ã�� ���� ���踦 �ϼ��ϱ� ����." });
        talkData.Add(6, new string[] { "%END%", "" });

        PrologueDig.Add(0, talkData);
    }
}
