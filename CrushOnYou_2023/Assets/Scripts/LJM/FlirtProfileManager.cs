using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System.Linq;
using static FlirtDirectionManager;

public class FlirtProfileManager : MonoBehaviour
{
    public FlirtDirectionManager fdm;
    // Start is called before the first frame update
    void Start()
    {
        fdm = GameObject.Find("UI").transform.Find("Note").transform.Find("ContentArea").transform.Find("Direction").GetComponent<FlirtDirectionManager>();
        
        fdm.RedLove = DataController.Instance.gameData.RedLove;
        fdm.GreenLove = DataController.Instance.gameData.GreenLove;
        fdm.BlueLove = DataController.Instance.gameData.BlueLove;
        fdm.VioletLove = DataController.Instance.gameData.PurpleLove;
        fdm.PinkLove = DataController.Instance.gameData.PinkLove;
        fdm.YellowLove = DataController.Instance.gameData.YellowLove;
        fdm.CoyLove = DataController.Instance.gameData.CoyLove;
        
        /*
        Debug.Log(fdm.YellowLove[0]);
        Debug.Log(fdm.YellowLove[1]);
        Debug.Log(fdm.YellowLove[2]);
        Debug.Log(fdm.YellowLove[3]);
        Debug.Log(fdm.YellowLove[4]);
        Debug.Log(fdm.YellowLove[5]);
        Debug.Log(fdm.YellowLove[6]);
        */
    
    }
    
    // Update is called once per frame
    void Update()
    {
    }
    
