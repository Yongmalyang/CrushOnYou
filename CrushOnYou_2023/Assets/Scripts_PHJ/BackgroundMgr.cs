using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BackgroundMgr : MonoBehaviour
{

    public static BackgroundMgr instance;

    public Sprite[] am, pm, sunset, afterschool;
    public Image AM, PM, Sunset, Afterschool;
    private void Awake()
    {
        if (instance == null) instance = this;
        else if (instance != null) return;
        DontDestroyOnLoad(gameObject);
    }

    public void Start()
    {
        BackgroundChange();
    }

    public void BackgroundChange()
    {
        if (DataController.Instance.gameData.Gturn == 4)
        {

            AM.sprite = am[Random.Range(0, 3)];
            PM.sprite = pm[Random.Range(0, 3)];
            Sunset.sprite = sunset[Random.Range(0, 3)];
            Afterschool.sprite = afterschool[Random.Range(0, 3)];

            AM.gameObject.SetActive(true);
            PM.gameObject.SetActive(false);
            Sunset.gameObject.SetActive(false);
            Afterschool.gameObject.SetActive(false);
        }
        else if (DataController.Instance.gameData.Gturn == 3)
        {

            AM.sprite = am[Random.Range(0, 3)];
            PM.sprite = pm[Random.Range(0, 3)];
            Sunset.sprite = sunset[Random.Range(0, 3)];
            Afterschool.sprite = afterschool[Random.Range(0, 3)];

            AM.gameObject.SetActive(false);
            PM.gameObject.SetActive(true);
            Sunset.gameObject.SetActive(false);
            Afterschool.gameObject.SetActive(false);
        }
        else if (DataController.Instance.gameData.Gturn == 2)
        {

            AM.sprite = am[Random.Range(0, 3)];
            PM.sprite = pm[Random.Range(0, 3)];
            Sunset.sprite = sunset[Random.Range(0, 3)];
            Afterschool.sprite = afterschool[Random.Range(0, 3)];

            AM.gameObject.SetActive(false);
            PM.gameObject.SetActive(false);
            Sunset.gameObject.SetActive(true);
            Afterschool.gameObject.SetActive(false);
        }
        else
        {

            AM.sprite = am[Random.Range(0, 3)];
            PM.sprite = pm[Random.Range(0, 3)];
            Sunset.sprite = sunset[Random.Range(0, 3)];
            Afterschool.sprite = afterschool[Random.Range(0, 3)];

            AM.gameObject.SetActive(false);
            PM.gameObject.SetActive(false);
            Sunset.gameObject.SetActive(false);
            Afterschool.gameObject.SetActive(true);
        }

    }
}
