using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Fade : MonoBehaviour
{

    public static Fade instance;

    public GameObject DayMarkPanel;
    public GameObject energy;
    public Image image;
    public TMP_Text text, day, turn, energyT;

    public GameObject Dialog;
    public GameObject SelectAct;

    public Image red, green, blue, purple, pink, yellow;

    // Start is called before the first frame update

    private void Awake()
    {
        if (instance == null) instance = this;
        else if (instance != null) return;
        DontDestroyOnLoad(gameObject);
    }


    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        text.text = "Day " + DataController.Instance.gameData.Gday.ToString();

    }

    public void FadeEffectForDayPassBtn()
    {
        StartCoroutine(FadeCorForDayPassBtn());
    }

    public void FadeEffectForDigDone() {
        StartCoroutine(FadeCorForDigDone());
    }

    public IEnumerator FadeCorForDayPassBtn() // 하루 끝내기 클릭 시 페이드 효과 코루틴
    {
        DayMarkPanel.SetActive(true);
        image.color = new Color(image.color.r, image.color.g, image.color.b, 0);

        while (image.color.a < 1.0f)
        {
            image.color = new Color(image.color.r, image.color.g, image.color.b, image.color.a + (Time.deltaTime / 2.0f));
            yield return null;
        }

        text.gameObject.SetActive(true); // 검은 화면에 날짜 띄우기
        yield return new WaitForSeconds(1.0f);
        text.gameObject.SetActive(false); // 날짜 없애기

        #region 밝아지기 전 화면전환
        BackgroundMgr.instance.BackgroundChange();
        RandomQuestion.instance.RandomIndexMake();
        RandomQuestion.instance.QuestionUpdate();

        turn.text = DataController.Instance.gameData.Gturn.ToString() + " / 4";
        if (!(DataController.Instance.gameData.Gday == 11))
        {
            day.text = DataController.Instance.gameData.Gday.ToString();
        }
        energyT.text = DataController.Instance.gameData.Genergy.ToString();
        energy.SetActive(true);

        #endregion

        StartCoroutine(FadeImageToZero());
    }

    public IEnumerator FadeCorForDigDone() //4번째 대화 종료 시 페이드 효과 코루틴
    {
        DayMarkPanel.SetActive(true);
        image.color = new Color(image.color.r, image.color.g, image.color.b, 0);

        while (image.color.a < 1.0f)
        {
            image.color = new Color(image.color.r, image.color.g, image.color.b, image.color.a + (Time.deltaTime / 2.0f));
            yield return null;
        }

        text.gameObject.SetActive(true); // 검은 화면에 날짜 띄우기
        yield return new WaitForSeconds(1.0f);
        text.gameObject.SetActive(false); // 날짜 없애기

        #region 밝아지기 전 화면전환
        SelectAct.gameObject.SetActive(true);
        Dialog.gameObject.SetActive(false);
        BackgroundMgr.instance.BackgroundChange();
        red.gameObject.SetActive(false);
        green.gameObject.SetActive(false);
        blue.gameObject.SetActive(false);
        purple.gameObject.SetActive(false);
        pink.gameObject.SetActive(false);
        yellow.gameObject.SetActive(false);

        turn.text = DataController.Instance.gameData.Gturn.ToString() + " / 4";
        if (!(DataController.Instance.gameData.Gday == 11))
        {
            day.text = DataController.Instance.gameData.Gday.ToString();
        }
        energyT.text = DataController.Instance.gameData.Genergy.ToString();
        energy.SetActive(true);

        #endregion

        StartCoroutine(FadeImageToZero());
        
    }

    public IEnumerator FadeImageToFullAlpha() // 알파값 0에서 1로 전환
    {
        DayMarkPanel.SetActive(true);
        image.color = new Color(image.color.r, image.color.g, image.color.b, 0);
        while (image.color.a < 1.0f)
        {
            image.color = new Color(image.color.r, image.color.g, image.color.b, image.color.a + (Time.deltaTime / 2.0f));
            yield return null;
        }

    }

    public IEnumerator FadeImageToZero()  // 알파값 1에서 0으로 전환
    {
        image.color = new Color(image.color.r, image.color.g, image.color.b, 1);
        while (image.color.a > 0.0f)
        {
            image.color = new Color(image.color.r, image.color.g, image.color.b, image.color.a - (Time.deltaTime / 6.0f));
            yield return null;
        }
        DayMarkPanel.SetActive(false);
    }
}