    public void Heart()
    {
        HeartSetFalse();
        fdm.SetIndex();

        //가영 index 0 하트 
        fdm.max = fdm.RedLove.Max();
        List<Heart> RedLoveIndices = fdm.RedLoveList.FindAll(element => element.value == fdm.max);
        foreach (Heart h in RedLoveIndices)
        {
            if (h.Index == 1)
            {
                GameObject.Find("UI").transform.Find("Note").transform.Find("ContentArea").transform.Find("Profile").transform.Find("ContentArea").transform.Find("ProfileR").transform.Find("Heart1").gameObject.SetActive(true);
            }
            if (h.Index == 2)
            {
                GameObject.Find("UI").transform.Find("Note").transform.Find("ContentArea").transform.Find("Profile").transform.Find("ContentArea").transform.Find("ProfileR").transform.Find("Heart2").gameObject.SetActive(true);
            }
            if (h.Index == 3)
            {
                GameObject.Find("UI").transform.Find("Note").transform.Find("ContentArea").transform.Find("Profile").transform.Find("ContentArea").transform.Find("ProfileR").transform.Find("Heart3").gameObject.SetActive(true);
            }
            if (h.Index == 4)
            {
                GameObject.Find("UI").transform.Find("Note").transform.Find("ContentArea").transform.Find("Profile").transform.Find("ContentArea").transform.Find("ProfileR").transform.Find("Heart4").gameObject.SetActive(true);
            }
            if (h.Index == 5)
            {
                GameObject.Find("UI").transform.Find("Note").transform.Find("ContentArea").transform.Find("Profile").transform.Find("ContentArea").transform.Find("ProfileR").transform.Find("Heart5").gameObject.SetActive(true);
            }
            if (h.Index == 6)
            {
                GameObject.Find("UI").transform.Find("Note").transform.Find("ContentArea").transform.Find("Profile").transform.Find("ContentArea").transform.Find("ProfileR").transform.Find("Heart6").gameObject.SetActive(true);
            }
        }
        //가영 호감도
        for(int i=1; i<7; i++)
        {
            GameObject.Find("UI").transform.Find("Note").transform.Find("ContentArea").transform.Find("Profile").transform.Find("ContentArea").transform.Find("ProfileR").transform.Find($"HeartText{i}").gameObject.GetComponentInChildren<TextMeshProUGUI>().text = fdm.RedLove[i].ToString();
        }
        //가영 글자색
        if (fdm.RedLove[1] == fdm.max)
        {
            GameObject.Find("UI").transform.Find("Note").transform.Find("ContentArea").transform.Find("Profile").transform.Find("ContentArea").transform.Find("ProfileR").transform.Find("HeartText1").gameObject.GetComponentInChildren<TextMeshProUGUI>().text = $"<color=black>{GameObject.Find("UI").transform.Find("Note").transform.Find("ContentArea").transform.Find("Profile").transform.Find("ContentArea").transform.Find("ProfileR").transform.Find("HeartText1").gameObject.GetComponentInChildren<TextMeshProUGUI>().text}</color>";
        }
        else
        {
            GameObject.Find("UI").transform.Find("Note").transform.Find("ContentArea").transform.Find("Profile").transform.Find("ContentArea").transform.Find("ProfileR").transform.Find("HeartText1").gameObject.GetComponentInChildren<TextMeshProUGUI>().text = $"{GameObject.Find("UI").transform.Find("Note").transform.Find("ContentArea").transform.Find("Profile").transform.Find("ContentArea").transform.Find("ProfileR").transform.Find("HeartText1").gameObject.GetComponentInChildren<TextMeshProUGUI>().text}" + "→";
        }
        if (fdm.RedLove[2] == fdm.max)
        {
            GameObject.Find("UI").transform.Find("Note").transform.Find("ContentArea").transform.Find("Profile").transform.Find("ContentArea").transform.Find("ProfileR").transform.Find("HeartText2").gameObject.GetComponentInChildren<TextMeshProUGUI>().text = $"<color=black>{GameObject.Find("UI").transform.Find("Note").transform.Find("ContentArea").transform.Find("Profile").transform.Find("ContentArea").transform.Find("ProfileR").transform.Find("HeartText2").gameObject.GetComponentInChildren<TextMeshProUGUI>().text}</color>";
        }
        else
        {
            GameObject.Find("UI").transform.Find("Note").transform.Find("ContentArea").transform.Find("Profile").transform.Find("ContentArea").transform.Find("ProfileR").transform.Find("HeartText2").gameObject.GetComponentInChildren<TextMeshProUGUI>().text = $"{GameObject.Find("UI").transform.Find("Note").transform.Find("ContentArea").transform.Find("Profile").transform.Find("ContentArea").transform.Find("ProfileR").transform.Find("HeartText2").gameObject.GetComponentInChildren<TextMeshProUGUI>().text}" + "→";
        }
        if (fdm.RedLove[3] == fdm.max)
        {
            GameObject.Find("UI").transform.Find("Note").transform.Find("ContentArea").transform.Find("Profile").transform.Find("ContentArea").transform.Find("ProfileR").transform.Find("HeartText3").gameObject.GetComponentInChildren<TextMeshProUGUI>().text = $"<color=black>{GameObject.Find("UI").transform.Find("Note").transform.Find("ContentArea").transform.Find("Profile").transform.Find("ContentArea").transform.Find("ProfileR").transform.Find("HeartText3").gameObject.GetComponentInChildren<TextMeshProUGUI>().text}</color>";
        }
        else
        {
            GameObject.Find("UI").transform.Find("Note").transform.Find("ContentArea").transform.Find("Profile").transform.Find("ContentArea").transform.Find("ProfileR").transform.Find("HeartText3").gameObject.GetComponentInChildren<TextMeshProUGUI>().text = $"{GameObject.Find("UI").transform.Find("Note").transform.Find("ContentArea").transform.Find("Profile").transform.Find("ContentArea").transform.Find("ProfileR").transform.Find("HeartText3").gameObject.GetComponentInChildren<TextMeshProUGUI>().text}" + "→";
        }
        if (fdm.RedLove[4] == fdm.max)
        {
            GameObject.Find("UI").transform.Find("Note").transform.Find("ContentArea").transform.Find("Profile").transform.Find("ContentArea").transform.Find("ProfileR").transform.Find("HeartText4").gameObject.GetComponentInChildren<TextMeshProUGUI>().text = $"<color=black>{GameObject.Find("UI").transform.Find("Note").transform.Find("ContentArea").transform.Find("Profile").transform.Find("ContentArea").transform.Find("ProfileR").transform.Find("HeartText4").gameObject.GetComponentInChildren<TextMeshProUGUI>().text}</color>";
        }
        else
        {
            GameObject.Find("UI").transform.Find("Note").transform.Find("ContentArea").transform.Find("Profile").transform.Find("ContentArea").transform.Find("ProfileR").transform.Find("HeartText4").gameObject.GetComponentInChildren<TextMeshProUGUI>().text = $"{GameObject.Find("UI").transform.Find("Note").transform.Find("ContentArea").transform.Find("Profile").transform.Find("ContentArea").transform.Find("ProfileR").transform.Find("HeartText4").gameObject.GetComponentInChildren<TextMeshProUGUI>().text}" + "→";
        }
        if (fdm.RedLove[5] == fdm.max)
        {
            GameObject.Find("UI").transform.Find("Note").transform.Find("ContentArea").transform.Find("Profile").transform.Find("ContentArea").transform.Find("ProfileR").transform.Find("HeartText5").gameObject.GetComponentInChildren<TextMeshProUGUI>().text = $"<color=black>{GameObject.Find("UI").transform.Find("Note").transform.Find("ContentArea").transform.Find("Profile").transform.Find("ContentArea").transform.Find("ProfileR").transform.Find("HeartText5").gameObject.GetComponentInChildren<TextMeshProUGUI>().text}</color>";
        }
        else
        {
            GameObject.Find("UI").transform.Find("Note").transform.Find("ContentArea").transform.Find("Profile").transform.Find("ContentArea").transform.Find("ProfileR").transform.Find("HeartText5").gameObject.GetComponentInChildren<TextMeshProUGUI>().text = $"{GameObject.Find("UI").transform.Find("Note").transform.Find("ContentArea").transform.Find("Profile").transform.Find("ContentArea").transform.Find("ProfileR").transform.Find("HeartText5").gameObject.GetComponentInChildren<TextMeshProUGUI>().text}" + "→";
        }
        if (fdm.RedLove[6] == fdm.max)
        {
            GameObject.Find("UI").transform.Find("Note").transform.Find("ContentArea").transform.Find("Profile").transform.Find("ContentArea").transform.Find("ProfileR").transform.Find("HeartText6").gameObject.GetComponentInChildren<TextMeshProUGUI>().text = $"<color=black>{GameObject.Find("UI").transform.Find("Note").transform.Find("ContentArea").transform.Find("Profile").transform.Find("ContentArea").transform.Find("ProfileR").transform.Find("HeartText6").gameObject.GetComponentInChildren<TextMeshProUGUI>().text}</color>";
        }
        else
        {
            GameObject.Find("UI").transform.Find("Note").transform.Find("ContentArea").transform.Find("Profile").transform.Find("ContentArea").transform.Find("ProfileR").transform.Find("HeartText6").gameObject.GetComponentInChildren<TextMeshProUGUI>().text = $"{GameObject.Find("UI").transform.Find("Note").transform.Find("ContentArea").transform.Find("Profile").transform.Find("ContentArea").transform.Find("ProfileR").transform.Find("HeartText6").gameObject.GetComponentInChildren<TextMeshProUGUI>().text}" + "→";
        }


        //서준 index 1 하트
        fdm.max = fdm.GreenLove.Max();
        List<Heart> GreenLoveIndices = fdm.GreenLoveList.FindAll(element => element.value == fdm.max);
        foreach (Heart h in GreenLoveIndices)
        {
            if (h.Index == 0)
            {
                GameObject.Find("UI").transform.Find("Note").transform.Find("ContentArea").transform.Find("Profile").transform.Find("ContentArea").transform.Find("ProfileG").transform.Find("Heart1").gameObject.SetActive(true);
            }
            if (h.Index == 2)
            {
                GameObject.Find("UI").transform.Find("Note").transform.Find("ContentArea").transform.Find("Profile").transform.Find("ContentArea").transform.Find("ProfileG").transform.Find("Heart2").gameObject.SetActive(true);
            }
            if (h.Index == 3)
            {
                GameObject.Find("UI").transform.Find("Note").transform.Find("ContentArea").transform.Find("Profile").transform.Find("ContentArea").transform.Find("ProfileG").transform.Find("Heart3").gameObject.SetActive(true);
            }
            if (h.Index == 4)
            {
                GameObject.Find("UI").transform.Find("Note").transform.Find("ContentArea").transform.Find("Profile").transform.Find("ContentArea").transform.Find("ProfileG").transform.Find("Heart4").gameObject.SetActive(true);
            }
            if (h.Index == 5)
            {
                GameObject.Find("UI").transform.Find("Note").transform.Find("ContentArea").transform.Find("Profile").transform.Find("ContentArea").transform.Find("ProfileG").transform.Find("Heart5").gameObject.SetActive(true);
            }
            if (h.Index == 6)
            {
                GameObject.Find("UI").transform.Find("Note").transform.Find("ContentArea").transform.Find("Profile").transform.Find("ContentArea").transform.Find("ProfileG").transform.Find("Heart6").gameObject.SetActive(true);
            }
        }
        //서준 호감도
        GameObject.Find("UI").transform.Find("Note").transform.Find("ContentArea").transform.Find("Profile").transform.Find("ContentArea").transform.Find("ProfileG").transform.Find("HeartText1").gameObject.GetComponentInChildren<TextMeshProUGUI>().text = fdm.GreenLove[0].ToString();
        for (int i = 2; i < 7; i++)
        {
            GameObject.Find("UI").transform.Find("Note").transform.Find("ContentArea").transform.Find("Profile").transform.Find("ContentArea").transform.Find("ProfileG").transform.Find($"HeartText{i}").gameObject.GetComponentInChildren<TextMeshProUGUI>().text = fdm.GreenLove[i].ToString();
        }

        //서준 index 1 글자색
        if (fdm.GreenLove[0] == fdm.max)
        {
            GameObject.Find("UI").transform.Find("Note").transform.Find("ContentArea").transform.Find("Profile").transform.Find("ContentArea").transform.Find("ProfileG").transform.Find("HeartText1").gameObject.GetComponentInChildren<TextMeshProUGUI>().text = $"<color=black>{GameObject.Find("UI").transform.Find("Note").transform.Find("ContentArea").transform.Find("Profile").transform.Find("ContentArea").transform.Find("ProfileG").transform.Find("HeartText1").gameObject.GetComponentInChildren<TextMeshProUGUI>().text}</color>";
        }
        else
        {
            GameObject.Find("UI").transform.Find("Note").transform.Find("ContentArea").transform.Find("Profile").transform.Find("ContentArea").transform.Find("ProfileG").transform.Find("HeartText1").gameObject.GetComponentInChildren<TextMeshProUGUI>().text = $"{GameObject.Find("UI").transform.Find("Note").transform.Find("ContentArea").transform.Find("Profile").transform.Find("ContentArea").transform.Find("ProfileG").transform.Find("HeartText1").gameObject.GetComponentInChildren<TextMeshProUGUI>().text}" + "→";
        }
        if (fdm.GreenLove[2] == fdm.max)
        {
            GameObject.Find("UI").transform.Find("Note").transform.Find("ContentArea").transform.Find("Profile").transform.Find("ContentArea").transform.Find("ProfileG").transform.Find("HeartText2").gameObject.GetComponentInChildren<TextMeshProUGUI>().text = $"<color=black>{GameObject.Find("UI").transform.Find("Note").transform.Find("ContentArea").transform.Find("Profile").transform.Find("ContentArea").transform.Find("ProfileG").transform.Find("HeartText2").gameObject.GetComponentInChildren<TextMeshProUGUI>().text}</color>";
        }
        else
        {
            GameObject.Find("UI").transform.Find("Note").transform.Find("ContentArea").transform.Find("Profile").transform.Find("ContentArea").transform.Find("ProfileG").transform.Find("HeartText2").gameObject.GetComponentInChildren<TextMeshProUGUI>().text = $"{GameObject.Find("UI").transform.Find("Note").transform.Find("ContentArea").transform.Find("Profile").transform.Find("ContentArea").transform.Find("ProfileG").transform.Find("HeartText2").gameObject.GetComponentInChildren<TextMeshProUGUI>().text}" + "→";
        }
        if (fdm.GreenLove[3] == fdm.max)
        {
            GameObject.Find("UI").transform.Find("Note").transform.Find("ContentArea").transform.Find("Profile").transform.Find("ContentArea").transform.Find("ProfileG").transform.Find("HeartText3").gameObject.GetComponentInChildren<TextMeshProUGUI>().text = $"<color=black>{GameObject.Find("UI").transform.Find("Note").transform.Find("ContentArea").transform.Find("Profile").transform.Find("ContentArea").transform.Find("ProfileG").transform.Find("HeartText3").gameObject.GetComponentInChildren<TextMeshProUGUI>().text}</color>";
        }
        else
        {
            GameObject.Find("UI").transform.Find("Note").transform.Find("ContentArea").transform.Find("Profile").transform.Find("ContentArea").transform.Find("ProfileG").transform.Find("HeartText3").gameObject.GetComponentInChildren<TextMeshProUGUI>().text = $"{GameObject.Find("UI").transform.Find("Note").transform.Find("ContentArea").transform.Find("Profile").transform.Find("ContentArea").transform.Find("ProfileG").transform.Find("HeartText3").gameObject.GetComponentInChildren<TextMeshProUGUI>().text}" + "→";
        }
        if (fdm.GreenLove[4] == fdm.max)
        {
            GameObject.Find("UI").transform.Find("Note").transform.Find("ContentArea").transform.Find("Profile").transform.Find("ContentArea").transform.Find("ProfileG").transform.Find("HeartText4").gameObject.GetComponentInChildren<TextMeshProUGUI>().text = $"<color=black>{GameObject.Find("UI").transform.Find("Note").transform.Find("ContentArea").transform.Find("Profile").transform.Find("ContentArea").transform.Find("ProfileG").transform.Find("HeartText4").gameObject.GetComponentInChildren<TextMeshProUGUI>().text}</color>";
        }
        else
        {
            GameObject.Find("UI").transform.Find("Note").transform.Find("ContentArea").transform.Find("Profile").transform.Find("ContentArea").transform.Find("ProfileG").transform.Find("HeartText4").gameObject.GetComponentInChildren<TextMeshProUGUI>().text = $"{GameObject.Find("UI").transform.Find("Note").transform.Find("ContentArea").transform.Find("Profile").transform.Find("ContentArea").transform.Find("ProfileG").transform.Find("HeartText4").gameObject.GetComponentInChildren<TextMeshProUGUI>().text}" + "→";
        }
        if (fdm.GreenLove[5] == fdm.max)
        {
            GameObject.Find("UI").transform.Find("Note").transform.Find("ContentArea").transform.Find("Profile").transform.Find("ContentArea").transform.Find("ProfileG").transform.Find("HeartText5").gameObject.GetComponentInChildren<TextMeshProUGUI>().text = $"<color=black>{GameObject.Find("UI").transform.Find("Note").transform.Find("ContentArea").transform.Find("Profile").transform.Find("ContentArea").transform.Find("ProfileG").transform.Find("HeartText5").gameObject.GetComponentInChildren<TextMeshProUGUI>().text}</color>";
        }
        else
        {
            GameObject.Find("UI").transform.Find("Note").transform.Find("ContentArea").transform.Find("Profile").transform.Find("ContentArea").transform.Find("ProfileG").transform.Find("HeartText5").gameObject.GetComponentInChildren<TextMeshProUGUI>().text = $"{GameObject.Find("UI").transform.Find("Note").transform.Find("ContentArea").transform.Find("Profile").transform.Find("ContentArea").transform.Find("ProfileG").transform.Find("HeartText5").gameObject.GetComponentInChildren<TextMeshProUGUI>().text}" + "→";
        }
        if (fdm.GreenLove[6] == fdm.max)
        {
            GameObject.Find("UI").transform.Find("Note").transform.Find("ContentArea").transform.Find("Profile").transform.Find("ContentArea").transform.Find("ProfileG").transform.Find("HeartText6").gameObject.GetComponentInChildren<TextMeshProUGUI>().text = $"<color=black>{GameObject.Find("UI").transform.Find("Note").transform.Find("ContentArea").transform.Find("Profile").transform.Find("ContentArea").transform.Find("ProfileG").transform.Find("HeartText6").gameObject.GetComponentInChildren<TextMeshProUGUI>().text}</color>";
        }
        else
        {
            GameObject.Find("UI").transform.Find("Note").transform.Find("ContentArea").transform.Find("Profile").transform.Find("ContentArea").transform.Find("ProfileG").transform.Find("HeartText6").gameObject.GetComponentInChildren<TextMeshProUGUI>().text = $"{GameObject.Find("UI").transform.Find("Note").transform.Find("ContentArea").transform.Find("Profile").transform.Find("ContentArea").transform.Find("ProfileG").transform.Find("HeartText6").gameObject.GetComponentInChildren<TextMeshProUGUI>().text}" + "→";
        }

        //테오 index 2 하트
        fdm.max = fdm.BlueLove.Max();
        List<Heart> BlueLoveIndices = fdm.BlueLoveList.FindAll(element => element.value == fdm.max);
        foreach (Heart h in BlueLoveIndices)
        {
            if (h.Index == 0)
            {
                GameObject.Find("UI").transform.Find("Note").transform.Find("ContentArea").transform.Find("Profile").transform.Find("ContentArea").transform.Find("ProfileB").transform.Find("Heart1").gameObject.SetActive(true);
            }
            if (h.Index == 1)
            {
                GameObject.Find("UI").transform.Find("Note").transform.Find("ContentArea").transform.Find("Profile").transform.Find("ContentArea").transform.Find("ProfileB").transform.Find("Heart2").gameObject.SetActive(true);
            }
            if (h.Index == 3)
            {
                GameObject.Find("UI").transform.Find("Note").transform.Find("ContentArea").transform.Find("Profile").transform.Find("ContentArea").transform.Find("ProfileB").transform.Find("Heart3").gameObject.SetActive(true);
            }
            if (h.Index == 4)
            {
                GameObject.Find("UI").transform.Find("Note").transform.Find("ContentArea").transform.Find("Profile").transform.Find("ContentArea").transform.Find("ProfileB").transform.Find("Heart4").gameObject.SetActive(true);
            }
            if (h.Index == 5)
            {
                GameObject.Find("UI").transform.Find("Note").transform.Find("ContentArea").transform.Find("Profile").transform.Find("ContentArea").transform.Find("ProfileB").transform.Find("Heart5").gameObject.SetActive(true);
            }
            if (h.Index == 6)
            {
                GameObject.Find("UI").transform.Find("Note").transform.Find("ContentArea").transform.Find("Profile").transform.Find("ContentArea").transform.Find("ProfileB").transform.Find("Heart6").gameObject.SetActive(true);
            }
        }
        //테오 호감도
        GameObject.Find("UI").transform.Find("Note").transform.Find("ContentArea").transform.Find("Profile").transform.Find("ContentArea").transform.Find("ProfileB").transform.Find("HeartText1").gameObject.GetComponentInChildren<TextMeshProUGUI>().text = fdm.BlueLove[0].ToString();
        GameObject.Find("UI").transform.Find("Note").transform.Find("ContentArea").transform.Find("Profile").transform.Find("ContentArea").transform.Find("ProfileB").transform.Find("HeartText2").gameObject.GetComponentInChildren<TextMeshProUGUI>().text = fdm.BlueLove[1].ToString();
        for (int i = 3; i < 7; i++)
        {
            GameObject.Find("UI").transform.Find("Note").transform.Find("ContentArea").transform.Find("Profile").transform.Find("ContentArea").transform.Find("ProfileB").transform.Find($"HeartText{i}").gameObject.GetComponentInChildren<TextMeshProUGUI>().text = fdm.BlueLove[i].ToString();
        }

        //테오 index 2 글자색
        if (fdm.BlueLove[0] == fdm.max)
        {
            GameObject.Find("UI").transform.Find("Note").transform.Find("ContentArea").transform.Find("Profile").transform.Find("ContentArea").transform.Find("ProfileB").transform.Find("HeartText1").gameObject.GetComponentInChildren<TextMeshProUGUI>().text = $"<color=black>{GameObject.Find("UI").transform.Find("Note").transform.Find("ContentArea").transform.Find("Profile").transform.Find("ContentArea").transform.Find("ProfileB").transform.Find("HeartText1").gameObject.GetComponentInChildren<TextMeshProUGUI>().text}</color>";
        }
        else
        {
            GameObject.Find("UI").transform.Find("Note").transform.Find("ContentArea").transform.Find("Profile").transform.Find("ContentArea").transform.Find("ProfileB").transform.Find("HeartText1").gameObject.GetComponentInChildren<TextMeshProUGUI>().text = $"{GameObject.Find("UI").transform.Find("Note").transform.Find("ContentArea").transform.Find("Profile").transform.Find("ContentArea").transform.Find("ProfileB").transform.Find("HeartText1").gameObject.GetComponentInChildren<TextMeshProUGUI>().text}" + "→";
        }
        if (fdm.BlueLove[1] == fdm.max)
        {
            GameObject.Find("UI").transform.Find("Note").transform.Find("ContentArea").transform.Find("Profile").transform.Find("ContentArea").transform.Find("ProfileB").transform.Find("HeartText2").gameObject.GetComponentInChildren<TextMeshProUGUI>().text = $"<color=black>{GameObject.Find("UI").transform.Find("Note").transform.Find("ContentArea").transform.Find("Profile").transform.Find("ContentArea").transform.Find("ProfileB").transform.Find("HeartText2").gameObject.GetComponentInChildren<TextMeshProUGUI>().text}</color>";
        }
        else
        {
            GameObject.Find("UI").transform.Find("Note").transform.Find("ContentArea").transform.Find("Profile").transform.Find("ContentArea").transform.Find("ProfileB").transform.Find("HeartText2").gameObject.GetComponentInChildren<TextMeshProUGUI>().text = $"{GameObject.Find("UI").transform.Find("Note").transform.Find("ContentArea").transform.Find("Profile").transform.Find("ContentArea").transform.Find("ProfileB").transform.Find("HeartText2").gameObject.GetComponentInChildren<TextMeshProUGUI>().text}" + "→";
        }
        if (fdm.BlueLove[3] == fdm.max)
        {
            GameObject.Find("UI").transform.Find("Note").transform.Find("ContentArea").transform.Find("Profile").transform.Find("ContentArea").transform.Find("ProfileB").transform.Find("HeartText3").gameObject.GetComponentInChildren<TextMeshProUGUI>().text = $"<color=black>{GameObject.Find("UI").transform.Find("Note").transform.Find("ContentArea").transform.Find("Profile").transform.Find("ContentArea").transform.Find("ProfileB").transform.Find("HeartText3").gameObject.GetComponentInChildren<TextMeshProUGUI>().text}</color>";
        }
        else
        {
            GameObject.Find("UI").transform.Find("Note").transform.Find("ContentArea").transform.Find("Profile").transform.Find("ContentArea").transform.Find("ProfileB").transform.Find("HeartText3").gameObject.GetComponentInChildren<TextMeshProUGUI>().text = $"{GameObject.Find("UI").transform.Find("Note").transform.Find("ContentArea").transform.Find("Profile").transform.Find("ContentArea").transform.Find("ProfileB").transform.Find("HeartText3").gameObject.GetComponentInChildren<TextMeshProUGUI>().text}" + "→";
        }
        if (fdm.BlueLove[4] == fdm.max)
        {
            GameObject.Find("UI").transform.Find("Note").transform.Find("ContentArea").transform.Find("Profile").transform.Find("ContentArea").transform.Find("ProfileB").transform.Find("HeartText4").gameObject.GetComponentInChildren<TextMeshProUGUI>().text = $"<color=black>{GameObject.Find("UI").transform.Find("Note").transform.Find("ContentArea").transform.Find("Profile").transform.Find("ContentArea").transform.Find("ProfileB").transform.Find("HeartText4").gameObject.GetComponentInChildren<TextMeshProUGUI>().text}</color>";
        }
        else
        {
            GameObject.Find("UI").transform.Find("Note").transform.Find("ContentArea").transform.Find("Profile").transform.Find("ContentArea").transform.Find("ProfileB").transform.Find("HeartText4").gameObject.GetComponentInChildren<TextMeshProUGUI>().text = $"{GameObject.Find("UI").transform.Find("Note").transform.Find("ContentArea").transform.Find("Profile").transform.Find("ContentArea").transform.Find("ProfileB").transform.Find("HeartText4").gameObject.GetComponentInChildren<TextMeshProUGUI>().text}" + "→";
        }
        if (fdm.BlueLove[5] == fdm.max)
        {
            GameObject.Find("UI").transform.Find("Note").transform.Find("ContentArea").transform.Find("Profile").transform.Find("ContentArea").transform.Find("ProfileB").transform.Find("HeartText5").gameObject.GetComponentInChildren<TextMeshProUGUI>().text = $"<color=black>{GameObject.Find("UI").transform.Find("Note").transform.Find("ContentArea").transform.Find("Profile").transform.Find("ContentArea").transform.Find("ProfileB").transform.Find("HeartText5").gameObject.GetComponentInChildren<TextMeshProUGUI>().text}</color>";
        }
        else
        {
            GameObject.Find("UI").transform.Find("Note").transform.Find("ContentArea").transform.Find("Profile").transform.Find("ContentArea").transform.Find("ProfileB").transform.Find("HeartText5").gameObject.GetComponentInChildren<TextMeshProUGUI>().text = $"{GameObject.Find("UI").transform.Find("Note").transform.Find("ContentArea").transform.Find("Profile").transform.Find("ContentArea").transform.Find("ProfileB").transform.Find("HeartText5").gameObject.GetComponentInChildren<TextMeshProUGUI>().text}" + "→";
        }
        if (fdm.BlueLove[6] == fdm.max)
        {
            GameObject.Find("UI").transform.Find("Note").transform.Find("ContentArea").transform.Find("Profile").transform.Find("ContentArea").transform.Find("ProfileB").transform.Find("HeartText6").gameObject.GetComponentInChildren<TextMeshProUGUI>().text = $"<color=black>{GameObject.Find("UI").transform.Find("Note").transform.Find("ContentArea").transform.Find("Profile").transform.Find("ContentArea").transform.Find("ProfileB").transform.Find("HeartText6").gameObject.GetComponentInChildren<TextMeshProUGUI>().text}</color>";
        }
        else
        {
            GameObject.Find("UI").transform.Find("Note").transform.Find("ContentArea").transform.Find("Profile").transform.Find("ContentArea").transform.Find("ProfileB").transform.Find("HeartText6").gameObject.GetComponentInChildren<TextMeshProUGUI>().text = $"{GameObject.Find("UI").transform.Find("Note").transform.Find("ContentArea").transform.Find("Profile").transform.Find("ContentArea").transform.Find("ProfileB").transform.Find("HeartText6").gameObject.GetComponentInChildren<TextMeshProUGUI>().text}" + "→";
        }

        //유이 index 3 하트
        fdm.max = fdm.VioletLove.Max();
        List<Heart> VioletLoveIndices = fdm.VioletLoveList.FindAll(element => element.value == fdm.max);
        foreach (Heart h in VioletLoveIndices)
        {
            if (h.Index == 0)
            {
                GameObject.Find("UI").transform.Find("Note").transform.Find("ContentArea").transform.Find("Profile").transform.Find("ContentArea").transform.Find("ProfileV").transform.Find("Heart1").gameObject.SetActive(true);
            }
            if (h.Index == 1)
            {
                GameObject.Find("UI").transform.Find("Note").transform.Find("ContentArea").transform.Find("Profile").transform.Find("ContentArea").transform.Find("ProfileV").transform.Find("Heart2").gameObject.SetActive(true);
            }
            if (h.Index == 2)
            {
                GameObject.Find("UI").transform.Find("Note").transform.Find("ContentArea").transform.Find("Profile").transform.Find("ContentArea").transform.Find("ProfileV").transform.Find("Heart3").gameObject.SetActive(true);
            }
            if (h.Index == 4)
            {
                GameObject.Find("UI").transform.Find("Note").transform.Find("ContentArea").transform.Find("Profile").transform.Find("ContentArea").transform.Find("ProfileV").transform.Find("Heart4").gameObject.SetActive(true);
            }
            if (h.Index == 5)
            {
                GameObject.Find("UI").transform.Find("Note").transform.Find("ContentArea").transform.Find("Profile").transform.Find("ContentArea").transform.Find("ProfileV").transform.Find("Heart5").gameObject.SetActive(true);
            }
            if (h.Index == 6)
            {
                GameObject.Find("UI").transform.Find("Note").transform.Find("ContentArea").transform.Find("Profile").transform.Find("ContentArea").transform.Find("ProfileV").transform.Find("Heart6").gameObject.SetActive(true);
            }
        }
        //유이 호감도
        GameObject.Find("UI").transform.Find("Note").transform.Find("ContentArea").transform.Find("Profile").transform.Find("ContentArea").transform.Find("ProfileV").transform.Find("HeartText1").gameObject.GetComponentInChildren<TextMeshProUGUI>().text = fdm.VioletLove[0].ToString();
        GameObject.Find("UI").transform.Find("Note").transform.Find("ContentArea").transform.Find("Profile").transform.Find("ContentArea").transform.Find("ProfileV").transform.Find("HeartText2").gameObject.GetComponentInChildren<TextMeshProUGUI>().text = fdm.VioletLove[1].ToString();
        GameObject.Find("UI").transform.Find("Note").transform.Find("ContentArea").transform.Find("Profile").transform.Find("ContentArea").transform.Find("ProfileV").transform.Find("HeartText3").gameObject.GetComponentInChildren<TextMeshProUGUI>().text = fdm.VioletLove[2].ToString();
        for (int i = 4; i < 7; i++)
        {
            GameObject.Find("UI").transform.Find("Note").transform.Find("ContentArea").transform.Find("Profile").transform.Find("ContentArea").transform.Find("ProfileV").transform.Find($"HeartText{i}").gameObject.GetComponentInChildren<TextMeshProUGUI>().text = fdm.VioletLove[i].ToString();
        }

        //유이 index 3 글자색
        if (fdm.VioletLove[0] == fdm.max)
        {
            GameObject.Find("UI").transform.Find("Note").transform.Find("ContentArea").transform.Find("Profile").transform.Find("ContentArea").transform.Find("ProfileV").transform.Find("HeartText1").gameObject.GetComponentInChildren<TextMeshProUGUI>().text = $"<color=black>{GameObject.Find("UI").transform.Find("Note").transform.Find("ContentArea").transform.Find("Profile").transform.Find("ContentArea").transform.Find("ProfileV").transform.Find("HeartText1").gameObject.GetComponentInChildren<TextMeshProUGUI>().text}</color>";
        }
        else
        {
            GameObject.Find("UI").transform.Find("Note").transform.Find("ContentArea").transform.Find("Profile").transform.Find("ContentArea").transform.Find("ProfileV").transform.Find("HeartText1").gameObject.GetComponentInChildren<TextMeshProUGUI>().text = $"{GameObject.Find("UI").transform.Find("Note").transform.Find("ContentArea").transform.Find("Profile").transform.Find("ContentArea").transform.Find("ProfileV").transform.Find("HeartText1").gameObject.GetComponentInChildren<TextMeshProUGUI>().text}" + "→";
        }
        if (fdm.VioletLove[1] == fdm.max)
        {
            GameObject.Find("UI").transform.Find("Note").transform.Find("ContentArea").transform.Find("Profile").transform.Find("ContentArea").transform.Find("ProfileV").transform.Find("HeartText2").gameObject.GetComponentInChildren<TextMeshProUGUI>().text = $"<color=black>{GameObject.Find("UI").transform.Find("Note").transform.Find("ContentArea").transform.Find("Profile").transform.Find("ContentArea").transform.Find("ProfileV").transform.Find("HeartText2").gameObject.GetComponentInChildren<TextMeshProUGUI>().text}</color>";
        }
        else
        {
            GameObject.Find("UI").transform.Find("Note").transform.Find("ContentArea").transform.Find("Profile").transform.Find("ContentArea").transform.Find("ProfileV").transform.Find("HeartText2").gameObject.GetComponentInChildren<TextMeshProUGUI>().text = $"{GameObject.Find("UI").transform.Find("Note").transform.Find("ContentArea").transform.Find("Profile").transform.Find("ContentArea").transform.Find("ProfileV").transform.Find("HeartText2").gameObject.GetComponentInChildren<TextMeshProUGUI>().text}" + "→";
        }
        if (fdm.VioletLove[2] == fdm.max)
        {
            GameObject.Find("UI").transform.Find("Note").transform.Find("ContentArea").transform.Find("Profile").transform.Find("ContentArea").transform.Find("ProfileV").transform.Find("HeartText3").gameObject.GetComponentInChildren<TextMeshProUGUI>().text = $"<color=black>{GameObject.Find("UI").transform.Find("Note").transform.Find("ContentArea").transform.Find("Profile").transform.Find("ContentArea").transform.Find("ProfileV").transform.Find("HeartText3").gameObject.GetComponentInChildren<TextMeshProUGUI>().text}</color>";
        }
        else
        {
            GameObject.Find("UI").transform.Find("Note").transform.Find("ContentArea").transform.Find("Profile").transform.Find("ContentArea").transform.Find("ProfileV").transform.Find("HeartText3").gameObject.GetComponentInChildren<TextMeshProUGUI>().text = $"{GameObject.Find("UI").transform.Find("Note").transform.Find("ContentArea").transform.Find("Profile").transform.Find("ContentArea").transform.Find("ProfileV").transform.Find("HeartText3").gameObject.GetComponentInChildren<TextMeshProUGUI>().text}" + "→";
        }
        if (fdm.VioletLove[4] == fdm.max)
        {
            GameObject.Find("UI").transform.Find("Note").transform.Find("ContentArea").transform.Find("Profile").transform.Find("ContentArea").transform.Find("ProfileV").transform.Find("HeartText4").gameObject.GetComponentInChildren<TextMeshProUGUI>().text = $"<color=black>{GameObject.Find("UI").transform.Find("Note").transform.Find("ContentArea").transform.Find("Profile").transform.Find("ContentArea").transform.Find("ProfileV").transform.Find("HeartText4").gameObject.GetComponentInChildren<TextMeshProUGUI>().text}</color>";
        }
        else
        {
            GameObject.Find("UI").transform.Find("Note").transform.Find("ContentArea").transform.Find("Profile").transform.Find("ContentArea").transform.Find("ProfileV").transform.Find("HeartText4").gameObject.GetComponentInChildren<TextMeshProUGUI>().text = $"{GameObject.Find("UI").transform.Find("Note").transform.Find("ContentArea").transform.Find("Profile").transform.Find("ContentArea").transform.Find("ProfileV").transform.Find("HeartText4").gameObject.GetComponentInChildren<TextMeshProUGUI>().text}" + "→";
        }
        if (fdm.VioletLove[5] == fdm.max)
        {
            GameObject.Find("UI").transform.Find("Note").transform.Find("ContentArea").transform.Find("Profile").transform.Find("ContentArea").transform.Find("ProfileV").transform.Find("HeartText5").gameObject.GetComponentInChildren<TextMeshProUGUI>().text = $"<color=black>{GameObject.Find("UI").transform.Find("Note").transform.Find("ContentArea").transform.Find("Profile").transform.Find("ContentArea").transform.Find("ProfileV").transform.Find("HeartText5").gameObject.GetComponentInChildren<TextMeshProUGUI>().text}</color>";
        }
        else
        {
            GameObject.Find("UI").transform.Find("Note").transform.Find("ContentArea").transform.Find("Profile").transform.Find("ContentArea").transform.Find("ProfileV").transform.Find("HeartText5").gameObject.GetComponentInChildren<TextMeshProUGUI>().text = $"{GameObject.Find("UI").transform.Find("Note").transform.Find("ContentArea").transform.Find("Profile").transform.Find("ContentArea").transform.Find("ProfileV").transform.Find("HeartText5").gameObject.GetComponentInChildren<TextMeshProUGUI>().text}" + "→";
        }
        if (fdm.VioletLove[6] == fdm.max)
        {
            GameObject.Find("UI").transform.Find("Note").transform.Find("ContentArea").transform.Find("Profile").transform.Find("ContentArea").transform.Find("ProfileV").transform.Find("HeartText6").gameObject.GetComponentInChildren<TextMeshProUGUI>().text = $"<color=black>{GameObject.Find("UI").transform.Find("Note").transform.Find("ContentArea").transform.Find("Profile").transform.Find("ContentArea").transform.Find("ProfileV").transform.Find("HeartText6").gameObject.GetComponentInChildren<TextMeshProUGUI>().text}</color>";
        }
        else
        {
            GameObject.Find("UI").transform.Find("Note").transform.Find("ContentArea").transform.Find("Profile").transform.Find("ContentArea").transform.Find("ProfileV").transform.Find("HeartText6").gameObject.GetComponentInChildren<TextMeshProUGUI>().text = $"{GameObject.Find("UI").transform.Find("Note").transform.Find("ContentArea").transform.Find("Profile").transform.Find("ContentArea").transform.Find("ProfileV").transform.Find("HeartText6").gameObject.GetComponentInChildren<TextMeshProUGUI>().text}" + "→";
        }

        //하나 index 4 하트
        fdm.max = fdm.PinkLove.Max();
        List<Heart> PinkLoveIndices = fdm.PinkLoveList.FindAll(element => element.value == fdm.max);
        foreach (Heart h in PinkLoveIndices)
        {
            if (h.Index == 0)
            {
                GameObject.Find("UI").transform.Find("Note").transform.Find("ContentArea").transform.Find("Profile").transform.Find("ContentArea").transform.Find("ProfileP").transform.Find("Heart1").gameObject.SetActive(true);
            }
            if (h.Index == 1)
            {
                GameObject.Find("UI").transform.Find("Note").transform.Find("ContentArea").transform.Find("Profile").transform.Find("ContentArea").transform.Find("ProfileP").transform.Find("Heart2").gameObject.SetActive(true);
            }
            if (h.Index == 2)
            {
                GameObject.Find("UI").transform.Find("Note").transform.Find("ContentArea").transform.Find("Profile").transform.Find("ContentArea").transform.Find("ProfileP").transform.Find("Heart3").gameObject.SetActive(true);
            }
            if (h.Index == 3)
            {
                GameObject.Find("UI").transform.Find("Note").transform.Find("ContentArea").transform.Find("Profile").transform.Find("ContentArea").transform.Find("ProfileP").transform.Find("Heart4").gameObject.SetActive(true);
            }
            if (h.Index == 5)
            {
                GameObject.Find("UI").transform.Find("Note").transform.Find("ContentArea").transform.Find("Profile").transform.Find("ContentArea").transform.Find("ProfileP").transform.Find("Heart5").gameObject.SetActive(true);
            }
            if (h.Index == 6)
            {
                GameObject.Find("UI").transform.Find("Note").transform.Find("ContentArea").transform.Find("Profile").transform.Find("ContentArea").transform.Find("ProfileP").transform.Find("Heart6").gameObject.SetActive(true);
            }
        }
        //하나 호감도
        GameObject.Find("UI").transform.Find("Note").transform.Find("ContentArea").transform.Find("Profile").transform.Find("ContentArea").transform.Find("ProfileP").transform.Find("HeartText1").gameObject.GetComponentInChildren<TextMeshProUGUI>().text = fdm.PinkLove[0].ToString();
        GameObject.Find("UI").transform.Find("Note").transform.Find("ContentArea").transform.Find("Profile").transform.Find("ContentArea").transform.Find("ProfileP").transform.Find("HeartText2").gameObject.GetComponentInChildren<TextMeshProUGUI>().text = fdm.PinkLove[1].ToString();
        GameObject.Find("UI").transform.Find("Note").transform.Find("ContentArea").transform.Find("Profile").transform.Find("ContentArea").transform.Find("ProfileP").transform.Find("HeartText3").gameObject.GetComponentInChildren<TextMeshProUGUI>().text = fdm.PinkLove[2].ToString();
        GameObject.Find("UI").transform.Find("Note").transform.Find("ContentArea").transform.Find("Profile").transform.Find("ContentArea").transform.Find("ProfileP").transform.Find("HeartText4").gameObject.GetComponentInChildren<TextMeshProUGUI>().text = fdm.PinkLove[3].ToString();
        GameObject.Find("UI").transform.Find("Note").transform.Find("ContentArea").transform.Find("Profile").transform.Find("ContentArea").transform.Find("ProfileP").transform.Find("HeartText5").gameObject.GetComponentInChildren<TextMeshProUGUI>().text = fdm.PinkLove[5].ToString();
        GameObject.Find("UI").transform.Find("Note").transform.Find("ContentArea").transform.Find("Profile").transform.Find("ContentArea").transform.Find("ProfileP").transform.Find("HeartText6").gameObject.GetComponentInChildren<TextMeshProUGUI>().text = fdm.PinkLove[6].ToString();

        //하나 index 4 글자색
        if (fdm.PinkLove[0] == fdm.max)
        {
            GameObject.Find("UI").transform.Find("Note").transform.Find("ContentArea").transform.Find("Profile").transform.Find("ContentArea").transform.Find("ProfileP").transform.Find("HeartText1").gameObject.GetComponentInChildren<TextMeshProUGUI>().text = $"<color=black>{GameObject.Find("UI").transform.Find("Note").transform.Find("ContentArea").transform.Find("Profile").transform.Find("ContentArea").transform.Find("ProfileP").transform.Find("HeartText1").gameObject.GetComponentInChildren<TextMeshProUGUI>().text}</color>";
        }
        else
        {
            GameObject.Find("UI").transform.Find("Note").transform.Find("ContentArea").transform.Find("Profile").transform.Find("ContentArea").transform.Find("ProfileP").transform.Find("HeartText1").gameObject.GetComponentInChildren<TextMeshProUGUI>().text = $"{GameObject.Find("UI").transform.Find("Note").transform.Find("ContentArea").transform.Find("Profile").transform.Find("ContentArea").transform.Find("ProfileP").transform.Find("HeartText1").gameObject.GetComponentInChildren<TextMeshProUGUI>().text}" + "→";
        }
        if (fdm.PinkLove[1] == fdm.max)
        {
            GameObject.Find("UI").transform.Find("Note").transform.Find("ContentArea").transform.Find("Profile").transform.Find("ContentArea").transform.Find("ProfileP").transform.Find("HeartText2").gameObject.GetComponentInChildren<TextMeshProUGUI>().text = $"<color=black>{GameObject.Find("UI").transform.Find("Note").transform.Find("ContentArea").transform.Find("Profile").transform.Find("ContentArea").transform.Find("ProfileP").transform.Find("HeartText2").gameObject.GetComponentInChildren<TextMeshProUGUI>().text}</color>";
        }
        else
        {
            GameObject.Find("UI").transform.Find("Note").transform.Find("ContentArea").transform.Find("Profile").transform.Find("ContentArea").transform.Find("ProfileP").transform.Find("HeartText2").gameObject.GetComponentInChildren<TextMeshProUGUI>().text = $"{GameObject.Find("UI").transform.Find("Note").transform.Find("ContentArea").transform.Find("Profile").transform.Find("ContentArea").transform.Find("ProfileP").transform.Find("HeartText2").gameObject.GetComponentInChildren<TextMeshProUGUI>().text}" + "→";
        }
        if (fdm.PinkLove[2] == fdm.max)
        {
            GameObject.Find("UI").transform.Find("Note").transform.Find("ContentArea").transform.Find("Profile").transform.Find("ContentArea").transform.Find("ProfileP").transform.Find("HeartText3").gameObject.GetComponentInChildren<TextMeshProUGUI>().text = $"<color=black>{GameObject.Find("UI").transform.Find("Note").transform.Find("ContentArea").transform.Find("Profile").transform.Find("ContentArea").transform.Find("ProfileP").transform.Find("HeartText3").gameObject.GetComponentInChildren<TextMeshProUGUI>().text}</color>";
        }
        else
        {
            GameObject.Find("UI").transform.Find("Note").transform.Find("ContentArea").transform.Find("Profile").transform.Find("ContentArea").transform.Find("ProfileP").transform.Find("HeartText3").gameObject.GetComponentInChildren<TextMeshProUGUI>().text = $"{GameObject.Find("UI").transform.Find("Note").transform.Find("ContentArea").transform.Find("Profile").transform.Find("ContentArea").transform.Find("ProfileP").transform.Find("HeartText3").gameObject.GetComponentInChildren<TextMeshProUGUI>().text}" + "→";
        }
        if (fdm.PinkLove[3] == fdm.max)
        {
            GameObject.Find("UI").transform.Find("Note").transform.Find("ContentArea").transform.Find("Profile").transform.Find("ContentArea").transform.Find("ProfileP").transform.Find("HeartText4").gameObject.GetComponentInChildren<TextMeshProUGUI>().text = $"<color=black>{GameObject.Find("UI").transform.Find("Note").transform.Find("ContentArea").transform.Find("Profile").transform.Find("ContentArea").transform.Find("ProfileP").transform.Find("HeartText4").gameObject.GetComponentInChildren<TextMeshProUGUI>().text}</color>";
        }
        else
        {
            GameObject.Find("UI").transform.Find("Note").transform.Find("ContentArea").transform.Find("Profile").transform.Find("ContentArea").transform.Find("ProfileP").transform.Find("HeartText4").gameObject.GetComponentInChildren<TextMeshProUGUI>().text = $"{GameObject.Find("UI").transform.Find("Note").transform.Find("ContentArea").transform.Find("Profile").transform.Find("ContentArea").transform.Find("ProfileP").transform.Find("HeartText4").gameObject.GetComponentInChildren<TextMeshProUGUI>().text}" + "→";
        }
        if (fdm.PinkLove[5] == fdm.max)
        {
            GameObject.Find("UI").transform.Find("Note").transform.Find("ContentArea").transform.Find("Profile").transform.Find("ContentArea").transform.Find("ProfileP").transform.Find("HeartText5").gameObject.GetComponentInChildren<TextMeshProUGUI>().text = $"<color=black>{GameObject.Find("UI").transform.Find("Note").transform.Find("ContentArea").transform.Find("Profile").transform.Find("ContentArea").transform.Find("ProfileP").transform.Find("HeartText5").gameObject.GetComponentInChildren<TextMeshProUGUI>().text}</color>";
        }
        else
        {
            GameObject.Find("UI").transform.Find("Note").transform.Find("ContentArea").transform.Find("Profile").transform.Find("ContentArea").transform.Find("ProfileP").transform.Find("HeartText5").gameObject.GetComponentInChildren<TextMeshProUGUI>().text = $"{GameObject.Find("UI").transform.Find("Note").transform.Find("ContentArea").transform.Find("Profile").transform.Find("ContentArea").transform.Find("ProfileP").transform.Find("HeartText5").gameObject.GetComponentInChildren<TextMeshProUGUI>().text}" + "→";
        }
        if (fdm.PinkLove[6] == fdm.max)
        {
            GameObject.Find("UI").transform.Find("Note").transform.Find("ContentArea").transform.Find("Profile").transform.Find("ContentArea").transform.Find("ProfileP").transform.Find("HeartText6").gameObject.GetComponentInChildren<TextMeshProUGUI>().text = $"<color=black>{GameObject.Find("UI").transform.Find("Note").transform.Find("ContentArea").transform.Find("Profile").transform.Find("ContentArea").transform.Find("ProfileP").transform.Find("HeartText6").gameObject.GetComponentInChildren<TextMeshProUGUI>().text}</color>";
        }
        else
        {
            GameObject.Find("UI").transform.Find("Note").transform.Find("ContentArea").transform.Find("Profile").transform.Find("ContentArea").transform.Find("ProfileP").transform.Find("HeartText6").gameObject.GetComponentInChildren<TextMeshProUGUI>().text = $"{GameObject.Find("UI").transform.Find("Note").transform.Find("ContentArea").transform.Find("Profile").transform.Find("ContentArea").transform.Find("ProfileP").transform.Find("HeartText6").gameObject.GetComponentInChildren<TextMeshProUGUI>().text}" + "→";
        }

        //시우 index 5 하트
        fdm.max = fdm.YellowLove.Max();
        List<Heart> YellowLoveIndices = fdm.YellowLoveList.FindAll(element => element.value == fdm.max);
        foreach (Heart h in YellowLoveIndices)
        {
            if (h.Index == 0)
            {
                GameObject.Find("UI").transform.Find("Note").transform.Find("ContentArea").transform.Find("Profile").transform.Find("ContentArea").transform.Find("ProfileY").transform.Find("Heart1").gameObject.SetActive(true);
            }
            if (h.Index == 1)
            {
                GameObject.Find("UI").transform.Find("Note").transform.Find("ContentArea").transform.Find("Profile").transform.Find("ContentArea").transform.Find("ProfileY").transform.Find("Heart2").gameObject.SetActive(true);
            }
            if (h.Index == 2)
            {
                GameObject.Find("UI").transform.Find("Note").transform.Find("ContentArea").transform.Find("Profile").transform.Find("ContentArea").transform.Find("ProfileY").transform.Find("Heart3").gameObject.SetActive(true);
            }
            if (h.Index == 3)
            {
                GameObject.Find("UI").transform.Find("Note").transform.Find("ContentArea").transform.Find("Profile").transform.Find("ContentArea").transform.Find("ProfileY").transform.Find("Heart4").gameObject.SetActive(true);
            }
            if (h.Index == 4)
            {
                GameObject.Find("UI").transform.Find("Note").transform.Find("ContentArea").transform.Find("Profile").transform.Find("ContentArea").transform.Find("ProfileY").transform.Find("Heart5").gameObject.SetActive(true);
            }
            if (h.Index == 6)
            {
                GameObject.Find("UI").transform.Find("Note").transform.Find("ContentArea").transform.Find("Profile").transform.Find("ContentArea").transform.Find("ProfileY").transform.Find("Heart6").gameObject.SetActive(true);
            }
        }
        //시우 호감도
        GameObject.Find("UI").transform.Find("Note").transform.Find("ContentArea").transform.Find("Profile").transform.Find("ContentArea").transform.Find("ProfileY").transform.Find("HeartText1").gameObject.GetComponentInChildren<TextMeshProUGUI>().text = fdm.YellowLove[0].ToString();
        GameObject.Find("UI").transform.Find("Note").transform.Find("ContentArea").transform.Find("Profile").transform.Find("ContentArea").transform.Find("ProfileY").transform.Find("HeartText2").gameObject.GetComponentInChildren<TextMeshProUGUI>().text = fdm.YellowLove[1].ToString();
        GameObject.Find("UI").transform.Find("Note").transform.Find("ContentArea").transform.Find("Profile").transform.Find("ContentArea").transform.Find("ProfileY").transform.Find("HeartText3").gameObject.GetComponentInChildren<TextMeshProUGUI>().text = fdm.YellowLove[2].ToString();
        GameObject.Find("UI").transform.Find("Note").transform.Find("ContentArea").transform.Find("Profile").transform.Find("ContentArea").transform.Find("ProfileY").transform.Find("HeartText4").gameObject.GetComponentInChildren<TextMeshProUGUI>().text = fdm.YellowLove[3].ToString();
        GameObject.Find("UI").transform.Find("Note").transform.Find("ContentArea").transform.Find("Profile").transform.Find("ContentArea").transform.Find("ProfileY").transform.Find("HeartText5").gameObject.GetComponentInChildren<TextMeshProUGUI>().text = fdm.YellowLove[4].ToString();
        GameObject.Find("UI").transform.Find("Note").transform.Find("ContentArea").transform.Find("Profile").transform.Find("ContentArea").transform.Find("ProfileY").transform.Find("HeartText6").gameObject.GetComponentInChildren<TextMeshProUGUI>().text = fdm.YellowLove[6].ToString();

        //시우 index 5 글자색
        if (fdm.YellowLove[0] == fdm.max)
        {
            GameObject.Find("UI").transform.Find("Note").transform.Find("ContentArea").transform.Find("Profile").transform.Find("ContentArea").transform.Find("ProfileY").transform.Find("HeartText1").gameObject.GetComponentInChildren<TextMeshProUGUI>().text = $"<color=black>{GameObject.Find("UI").transform.Find("Note").transform.Find("ContentArea").transform.Find("Profile").transform.Find("ContentArea").transform.Find("ProfileY").transform.Find("HeartText1").gameObject.GetComponentInChildren<TextMeshProUGUI>().text}</color>";
        }
        else
        {
            GameObject.Find("UI").transform.Find("Note").transform.Find("ContentArea").transform.Find("Profile").transform.Find("ContentArea").transform.Find("ProfileY").transform.Find("HeartText1").gameObject.GetComponentInChildren<TextMeshProUGUI>().text = $"{GameObject.Find("UI").transform.Find("Note").transform.Find("ContentArea").transform.Find("Profile").transform.Find("ContentArea").transform.Find("ProfileY").transform.Find("HeartText1").gameObject.GetComponentInChildren<TextMeshProUGUI>().text}" + "→";
        }
        if (fdm.YellowLove[1] == fdm.max)
        {
            GameObject.Find("UI").transform.Find("Note").transform.Find("ContentArea").transform.Find("Profile").transform.Find("ContentArea").transform.Find("ProfileY").transform.Find("HeartText2").gameObject.GetComponentInChildren<TextMeshProUGUI>().text = $"<color=black>{GameObject.Find("UI").transform.Find("Note").transform.Find("ContentArea").transform.Find("Profile").transform.Find("ContentArea").transform.Find("ProfileY").transform.Find("HeartText2").gameObject.GetComponentInChildren<TextMeshProUGUI>().text}</color>";
        }
        else
        {
            GameObject.Find("UI").transform.Find("Note").transform.Find("ContentArea").transform.Find("Profile").transform.Find("ContentArea").transform.Find("ProfileY").transform.Find("HeartText2").gameObject.GetComponentInChildren<TextMeshProUGUI>().text = $"{GameObject.Find("UI").transform.Find("Note").transform.Find("ContentArea").transform.Find("Profile").transform.Find("ContentArea").transform.Find("ProfileY").transform.Find("HeartText2").gameObject.GetComponentInChildren<TextMeshProUGUI>().text}" + "→";
        }
        if (fdm.YellowLove[2] == fdm.max)
        {
            GameObject.Find("UI").transform.Find("Note").transform.Find("ContentArea").transform.Find("Profile").transform.Find("ContentArea").transform.Find("ProfileY").transform.Find("HeartText3").gameObject.GetComponentInChildren<TextMeshProUGUI>().text = $"<color=black>{GameObject.Find("UI").transform.Find("Note").transform.Find("ContentArea").transform.Find("Profile").transform.Find("ContentArea").transform.Find("ProfileY").transform.Find("HeartText3").gameObject.GetComponentInChildren<TextMeshProUGUI>().text}</color>";
        }
        else
        {
            GameObject.Find("UI").transform.Find("Note").transform.Find("ContentArea").transform.Find("Profile").transform.Find("ContentArea").transform.Find("ProfileY").transform.Find("HeartText3").gameObject.GetComponentInChildren<TextMeshProUGUI>().text = $"{GameObject.Find("UI").transform.Find("Note").transform.Find("ContentArea").transform.Find("Profile").transform.Find("ContentArea").transform.Find("ProfileY").transform.Find("HeartText3").gameObject.GetComponentInChildren<TextMeshProUGUI>().text}" + "→";
        }
        if (fdm.YellowLove[3] == fdm.max)
        {
            GameObject.Find("UI").transform.Find("Note").transform.Find("ContentArea").transform.Find("Profile").transform.Find("ContentArea").transform.Find("ProfileY").transform.Find("HeartText4").gameObject.GetComponentInChildren<TextMeshProUGUI>().text = $"<color=black>{GameObject.Find("UI").transform.Find("Note").transform.Find("ContentArea").transform.Find("Profile").transform.Find("ContentArea").transform.Find("ProfileY").transform.Find("HeartText4").gameObject.GetComponentInChildren<TextMeshProUGUI>().text}</color>";
        }
        else
        {
            GameObject.Find("UI").transform.Find("Note").transform.Find("ContentArea").transform.Find("Profile").transform.Find("ContentArea").transform.Find("ProfileY").transform.Find("HeartText4").gameObject.GetComponentInChildren<TextMeshProUGUI>().text = $"{GameObject.Find("UI").transform.Find("Note").transform.Find("ContentArea").transform.Find("Profile").transform.Find("ContentArea").transform.Find("ProfileY").transform.Find("HeartText4").gameObject.GetComponentInChildren<TextMeshProUGUI>().text}" + "→";
        }
        if (fdm.YellowLove[5] == fdm.max)
        {
            GameObject.Find("UI").transform.Find("Note").transform.Find("ContentArea").transform.Find("Profile").transform.Find("ContentArea").transform.Find("ProfileY").transform.Find("HeartText5").gameObject.GetComponentInChildren<TextMeshProUGUI>().text = $"<color=black>{GameObject.Find("UI").transform.Find("Note").transform.Find("ContentArea").transform.Find("Profile").transform.Find("ContentArea").transform.Find("ProfileY").transform.Find("HeartText5").gameObject.GetComponentInChildren<TextMeshProUGUI>().text}</color>";
        }
        else
        {
            GameObject.Find("UI").transform.Find("Note").transform.Find("ContentArea").transform.Find("Profile").transform.Find("ContentArea").transform.Find("ProfileY").transform.Find("HeartText5").gameObject.GetComponentInChildren<TextMeshProUGUI>().text = $"{GameObject.Find("UI").transform.Find("Note").transform.Find("ContentArea").transform.Find("Profile").transform.Find("ContentArea").transform.Find("ProfileY").transform.Find("HeartText5").gameObject.GetComponentInChildren<TextMeshProUGUI>().text}" + "→";
        }
        if (fdm.YellowLove[6] == fdm.max)
        {
            GameObject.Find("UI").transform.Find("Note").transform.Find("ContentArea").transform.Find("Profile").transform.Find("ContentArea").transform.Find("ProfileY").transform.Find("HeartText6").gameObject.GetComponentInChildren<TextMeshProUGUI>().text = $"<color=black>{GameObject.Find("UI").transform.Find("Note").transform.Find("ContentArea").transform.Find("Profile").transform.Find("ContentArea").transform.Find("ProfileY").transform.Find("HeartText6").gameObject.GetComponentInChildren<TextMeshProUGUI>().text}</color>";
        }
        else
        {
            GameObject.Find("UI").transform.Find("Note").transform.Find("ContentArea").transform.Find("Profile").transform.Find("ContentArea").transform.Find("ProfileY").transform.Find("HeartText6").gameObject.GetComponentInChildren<TextMeshProUGUI>().text = $"{GameObject.Find("UI").transform.Find("Note").transform.Find("ContentArea").transform.Find("Profile").transform.Find("ContentArea").transform.Find("ProfileY").transform.Find("HeartText6").gameObject.GetComponentInChildren<TextMeshProUGUI>().text}" + "→";
        }
    }

