using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class EndingScene : MonoBehaviour
{
    public GameObject dialogue;
    public GameObject TalkPanel;
    public GameObject NamePanel;
    public GameObject BackPanel;
    public GameObject BadEnding;

    public GameObject CreditBtn;

    public GameObject red, green, blue, purple, pink, yellow;
    public List<GameObject> characters;
    public Sprite[] redImg, greenImg, blueImg, purpleImg, pinkImg, yellowImg;
    //캐릭터별 이미지 여러개일줄 알고 이렇게 했는데 신경안쓰셔도 됩니다...
    public List<Sprite[]> images;
    public Sprite[] Backgrounds;

    public TMP_Text endingType;
    public TMP_Text TalkText;
    public TMP_Text NameText;

    public int TalkIndex;

    public static Dictionary<int, Dictionary<int, string[]>> EndingDig = new Dictionary<int, Dictionary<int, string[]>>();

    void Awake()
    { 
        red = GameObject.FindGameObjectWithTag("red");
        green = GameObject.FindGameObjectWithTag("green");
        blue = GameObject.FindGameObjectWithTag("blue");
        purple = GameObject.FindGameObjectWithTag("purple");
        pink = GameObject.FindGameObjectWithTag("pink");
        yellow = GameObject.FindGameObjectWithTag("yellow");

        characters = new List<GameObject>{red, green, blue, purple, pink, yellow};
        
        redImg = Resources.LoadAll<Sprite>("RedImage");
        greenImg = Resources.LoadAll<Sprite>("GreenImage");
        blueImg = Resources.LoadAll<Sprite>("BlueImage");
        purpleImg = Resources.LoadAll<Sprite>("PurpleImage");
        pinkImg = Resources.LoadAll<Sprite>("PinkImage");
        yellowImg = Resources.LoadAll<Sprite>("YellowImage");

        images = new List<Sprite[]>{redImg, greenImg, blueImg, purpleImg, pinkImg, yellowImg};

        for(int i=0; i<characters.Count; i++){
            characters[i].SetActive(false);
        }

        Backgrounds = Resources.LoadAll<Sprite>("EndingBackgrounds"); //해당 폴더에 있는 사진들 저장

    }
    void Start()
    {
        int finalLover = DataController.Instance.gameData.finalLover;
        int endingNum = DataController.Instance.gameData.endingNum;

        DataController.Instance.gameData.turn = 0; //턴수 리셋

        GenerateEndingScript(endingNum, finalLover);

        TalkIndex = 0;
        NameText.text = EndingDig[0][TalkIndex][0];
        TalkText.text = EndingDig[0][TalkIndex][1];

        if (endingNum != 1)
        { //최최악배드엔딩이 아닌 경우
            if (endingNum == 2)
            {
                BackPanel.GetComponent<Image>().sprite = Backgrounds[DataController.Instance.gameData.finalLover + 6];

            }
            else if(endingNum == 3)
            {
                BackPanel.GetComponent<Image>().sprite = Backgrounds[DataController.Instance.gameData.finalLover];

            }
            else if(endingNum == 4)
            {
                BackPanel.GetComponent<Image>().sprite = Backgrounds[finalLover + 6];
            }
                        
        }
        else{
            BackPanel.SetActive(false);
            BadEnding.SetActive(true);
        }        

    }

    private void OnMouseUpAsButton()
    {
            DialogueStart();
    }

    public void DialogueStart()
    {
        if(TalkIndex == 0){
            //BackPanel.SetActive(true);
        }
        if(DataController.Instance.gameData.endingNum == 2)
        {
            characters[DataController.Instance.gameData.finalLover].SetActive(true);
            characters[DataController.Instance.gameData.finalLover].GetComponent<Image>().sprite = images[DataController.Instance.gameData.finalLover][0];
        }
        else if(DataController.Instance.gameData.endingNum == 3)
        {
            characters[DataController.Instance.gameData.finalLover].SetActive(true);
            characters[DataController.Instance.gameData.finalLover].GetComponent<Image>().sprite = images[DataController.Instance.gameData.finalLover][0];
        }
        else if(DataController.Instance.gameData.endingNum == 4)
        {
            characters[DataController.Instance.gameData.finalLover].SetActive(true);
            characters[DataController.Instance.gameData.finalLover].GetComponent<Image>().sprite = images[DataController.Instance.gameData.finalLover][0];

        }
        
        TalkIndex++;
        if(EndingDig[0][TalkIndex][0] == "%END%")
        {
            EndingDig.Clear();
            CreditBtn.gameObject.SetActive(true);
        }
        else
        {
            NameText.text = EndingDig[0][TalkIndex][0];
            TalkText.text = EndingDig[0][TalkIndex][1];
        }
    }

    public void GenerateEndingScript(int endingNum, int finalLover)
    {
        Dictionary<int, string[]> talkData = new Dictionary<int, string[]>();

        
        if (endingNum == 1)
        {
            talkData.Add(0, new string[] { "COY", "학기가 끝나면서 나는 연구소로 돌아오게 되었다. " });
            talkData.Add(1, new string[] { "COY", "반 친구들과 함께한 시간은 즐거웠지만" });
            talkData.Add(2, new string[] { "COY", "사랑을 배우기에는 너무 부족한 경험이었다." });
            talkData.Add(3, new string[] { "COY", "여전히 나는 사랑을 이해하지 못했다. " });
            talkData.Add(4, new string[] { "%END%", "" });
        }

        else if (endingNum == 2)
        {
            if (finalLover == 0)
            {
                talkData.Add(0, new string[] { "가영", "COY에게, 강가로 나와줘. 중요한 할 말이 있어." });
                talkData.Add(1, new string[] { "가영", "배구를 하다 힘들때면 여기 와서 빛에 반사된 윤슬을 보곤 했어." });
                talkData.Add(2, new string[] { "가영", "반짝이는 그 풍경을 보고 있으면 다 씻겨 내려가는 기분이거든." });
                talkData.Add(3, new string[] { "가영", "코이 너에게도 보여주고 싶어. 네가 함께 있었으면 좋겠어." });
                talkData.Add(4, new string[] { "가영", "정말이야? 너도 나와 같은 마음인 거야?" });
                talkData.Add(5, new string[] { "가영", "다행이다…" });
                talkData.Add(6, new string[] { "가영", "지금 세상에서 가장 행복해. " });
                talkData.Add(7, new string[] { "%END%", "" });
            }
            else if (finalLover == 1)
            {
                talkData.Add(0, new string[] { "서준", "COY에게, 유리정원으로 나와줘. 중요한 할 말이 있어." });
                talkData.Add(1, new string[] { "서준", "여기 예쁘지? 나만 알고있는 아지트야." });
                talkData.Add(2, new string[] { "서준", "네가 좋아할 것 같아서 데려오고  싶었어. " });
                talkData.Add(3, new string[] { "서준", "우리 계속 같이 오자" });
                talkData.Add(4, new string[] { "서준", "정말이야? 너도 나와 같은 마음인 거야?" });
                talkData.Add(5, new string[] { "서준", "다행이다…" });
                talkData.Add(6, new string[] { "서준", "지금 세상에서 가장 행복해. " });
                talkData.Add(7, new string[] { "%END%", "" });
            }
            else if (finalLover == 2)
            {
                talkData.Add(0, new string[] { "테오", "COY에게, 전망대로 나와줘. 중요한 할 말이 있어." });
                talkData.Add(1, new string[] { "테오", "내가 이런 말을 하게 될 줄은 상상도 못 했는데..." });
                talkData.Add(2, new string[] { "테오", "나도 내 마음이 잘 이해가 안 돼." });
                talkData.Add(3, new string[] { "테오", "...너는 나 어떻게 생각해?" });
                talkData.Add(4, new string[] { "테오", "정말이야? 너도 나와 같은 마음인 거야?" });
                talkData.Add(5, new string[] { "테오", "다행이다…" });
                talkData.Add(6, new string[] { "테오", "지금 세상에서 가장 행복해. " });
                talkData.Add(7, new string[] { "%END%", "" });
            }
            else if (finalLover == 3)
            {
                talkData.Add(0, new string[] { "유이", "COY에게, 호숫가로 나와줘. 중요한 할 말이 있어." });
                talkData.Add(1, new string[] { "유이", "난 이 호수를 제일 좋아해.\n 그려도 그려도 계속 그리게 되거든." });
                talkData.Add(2, new string[] { "유이", "코이야... 근데 이제... 나는... 너를 그리고 싶어." });
                talkData.Add(3, new string[] { "유이", "정말이야? 너도 나와 같은 마음인 거야?" });
                talkData.Add(4, new string[] { "유이", "다행이다…" });
                talkData.Add(5, new string[] { "유이", "지금 세상에서 가장 행복해. " });
                talkData.Add(6, new string[] { "%END%", "" });
            }
            else if (finalLover == 4)
            {
                talkData.Add(0, new string[] { "하나", "COY에게, 놀이공원으로 나와줘. 중요한 할 말이 있어." });
                talkData.Add(1, new string[] { "하나", "코이야 표정 없는 너를 웃게 해주고 싶었어." });
                talkData.Add(2, new string[] { "하나", "내가 오늘 세상에서 제일 재밌게 놀아줄게." });
                talkData.Add(3, new string[] { "하나", "수십 번 왔던 곳인데도 왠지 설렌다..." });
                talkData.Add(4, new string[] { "하나", "정말이야? 너도 나와 같은 마음인 거야?" });
                talkData.Add(5, new string[] { "하나", "다행이다…" });
                talkData.Add(6, new string[] { "하나", "지금 세상에서 가장 행복해. " });
                talkData.Add(7, new string[] { "%END%", "" });
            }
            else if (finalLover == 5)
            {
                talkData.Add(0, new string[] { "시우", "COY에게, 거리로 나와줘. 중요한 할 말이 있어." });
                talkData.Add(1, new string[] { "시우", "나 한 번도 이렇게 평범하게 밖을 돌아다닌 적이 없어... " });
                talkData.Add(2, new string[] { "시우", "너랑 같이 돌아다니는 거 재밌다..." });
                talkData.Add(3, new string[] { "시우", "우리 계속 같이 걷는거 어때..?" });
                talkData.Add(4, new string[] { "시우", "정말이야? 너도 나와 같은 마음인 거야?" });
                talkData.Add(5, new string[] { "시우", "다행이다…" });
                talkData.Add(6, new string[] { "시우", "지금 세상에서 가장 행복해. " });
                talkData.Add(7, new string[] { "%END%", "" });
            }
        }
        else if (endingNum == 3)
        {
            if (finalLover == 0)
            {
                talkData.Add(0, new string[] { "가영", "COY에게, 강가로 나와줘. 중요한 할 말이 있어." });
                talkData.Add(1, new string[] { "가영", "배구를 하다 힘들때면 여기 와서 빛에 반사된 윤슬을 보곤 했어." });
                talkData.Add(2, new string[] { "가영", "반짝이는 그 풍경을 보고 있으면 다 씻겨 내려가는 기분이거든." });
                talkData.Add(3, new string[] { "가영", "코이 너에게도 보여주고 싶어. 네가 함께 있었으면 좋겠어." }); 
                talkData.Add(4, new string[] { "COY", "비록 내가 생각했던 사람이 아니었지만, 그의 마음을 느낄 수 있다." });
                talkData.Add(5, new string[] { "%END%", "" });
            }
            else if (finalLover == 1)
            {
                talkData.Add(0, new string[] { "서준", "COY에게, 유리정원으로 나와줘. 중요한 할 말이 있어." });
                talkData.Add(1, new string[] { "서준", "여기 예쁘지? 나만 알고있는 아지트야." });
                talkData.Add(2, new string[] { "서준", "네가 좋아할 것 같아서 데려오고  싶었어. " });
                talkData.Add(3, new string[] { "서준", "우리 계속 같이 오자" });
                talkData.Add(4, new string[] { "COY", "비록 내가 생각했던 사람이 아니었지만, 그의 마음을 느낄 수 있다." });
                talkData.Add(5, new string[] { "%END%", "" });
            }
            else if(finalLover == 2)
            {
                talkData.Add(0, new string[] { "테오", "COY에게, 전망대로 나와줘. 중요한 할 말이 있어." });
                talkData.Add(1, new string[] { "테오", "내가 이런 말을 하게 될 줄은 상상도 못 했는데..." });
                talkData.Add(2, new string[] { "테오", "나도 내 마음이 잘 이해가 안 돼." });
                talkData.Add(3, new string[] { "테오", "...너는 나 어떻게 생각해?" });
                talkData.Add(4, new string[] { "COY", "비록 내가 생각했던 사람이 아니었지만, 그의 마음을 느낄 수 있다." });
                talkData.Add(5, new string[] { "%END%", "" });
            }
            else if (finalLover == 3)
            {
                talkData.Add(0, new string[] { "유이", "COY에게, 호숫가로 나와줘. 중요한 할 말이 있어." });
                talkData.Add(1, new string[] { "유이", "난 이 호수를 제일 좋아해.\n 그려도 그려도 계속 그리게 되거든." });
                talkData.Add(2, new string[] { "유이", "코이야... 근데 이제... 나는... 너를 그리고 싶어." });
                talkData.Add(3, new string[] { "COY", "비록 내가 생각했던 사람이 아니었지만, 그의 마음을 느낄 수 있다." });
                talkData.Add(4, new string[] { "%END%", "" });
            }
            else if(finalLover == 4)
            {
                talkData.Add(0, new string[] { "하나", "COY에게, 놀이공원으로 나와줘. 중요한 할 말이 있어." });
                talkData.Add(1, new string[] { "하나", "코이야 표정 없는 너를 웃게 해주고 싶었어." });
                talkData.Add(2, new string[] { "하나", "내가 오늘 세상에서 제일 재밌게 놀아줄게." });
                talkData.Add(3, new string[] { "하나", "수십 번 왔던 곳인데도 왠지 설렌다..." });
                talkData.Add(4, new string[] { "COY", "비록 내가 생각했던 사람이 아니었지만, 그의 마음을 느낄 수 있다." });
                talkData.Add(5, new string[] { "%END%", "" });
            }
            else if(finalLover == 5)
            {
                talkData.Add(0, new string[] { "시우", "COY에게, 거리로 나와줘. 중요한 할 말이 있어." });
                talkData.Add(1, new string[] { "시우", "나 한 번도 이렇게 평범하게 밖을 돌아다닌 적이 없어... " });
                talkData.Add(2, new string[] { "시우", "너랑 같이 돌아다니는 거 재밌다..." });
                talkData.Add(3, new string[] { "시우", "우리 계속 같이 걷는거 어때..?" });
                talkData.Add(4, new string[] { "COY", "비록 내가 생각했던 사람이 아니었지만, 그의 마음을 느낄 수 있다." });
                talkData.Add(5, new string[] { "%END%", "" });
            }
        }
        else if (endingNum == 4)
        {
            if (finalLover == 0)
            {
                talkData.Add(0, new string[] { "가영", "COY에게, 강가로 나와줘. 중요한 할 말이 있어." });
                talkData.Add(1, new string[] { "가영", "배구를 하다 힘들때면 여기 와서 빛에 반사된 윤슬을 보곤 했어." });
                talkData.Add(2, new string[] { "가영", "반짝이는 그 풍경을 보고 있으면 다 씻겨 내려가는 기분이거든." });
                talkData.Add(3, new string[] { "가영", "코이 너에게도 보여주고 싶어. 네가 함께 있었으면 좋겠어." });
                talkData.Add(4, new string[] { "가영", "정말이야? 너도 나와 같은 마음인 거야?" });
                talkData.Add(5, new string[] { "가영", "다행이다…" });
                talkData.Add(6, new string[] { "가영", "지금 세상에서 가장 행복해. " });
                talkData.Add(7, new string[] { "COY", "(이 사람이라면 나의 정체를 밝혀도 나를 좋아해줄까..?)"});
                talkData.Add(8, new string[] { "", "(휴머노이드임을 고백한다.)"});
            
                talkData.Add(9, new string[] { "가영", "…휴머노이드라고?" });
                talkData.Add(10, new string[] { "가영", "나를 믿고 솔직하게 말해 줘서 고마워." });
                talkData.Add(11, new string[] { "가영", "난 네가 어떤 모습이든, 어떤 존재이든 간에 너 자체를 좋아해." });
                talkData.Add(12, new string[] { "가영", "너에게 했던 말 중에는 단 한 줄의 거짓도 없었어." });
                talkData.Add(13, new string[] { "%END%", "" });
            }
            else if (finalLover == 1)
            {
                talkData.Add(0, new string[] { "서준", "COY에게, 유리정원으로 나와줘. 중요한 할 말이 있어." });
                talkData.Add(1, new string[] { "서준", "여기 예쁘지? 나만 알고있는 아지트야." });
                talkData.Add(2, new string[] { "서준", "네가 좋아할 것 같아서 데려오고  싶었어. " });
                talkData.Add(3, new string[] { "서준", "우리 계속 같이 오자" });
                talkData.Add(4, new string[] { "서준", "정말이야? 너도 나와 같은 마음인 거야?" });
                talkData.Add(5, new string[] { "서준", "다행이다…" });
                talkData.Add(6, new string[] { "서준", "지금 세상에서 가장 행복해. " });
                talkData.Add(7, new string[] { "COY", "(이 사람이라면 나의 정체를 밝혀도 나를 좋아해줄까..?)"});
                talkData.Add(8, new string[] { "", "(휴머노이드임을 고백한다.)"});


                talkData.Add(9, new string[] { "서준", "…휴머노이드라고?" });
                talkData.Add(10, new string[] { "서준", "나를 믿고 솔직하게 말해 줘서 고마워." });
                talkData.Add(11, new string[] { "서준", "난 네가 어떤 모습이든, 어떤 존재이든 간에 너 자체를 좋아해." });
                talkData.Add(12, new string[] { "서준", "너에게 했던 말 중에는 단 한 줄의 거짓도 없었어." });
                talkData.Add(13, new string[] { "%END%", "" });
            }
            else if (finalLover == 2)
            {
                talkData.Add(0, new string[] { "테오", "COY에게, 전망대로 나와줘. 중요한 할 말이 있어." });
                talkData.Add(1, new string[] { "테오", "내가 이런 말을 하게 될 줄은 상상도 못 했는데..." });
                talkData.Add(2, new string[] { "테오", "나도 내 마음이 잘 이해가 안 돼." });
                talkData.Add(3, new string[] { "테오", "...너는 나 어떻게 생각해?" });
                talkData.Add(4, new string[] { "테오", "정말이야? 너도 나와 같은 마음인 거야?" });
                talkData.Add(5, new string[] { "테오", "다행이다…" });
                talkData.Add(6, new string[] { "테오", "지금 세상에서 가장 행복해. " });
                talkData.Add(7, new string[] { "COY", "(이 사람이라면 나의 정체를 밝혀도 나를 좋아해줄까..?)"});
                talkData.Add(8, new string[] { "", "(휴머노이드임을 고백한다.)"});


                talkData.Add(9, new string[] { "테오", "…휴머노이드라고?" });
                talkData.Add(10, new string[] { "테오", "나를 믿고 솔직하게 말해 줘서 고마워." });
                talkData.Add(11, new string[] { "테오", "난 네가 어떤 모습이든, 어떤 존재이든 간에 너 자체를 좋아해." });
                talkData.Add(12, new string[] { "테오", "너에게 했던 말 중에는 단 한 줄의 거짓도 없었어." });
                talkData.Add(13, new string[] { "%END%", "" });
            }
            else if (finalLover == 3)
            {
                talkData.Add(0, new string[] { "유이", "COY에게, 호숫가로 나와줘. 중요한 할 말이 있어." });
                talkData.Add(1, new string[] { "유이", "난 이 호수를 제일 좋아해.\n 그려도 그려도 계속 그리게 되거든." });
                talkData.Add(2, new string[] { "유이", "코이야... 근데 이제... 나는... 너를 그리고 싶어." });
                talkData.Add(3, new string[] { "유이", "정말이야? 너도 나와 같은 마음인 거야?" });
                talkData.Add(4, new string[] { "유이", "다행이다…" });
                talkData.Add(5, new string[] { "유이", "지금 세상에서 가장 행복해. " });
                talkData.Add(6, new string[] { "COY", "(이 사람이라면 나의 정체를 밝혀도 나를 좋아해줄까..?)"});
                talkData.Add(7, new string[] { "", "(휴머노이드임을 고백한다.)"});


                talkData.Add(8, new string[] { "유이", "…휴머노이드라고?" });
                talkData.Add(9, new string[] { "유이", "나를 믿고 솔직하게 말해 줘서 고마워." });
                talkData.Add(10, new string[] { "유이", "난 네가 어떤 모습이든, 어떤 존재이든 간에 너 자체를 좋아해." });
                talkData.Add(11, new string[] { "유이", "너에게 했던 말 중에는 단 한 줄의 거짓도 없었어." });
                talkData.Add(12, new string[] { "%END%", "" });
            }
            else if (finalLover == 4)
            {
                talkData.Add(0, new string[] { "하나", "COY에게, 놀이공원으로 나와줘. 중요한 할 말이 있어." });
                talkData.Add(1, new string[] { "하나", "코이야 표정 없는 너를 웃게 해주고 싶었어." });
                talkData.Add(2, new string[] { "하나", "내가 오늘 세상에서 제일 재밌게 놀아줄게." });
                talkData.Add(3, new string[] { "하나", "수십 번 왔던 곳인데도 왠지 설렌다..." });
                talkData.Add(4, new string[] { "하나", "정말이야? 너도 나와 같은 마음인 거야?" });
                talkData.Add(5, new string[] { "하나", "다행이다…" });
                talkData.Add(6, new string[] { "하나", "지금 세상에서 가장 행복해. " });
                talkData.Add(7, new string[] { "COY", "(이 사람이라면 나의 정체를 밝혀도 나를 좋아해줄까..?)"});
                talkData.Add(8, new string[] { "", "(휴머노이드임을 고백한다.)"});


                talkData.Add(9, new string[] { "하나", "…휴머노이드라고?" });
                talkData.Add(10, new string[] { "하나", "나를 믿고 솔직하게 말해 줘서 고마워." });
                talkData.Add(11, new string[] { "하나", "난 네가 어떤 모습이든, 어떤 존재이든 간에 너 자체를 좋아해." });
                talkData.Add(12, new string[] { "하나", "너에게 했던 말 중에는 단 한 줄의 거짓도 없었어." });
                talkData.Add(13, new string[] { "%END%", "" });
            }
            else if (finalLover == 5)
            {
                talkData.Add(0, new string[] { "시우", "COY에게, 거리로 나와줘. 중요한 할 말이 있어." });
                talkData.Add(1, new string[] { "시우", "나 한 번도 이렇게 평범하게 밖을 돌아다닌 적이 없어... " });
                talkData.Add(2, new string[] { "시우", "너랑 같이 돌아다니는 거 재밌다..." });
                talkData.Add(3, new string[] { "시우", "우리 계속 같이 걷는거 어때..?" });
                talkData.Add(4, new string[] { "시우", "정말이야? 너도 나와 같은 마음인 거야?" });
                talkData.Add(5, new string[] { "시우", "다행이다…" });
                talkData.Add(6, new string[] { "시우", "지금 세상에서 가장 행복해. " });
                talkData.Add(7, new string[] { "COY", "(이 사람이라면 나의 정체를 밝혀도 나를 좋아해줄까..?)"});
                talkData.Add(8, new string[] { "", "(휴머노이드임을 고백한다.)"});

                talkData.Add(9, new string[] { "시우", "…휴머노이드라고?" });
                talkData.Add(10, new string[] { "시우", "나를 믿고 솔직하게 말해 줘서 고마워." });
                talkData.Add(11, new string[] { "시우", "난 네가 어떤 모습이든, 어떤 존재이든 간에 너 자체를 좋아해." });
                talkData.Add(12, new string[] { "시우", "너에게 했던 말 중에는 단 한 줄의 거짓도 없었어." });
                talkData.Add(13, new string[] { "%END%", "" });
            }
        }
        
        EndingDig.Add(0, talkData);
    }

}