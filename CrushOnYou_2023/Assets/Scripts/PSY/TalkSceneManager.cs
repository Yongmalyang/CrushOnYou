using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using TMPro;

public class TalkSceneManager : MonoBehaviour
{
    public GameObject Btns; //키워드 버튼 4개
    class Keyword //키워드, 키워드를 좋아하는 캐릭터 번호
    {
        public string word;
        public int ch;
    }

    List<Keyword> Keywords = new List<Keyword>() //임의로 설정함 수정 필요
    {
        new Keyword(){word = "A1", ch = 0},
        new Keyword(){word = "A2", ch = 0},
        new Keyword(){word = "B1", ch = 1},
        new Keyword(){word = "B2", ch = 1},
        new Keyword(){word = "C1", ch = 2},
        new Keyword(){word = "C2", ch = 2},
        new Keyword(){word = "D1", ch = 3},
        new Keyword(){word = "D2", ch = 3},
        new Keyword(){word = "E1", ch = 4},
        new Keyword(){word = "E2", ch = 4},
        new Keyword(){word = "F1", ch = 5},
        new Keyword(){word = "F2", ch = 5},
    };

    public TMP_Text kw1;
    public TMP_Text kw2;
    public TMP_Text kw3;
    public TMP_Text kw4;

    List<Keyword> toShow = new List<Keyword>(); //선택된 4개 키워드 리스트

    List<int> ppHere = new List<int>(); 
    //해당 장소에 있는 사람(0:red, 1:green, 2:blue, 3:yellow, 4:pink, 5:purple)

    void Start()
    {
        ManageKeyword();
        WhoAreHere();
        kw1.text = toShow[0].word;
        kw2.text = toShow[1].word;
        kw3.text = toShow[2].word;
        kw4.text = toShow[3].word;
    }

    void WhoAreHere(){ //해당 장소에 있는 캐릭터 찾아서 ppHere에 저장
        for(int i=0; i<6; i++){
            if(DataManager.Data.place[i] == DataManager.Data.myPlace){
                ppHere.Add(i);
            }
        }
    }

    void ManageKeyword(){ //키워드 중복없이 4개 선정
        for(int i=0; i<4; i++){
            while(true){
                int temp = Random.Range(0, Keywords.Count);
                if(!toShow.Contains(Keywords[temp])){
                    toShow.Add(Keywords[temp]);
                    break;
                }
            }
        }
    }

    public void SelectKeyword(){ //사용자가 키워드 버튼 눌렀을 때
        string ButtonName = EventSystem.current.currentSelectedGameObject.name;
        switch(ButtonName){
            case "Kw1" : ManageLove(0); break;
            case "Kw2" : ManageLove(1); break;
            case "Kw3" : ManageLove(2); break;
            case "Kw4" : ManageLove(3); break;
        }
        Btns.SetActive(false); //버튼 한번 누르면 비활성화
    }

    void ManageLove(int i){ //호감도 조정하는 함수

        int key = i; //사용자가 누른 버튼 번호 ex) toShow[i].ch -> 해당 키워드를 좋아하는 캐릭터
        List<int[]> LoveList = DataManager.Data.LoveList;

        switch(ppHere.Count){
            case 1 :            
                    if(toShow[i].ch == ppHere[0]){ //선택한 키워드가 같이있는 사람이 좋아하는 키워드
                        LoveList[ppHere[0]][6] += 10; //호감도 증가

                    }
                    else{ //선택한 키워드가 안좋아하는 키워드
                        LoveList[ppHere[0]][6] -= 10; //호감도 감소
                    }
                    break;

            case 2 :
                    if(toShow[i].ch == ppHere[0]){ //선택한 키워드가 같이있는 사람이 좋아하는 키워드
                        LoveList[ppHere[0]][6] += 10; //나를 향한 호감도 증가
                        LoveList[ppHere[0]][ppHere[1]] +=10; //다른 캐릭터를 향한 호감도 증가
                    
                        LoveList[ppHere[1]][6] -=10;
                        LoveList[ppHere[1]][ppHere[0]] -=10;
                    }
                    else if(toShow[i].ch == ppHere[1]){ 
                        LoveList[ppHere[1]][6] += 10; 
                        LoveList[ppHere[1]][ppHere[0]] +=10;
                    
                        LoveList[ppHere[0]][6] -=10;
                        LoveList[ppHere[0]][ppHere[1]] -=10;
                    }
                    else{ //둘다 안좋아하는 키워드
                        LoveList[ppHere[1]][6] -=10;
                        LoveList[ppHere[1]][ppHere[0]] -=10;

                        LoveList[ppHere[0]][6] -=10;
                        LoveList[ppHere[0]][ppHere[1]] -=10;
                    }

            break;
        }

        DataManager.Data.LoveList = LoveList;
    }
    
}
