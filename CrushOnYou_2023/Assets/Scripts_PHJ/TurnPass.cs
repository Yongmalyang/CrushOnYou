using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;
public class TurnPass : MonoBehaviour
{
    public TMP_Text turn;
    public TMP_Text day;
    public Image guess, guessend;
    public GameObject DigController, BackgroundMgr, QMake, Fade;

    public void Start()
    {
        turn.text = DataController.Instance.gameData.Gturn.ToString() + " / 4";
        if (!(DataController.Instance.gameData.Gday == 11))
        {
            day.text = DataController.Instance.gameData.Gday.ToString() + " of 10";
        }
    }
    public void Update()
    {
        /*
        turn.text = DataController.Instance.gameData.Gturn.ToString() + " / 4";
        if(!(DataController.Instance.gameData.Gday == 11))
        {
            day.text = DataController.Instance.gameData.Gday.ToString();
        }
        */
        
    }

    public void changePanel()
    {
       
    }

    public void dayPassBtn()
    {
        if(DataController.Instance.gameData.Gday == 10)
        {
            DataController.Instance.gameData.Gday = DataController.Instance.gameData.Gday + 1;
            Destroy(BackgroundMgr);
            Destroy(QMake);
            Destroy(DigController);
            Destroy(Fade);
            if(DataController.Instance.gameData.Submit == true)
            {
                SceneManager.LoadScene("Epi1Done");
            }
            else
            {
                SceneManager.LoadScene("GameOver");
            }
        }
        else
        {
                DataController.Instance.gameData.Gday = DataController.Instance.gameData.Gday + 1;
                DataController.Instance.gameData.Gturn = 4;
                DataController.Instance.gameData.Genergy = 20;
                DialogController.done = true;

                //RandomQuestion.instance.RandomIndexMake();
                //RandomQuestion.instance.QuestionUpdate();

                DialogController.done = false;
        }
        


    }

    public void AllDigDone()
    {
        if(DataController.Instance.gameData.Gday == 11 && DataController.Instance.gameData.Submit == true)
        {
            Destroy(BackgroundMgr);
            Destroy(QMake);
            Destroy(DigController);
            Destroy(Fade);
            SceneManager.LoadScene("Epi1Done");
        }
        else if(DataController.Instance.gameData.Gday == 11 && DataController.Instance.gameData.Submit == false)
        {
            Destroy(BackgroundMgr);
            Destroy(QMake);
            Destroy(DigController);
            Destroy(Fade);
            SceneManager.LoadScene("GameOver");
        }
        
    }

}