    public void HeartSetFalse()
    {
        Debug.Log("HeartSetFalse");
        //가영 R
        GameObject.Find("UI").transform.Find("Note").transform.Find("ContentArea").transform.Find("Profile").transform.Find("ContentArea").transform.Find("ProfileR").transform.Find("Heart1").gameObject.SetActive(false);
        GameObject.Find("UI").transform.Find("Note").transform.Find("ContentArea").transform.Find("Profile").transform.Find("ContentArea").transform.Find("ProfileR").transform.Find("Heart2").gameObject.SetActive(false);
        GameObject.Find("UI").transform.Find("Note").transform.Find("ContentArea").transform.Find("Profile").transform.Find("ContentArea").transform.Find("ProfileR").transform.Find("Heart3").gameObject.SetActive(false);
        GameObject.Find("UI").transform.Find("Note").transform.Find("ContentArea").transform.Find("Profile").transform.Find("ContentArea").transform.Find("ProfileR").transform.Find("Heart4").gameObject.SetActive(false);
        GameObject.Find("UI").transform.Find("Note").transform.Find("ContentArea").transform.Find("Profile").transform.Find("ContentArea").transform.Find("ProfileR").transform.Find("Heart5").gameObject.SetActive(false);
        GameObject.Find("UI").transform.Find("Note").transform.Find("ContentArea").transform.Find("Profile").transform.Find("ContentArea").transform.Find("ProfileR").transform.Find("Heart6").gameObject.SetActive(false);

        //서준 G
        GameObject.Find("UI").transform.Find("Note").transform.Find("ContentArea").transform.Find("Profile").transform.Find("ContentArea").transform.Find("ProfileG").transform.Find("Heart1").gameObject.SetActive(false);
        GameObject.Find("UI").transform.Find("Note").transform.Find("ContentArea").transform.Find("Profile").transform.Find("ContentArea").transform.Find("ProfileG").transform.Find("Heart2").gameObject.SetActive(false);
        GameObject.Find("UI").transform.Find("Note").transform.Find("ContentArea").transform.Find("Profile").transform.Find("ContentArea").transform.Find("ProfileG").transform.Find("Heart3").gameObject.SetActive(false);
        GameObject.Find("UI").transform.Find("Note").transform.Find("ContentArea").transform.Find("Profile").transform.Find("ContentArea").transform.Find("ProfileG").transform.Find("Heart4").gameObject.SetActive(false);
        GameObject.Find("UI").transform.Find("Note").transform.Find("ContentArea").transform.Find("Profile").transform.Find("ContentArea").transform.Find("ProfileG").transform.Find("Heart5").gameObject.SetActive(false);
        GameObject.Find("UI").transform.Find("Note").transform.Find("ContentArea").transform.Find("Profile").transform.Find("ContentArea").transform.Find("ProfileG").transform.Find("Heart6").gameObject.SetActive(false);

        //테오 B
        GameObject.Find("UI").transform.Find("Note").transform.Find("ContentArea").transform.Find("Profile").transform.Find("ContentArea").transform.Find("ProfileB").transform.Find("Heart1").gameObject.SetActive(false);
        GameObject.Find("UI").transform.Find("Note").transform.Find("ContentArea").transform.Find("Profile").transform.Find("ContentArea").transform.Find("ProfileB").transform.Find("Heart2").gameObject.SetActive(false);
        GameObject.Find("UI").transform.Find("Note").transform.Find("ContentArea").transform.Find("Profile").transform.Find("ContentArea").transform.Find("ProfileB").transform.Find("Heart3").gameObject.SetActive(false);
        GameObject.Find("UI").transform.Find("Note").transform.Find("ContentArea").transform.Find("Profile").transform.Find("ContentArea").transform.Find("ProfileB").transform.Find("Heart4").gameObject.SetActive(false);
        GameObject.Find("UI").transform.Find("Note").transform.Find("ContentArea").transform.Find("Profile").transform.Find("ContentArea").transform.Find("ProfileB").transform.Find("Heart5").gameObject.SetActive(false);
        GameObject.Find("UI").transform.Find("Note").transform.Find("ContentArea").transform.Find("Profile").transform.Find("ContentArea").transform.Find("ProfileB").transform.Find("Heart6").gameObject.SetActive(false);

        //유이 V
        GameObject.Find("UI").transform.Find("Note").transform.Find("ContentArea").transform.Find("Profile").transform.Find("ContentArea").transform.Find("ProfileV").transform.Find("Heart1").gameObject.SetActive(false);
        GameObject.Find("UI").transform.Find("Note").transform.Find("ContentArea").transform.Find("Profile").transform.Find("ContentArea").transform.Find("ProfileV").transform.Find("Heart2").gameObject.SetActive(false);
        GameObject.Find("UI").transform.Find("Note").transform.Find("ContentArea").transform.Find("Profile").transform.Find("ContentArea").transform.Find("ProfileV").transform.Find("Heart3").gameObject.SetActive(false);
        GameObject.Find("UI").transform.Find("Note").transform.Find("ContentArea").transform.Find("Profile").transform.Find("ContentArea").transform.Find("ProfileV").transform.Find("Heart4").gameObject.SetActive(false);
        GameObject.Find("UI").transform.Find("Note").transform.Find("ContentArea").transform.Find("Profile").transform.Find("ContentArea").transform.Find("ProfileV").transform.Find("Heart5").gameObject.SetActive(false);
        GameObject.Find("UI").transform.Find("Note").transform.Find("ContentArea").transform.Find("Profile").transform.Find("ContentArea").transform.Find("ProfileV").transform.Find("Heart6").gameObject.SetActive(false);

        //하나 P 
        GameObject.Find("UI").transform.Find("Note").transform.Find("ContentArea").transform.Find("Profile").transform.Find("ContentArea").transform.Find("ProfileP").transform.Find("Heart1").gameObject.SetActive(false);
        GameObject.Find("UI").transform.Find("Note").transform.Find("ContentArea").transform.Find("Profile").transform.Find("ContentArea").transform.Find("ProfileP").transform.Find("Heart2").gameObject.SetActive(false);
        GameObject.Find("UI").transform.Find("Note").transform.Find("ContentArea").transform.Find("Profile").transform.Find("ContentArea").transform.Find("ProfileP").transform.Find("Heart3").gameObject.SetActive(false);
        GameObject.Find("UI").transform.Find("Note").transform.Find("ContentArea").transform.Find("Profile").transform.Find("ContentArea").transform.Find("ProfileP").transform.Find("Heart4").gameObject.SetActive(false);
        GameObject.Find("UI").transform.Find("Note").transform.Find("ContentArea").transform.Find("Profile").transform.Find("ContentArea").transform.Find("ProfileP").transform.Find("Heart5").gameObject.SetActive(false);
        GameObject.Find("UI").transform.Find("Note").transform.Find("ContentArea").transform.Find("Profile").transform.Find("ContentArea").transform.Find("ProfileP").transform.Find("Heart6").gameObject.SetActive(false);

        //시우 Y
        GameObject.Find("UI").transform.Find("Note").transform.Find("ContentArea").transform.Find("Profile").transform.Find("ContentArea").transform.Find("ProfileY").transform.Find("Heart1").gameObject.SetActive(false);
        GameObject.Find("UI").transform.Find("Note").transform.Find("ContentArea").transform.Find("Profile").transform.Find("ContentArea").transform.Find("ProfileY").transform.Find("Heart2").gameObject.SetActive(false);
        GameObject.Find("UI").transform.Find("Note").transform.Find("ContentArea").transform.Find("Profile").transform.Find("ContentArea").transform.Find("ProfileY").transform.Find("Heart3").gameObject.SetActive(false);
        GameObject.Find("UI").transform.Find("Note").transform.Find("ContentArea").transform.Find("Profile").transform.Find("ContentArea").transform.Find("ProfileY").transform.Find("Heart4").gameObject.SetActive(false);
        GameObject.Find("UI").transform.Find("Note").transform.Find("ContentArea").transform.Find("Profile").transform.Find("ContentArea").transform.Find("ProfileY").transform.Find("Heart5").gameObject.SetActive(false);
        GameObject.Find("UI").transform.Find("Note").transform.Find("ContentArea").transform.Find("Profile").transform.Find("ContentArea").transform.Find("ProfileY").transform.Find("Heart6").gameObject.SetActive(false);
    }
}
