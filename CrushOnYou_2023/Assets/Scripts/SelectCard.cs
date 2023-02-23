using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class SelectCard : MonoBehaviour
{
    public Card card;
    public int cardenergy;
    public int qnum;
    public TMP_Text energy;
    public TMP_Text hinttext;
    public GameObject selectQ, dialogue;
    public GameObject hintcard;
    public Image t1, t2, t3, t4;

    

    void Update()
    {
        energy.text = DataController.Instance.gameData.Genergy.ToString();

        if (DataController.Instance.gameData.Genergy < cardenergy)
        {
            hintcard.GetComponent<BoxCollider2D>().enabled = false;
            hinttext.text = "선택 불가능";
        }
        else
        {
            hintcard.GetComponent<BoxCollider2D>().enabled = true;
        }

    }

    public void Button()
    {
        if (cardenergy <= DataController.Instance.gameData.Genergy)
        {


            SelectMgr.instance.currentCard = card;
            //test
            SelectMgr.instance.Qnum = qnum;
            DataController.Instance.gameData.Genergy -= cardenergy;
            energy.text = DataController.Instance.gameData.Genergy.ToString();
            //turnPass();
            DialogController.GenerateScript(SelectMgr.instance.Qnum);
            DataController.Instance.gameData.Gturn -= 1;
            DialogController.instance.DialogStart();
            selectQ.SetActive(false);
            dialogue.SetActive(true);
            Debug.Log("온클릭 실행");

            RandomQuestion.instance.RandomIndexMake();
            RandomQuestion.instance.QuestionUpdate();

        }
    }
    

}

