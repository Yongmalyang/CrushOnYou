using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class FadeController : MonoBehaviour
{
    public static FadeController instance;
    public GameObject DayMarkPanel;
    public GameObject energy;
    public TMP_Text text, day, turn, energyT;

    public GameObject Dialog;
    public GameObject SelectAct;

    public Image red, green, blue, purple, pink, yellow;
    public CanvasGroup cg;
    public float fadeTime = 1f; // ���̵� Ÿ�� 
    float accumTime = 0f;
    private Coroutine fadeCor;


    private void Awake()
    {
        if (instance == null) instance = this;
        else if (instance != null) return;
        DontDestroyOnLoad(gameObject);
    }

    public void Start()
    {
        if (DataController.Instance.gameData.Gday == 1 && DataController.Instance.gameData.Gturn == 4)
        {
            FadeFuncForStart();
        }
        else
        {
            cg.alpha = 0;
        }
    }

    void Update()
    {
        text.text = "Day " + DataController.Instance.gameData.Gday.ToString();

    }

    public void FadeFuncForDayPassBtn()
    {
        StartCoroutine(FadeForDayPassBtn());
    }

    public void FadeFuncForDigDone()
    {
        StartCoroutine(FadeForDigDone());
    }

    public void FadeFuncForStart()
    {
        StartCoroutine(FadeOut());
    }


    public IEnumerator FadeForDigDone()
    {

        yield return new WaitForSeconds(0.2f);
        accumTime = 0f;
        while (accumTime < fadeTime)
        {
            cg.alpha = Mathf.Lerp(0f, 1f, accumTime / fadeTime);
            yield return 0;
            accumTime += Time.deltaTime;
        }
        cg.alpha = 1f;

        #region ������� �� ȭ����ȯ
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
            day.text = DataController.Instance.gameData.Gday.ToString() + " of 10" ;
        }
        energyT.text = DataController.Instance.gameData.Genergy.ToString();
        energy.SetActive(true);

        #endregion

        StartCoroutine(FadeOut()); //�����ð� ������ �������� Fade out �ڷ�ƾ ȣ��
    }


    private IEnumerator FadeForDayPassBtn() // �ڷ�ƾ�� ���� ���̵� �� �ð� ����
    {
        yield return new WaitForSeconds(0.2f);
        accumTime = 0f;
        while (accumTime < fadeTime)
        {
            cg.alpha = Mathf.Lerp(0f, 1f, accumTime / fadeTime);
            yield return 0;
            accumTime += Time.deltaTime;
        }
        cg.alpha = 1f;

        #region ������� �� ȭ����ȯ
        BackgroundMgr.instance.BackgroundChange();
        RandomQuestion.instance.RandomIndexMake();
        RandomQuestion.instance.QuestionUpdate();

        turn.text = DataController.Instance.gameData.Gturn.ToString() + " / 4";
        if (!(DataController.Instance.gameData.Gday == 11))
        {
            day.text = DataController.Instance.gameData.Gday.ToString() + " of 10";
        }
        energyT.text = DataController.Instance.gameData.Genergy.ToString();
        energy.SetActive(true);

        #endregion

        StartCoroutine(FadeOut()); //�����ð� ������ �������� Fade out �ڷ�ƾ ȣ��

    }

    private IEnumerator FadeOut()
    {
        yield return new WaitForSeconds(1.5f);
        accumTime = 0f;
        while (accumTime < fadeTime)
        {
            cg.alpha = Mathf.Lerp(1f, 0f, accumTime / fadeTime);
            yield return 0;
            accumTime += Time.deltaTime;
        }
        cg.alpha = 0f;
    }
}