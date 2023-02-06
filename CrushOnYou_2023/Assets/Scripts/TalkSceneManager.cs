using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using TMPro;

//수정함

public class TalkSceneManager : MonoBehaviour
{
    public GameObject DialogueObj;
    public GameObject Btns; //키워드 버튼 4개

    class Keyword //키워드, 키워드를 좋아하는 캐릭터 번호
    {
        public string category;
        public string word;
        public bool[] like;
    }

    List<Keyword> Keywords = new List<Keyword>() //임의로 설정함 수정 필요
    {
        new Keyword(){category = "special", word = "운동", like = new bool[6]{true, true, true, true, true, true}},
        new Keyword(){category = "special", word = "필름 카메라", like = new bool[6]{true, true, true, true, true, true}},
        new Keyword(){category = "special", word = "인디 음악", like = new bool[6]{true, true, true, true, true, true}},
        new Keyword(){category = "special", word = "클래식 음악", like = new bool[6]{true, true, true, true, true, true}},
        new Keyword(){category = "special", word = "드라마", like = new bool[6]{true, true, true, true, true, true}},
        new Keyword(){category = "special", word = "노래방", like = new bool[6]{true, true, true, true, true, true}},

        new Keyword(){category = "hobby", word = "별 보기", like = new bool[6]{true, true, true, true, true, true}},
        new Keyword(){category = "hobby", word = "영화 감상", like = new bool[6]{true, true, true, true, true, true}},
        new Keyword(){category = "hobby", word = "산책", like = new bool[6]{true, true, true, true, true, true}},
        new Keyword(){category = "hobby", word = "스포츠 경기 직관", like = new bool[6]{true, true, true, true, true, true}},
        new Keyword(){category = "hobby", word = "게임", like = new bool[6]{true, true, true, true, true, true}},
        new Keyword(){category = "hobby", word = "요리", like = new bool[6]{true, true, true, true, true, true}},

        new Keyword(){category = "issue", word = "환경문제", like = new bool[6]{true, true, true, true, true, true}},
        new Keyword(){category = "issue", word = "경제", like = new bool[6]{true, true, true, true, true, true}},
        new Keyword(){category = "issue", word = "연예인", like = new bool[6]{true, true, true, true, true, true}},
        new Keyword(){category = "issue", word = "베스트셀러", like = new bool[6]{true, true, true, true, true, true}},
        new Keyword(){category = "issue", word = "패션 트렌드", like = new bool[6]{true, true, true, true, true, true}},
        new Keyword(){category = "issue", word = "SNS", like = new bool[6]{true, true, true, true, true, true}},

        new Keyword(){category = "school", word = "학교 수업", like = new bool[6]{true, true, true, true, true, true}},
        new Keyword(){category = "school", word = "수행평가", like = new bool[6]{true, true, true, true, true, true}},
        new Keyword(){category = "school", word = "시험공부", like = new bool[6]{true, true, true, true, true, true}},
        new Keyword(){category = "school", word = "급식", like = new bool[6]{true, true, true, true, true, true}},
        new Keyword(){category = "school", word = "점심시간", like = new bool[6]{true, true, true, true, true, true}},
        new Keyword(){category = "school", word = "선생님", like = new bool[6]{true, true, true, true, true, true}},

        new Keyword(){category = "life", word = "어젯밤 꿈", like = new bool[6]{true, true, true, true, true, true}},
        new Keyword(){category = "life", word = "맛집", like = new bool[6]{true, true, true, true, true, true}},
        new Keyword(){category = "life", word = "반려동물", like = new bool[6]{true, true, true, true, true, true}},
        new Keyword(){category = "life", word = "플레이리스트", like = new bool[6]{true, true, true, true, true, true}},
        new Keyword(){category = "life", word = "위시리스트", like = new bool[6]{true, true, true, true, true, true}},
        new Keyword(){category = "life", word = "TMI", like = new bool[6]{true, true, true, true, true, true}},
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
            case "Kw1" : ManageLove(0); DialogueObj.SetActive(false); break;
            case "Kw2" : ManageLove(1); DialogueObj.SetActive(false); break;
            case "Kw3" : ManageLove(2); DialogueObj.SetActive(false); break;
            case "Kw4" : ManageLove(3); DialogueObj.SetActive(false); break;
        }
        Btns.SetActive(false); //버튼 한번 누르면 비활성화
    }

    void ManageLove(int i){ //호감도 조정하는 함수

        int key = i; //사용자가 누른 버튼 번호 ex) toShow[i].ch -> 해당 키워드를 좋아하는 캐릭터
        List<int[]> LoveList = DataManager.Data.LoveList;

        switch(ppHere.Count){
            case 1 :  //장소에 한 명 있음          
                    if(toShow[i].like[ppHere[0]] == true){ //선택한 키워드가 같이있는 사람이 좋아하는 키워드
                        LoveList[ppHere[0]][6] += 10; //호감도 증가
                        if(LoveList[ppHere[0]][6] > 100) LoveList[ppHere[0]][6] = 100;
                    }
                    else{ //선택한 키워드가 안좋아하는 키워드
                        LoveList[ppHere[0]][6] -= 10; //호감도 감소
                        if(LoveList[ppHere[0]][6] < 0) LoveList[ppHere[0]][6] = 0;
                    }
                    break;

            case 2 : //장소에 두 명 있음
                    if(toShow[i].like[ppHere[0]] && toShow[i].like[ppHere[1]]){ //둘 다 좋아하는 키워드
                        LoveList[ppHere[0]][6] += 10; //나를 향한 호감도 증가
                        if(LoveList[ppHere[0]][6] > 100) LoveList[ppHere[0]][6] = 100;

                        LoveList[ppHere[0]][ppHere[1]] +=10; //다른 캐릭터를 향한 호감도 증가
                        if(LoveList[ppHere[0]][ppHere[1]] > 100) LoveList[ppHere[0]][ppHere[1]] = 100;
                    
                        LoveList[ppHere[1]][6] +=10;
                        if(LoveList[ppHere[1]][6] > 100) LoveList[ppHere[0]][6] = 100;

                        LoveList[ppHere[1]][ppHere[0]] +=10;
                        if(LoveList[ppHere[1]][ppHere[0]] > 100) LoveList[ppHere[1]][ppHere[0]] = 100;
                    }
                    else if(toShow[i].like[ppHere[0]] && !toShow[i].like[ppHere[1]]){ //첫번째 사람만 좋아하는 키워드 
                        LoveList[ppHere[0]][6] += 10;
                        if(LoveList[ppHere[0]][6] > 100) LoveList[ppHere[0]][6] = 100; 
                        LoveList[ppHere[0]][ppHere[1]] +=10;
                        if(LoveList[ppHere[0]][ppHere[1]] > 100) LoveList[ppHere[0]][ppHere[1]] = 100;
                    
                        LoveList[ppHere[1]][6] -=10;
                        if(LoveList[ppHere[1]][6] <0 ) LoveList[ppHere[1]][6] = 0;
                        LoveList[ppHere[1]][ppHere[0]] -=10;
                        if(LoveList[ppHere[1]][ppHere[0]] <0 ) LoveList[ppHere[1]][ppHere[0]] = 0;
                    }
                    else if(!toShow[i].like[ppHere[0]] && toShow[i].like[ppHere[1]]){ //두번째 사람만 좋아하는 키워드
                        LoveList[ppHere[1]][6] += 10;
                        if(LoveList[ppHere[1]][6] > 100) LoveList[ppHere[1]][6] = 100; 
                        LoveList[ppHere[1]][ppHere[0]] +=10;
                        if(LoveList[ppHere[1]][ppHere[0]] > 100) LoveList[ppHere[1]][ppHere[0]] = 100;
                    
                        LoveList[ppHere[0]][6] -=10;
                        if(LoveList[ppHere[0]][6] <0 ) LoveList[ppHere[0]][6] = 0;
                        LoveList[ppHere[0]][ppHere[1]] -=10;
                        if(LoveList[ppHere[0]][ppHere[1]] <0 ) LoveList[ppHere[0]][ppHere[1]] = 0;
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
