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

    public IEnumerator FadeCorForDayPassBtn() // �Ϸ� ������ Ŭ�� �� ���̵� ȿ�� �ڷ�ƾ
    {
        DayMarkPanel.SetActive(true);
        image.color = new Color(image.color.r, image.color.g, image.color.b, 0);

        while (image.color.a < 1.0f)
        {
            image.color = new Color(image.color.r, image.color.g, image.color.b, image.color.a + (Time.deltaTime / 2.0f));
            yield return null;
        }

        text.gameObject.SetActive(true); // ���� ȭ�鿡 ��¥ ����
        yield return new WaitForSeconds(1.0f);
        text.gameObject.SetActive(false); // ��¥ ���ֱ�

        #region ������� �� ȭ����ȯ
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

    public IEnumerator FadeCorForDigDone() //4��° ��ȭ ���� �� ���̵� ȿ�� �ڷ�ƾ
    {
        DayMarkPanel.SetActive(true);
        image.color = new Color(image.color.r, image.color.g, image.color.b, 0);

        while (image.color.a < 1.0f)
        {
            image.color = new Color(image.color.r, image.color.g, image.color.b, image.color.a + (Time.deltaTime / 2.0f));
            yield return null;
        }

        text.gameObject.SetActive(true); // ���� ȭ�鿡 ��¥ ����
        yield return new WaitForSeconds(1.0f);
        text.gameObject.SetActive(false); // ��¥ ���ֱ�

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
            day.text = DataController.Instance.gameData.Gday.ToString();
        }
        energyT.text = DataController.Instance.gameData.Genergy.ToString();
        energy.SetActive(true);

        #endregion

        StartCoroutine(FadeImageToZero());
        
    }

    public IEnumerator FadeImageToFullAlpha() // ���İ� 0���� 1�� ��ȯ
    {
        DayMarkPanel.SetActive(true);
        image.color = new Color(image.color.r, image.color.g, image.color.b, 0);
        while (image.color.a < 1.0f)
        {
            image.color = new Color(image.color.r, image.color.g, image.color.b, image.color.a + (Time.deltaTime / 2.0f));
            yield return null;
        }

    }

    public IEnumerator FadeImageToZero()  // ���İ� 1���� 0���� ��ȯ
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
