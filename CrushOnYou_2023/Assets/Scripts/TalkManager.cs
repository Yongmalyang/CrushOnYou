using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TalkManager : MonoBehaviour
{
    public static int ppToTalk; //말하기로 선택한 캐릭터의 인덱스
    public GameObject talkPanel;
    public TMP_Text TalkText;
    public bool isAction;
    public int talkIndex;
    static int id;
    
    Dictionary<int, List<string>> talkData;

    void Awake() {
        talkData = new Dictionary<int, List<string>>();
        GenerateData();
    }

    void Start() {
        talkPanel.SetActive(isAction);
    }
    void GenerateData()
    {
        switch(ppToTalk){

            case 0 :
                    talkData.Add(0, ScriptManager.Red[0][Random.Range(0,2)]);
                    talkData.Add(1, ScriptManager.Red[1][0]);
                    talkData.Add(2, ScriptManager.Red[2][Random.Range(0,2)]);
                    break;
            case 2 :
                    talkData.Add(0, ScriptManager.Blue[0][Random.Range(0,2)]);
                    talkData.Add(1, ScriptManager.Blue[1][0]);
                    talkData.Add(2, ScriptManager.Blue[2][Random.Range(0,2)]);
                    break;
            default:
                    talkData.Add(0, ScriptManager.Red[0][Random.Range(0,2)]);
                    talkData.Add(1, ScriptManager.Red[1][0]);
                    talkData.Add(2, ScriptManager.Red[2][Random.Range(0,2)]);
                    break;
            //레드, 블루 말고 다른 캐릭터 추가 해야함            

        }

    }
    
    public void setID(int btnid){ //버튼 종류 저장
        id = btnid;
    }
    public void Action() //대사창 클릭할 때마다 실행
    {
        Talk(id);   
        talkPanel.SetActive(isAction);
    }

    void Talk(int id){ //대사 띄우고 대사 끝났는지 안끝났는지 확인

        string talkData = GetTalk(id, talkIndex);
        
        if(talkData == null)
        {
            isAction = false;
            talkIndex = 0;
            return;
        }

        TalkText.text = talkData;
        isAction = true;
        talkIndex++;
    }

    public string GetTalk(int id, int talkIndex){ //버튼 종류에 따라 대사 가져오기
        if(talkIndex == talkData[id].Count)
            return null;
        else 
            return talkData[id][talkIndex];
    }
}
