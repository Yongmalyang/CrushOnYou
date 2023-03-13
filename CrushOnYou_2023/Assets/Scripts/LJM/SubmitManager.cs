using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using TMPro;
using UnityEngine.SceneManagement;

public class SubmitManager : MonoBehaviour
{
    public int[,] answer = new int[6, 6] { { 0, 0, 0, 0, 0, 0 }, 
                                           { 0, 0, 0, 0, 0, 0 },
                                           { 0, 0, 0, 0, 0, 0 }, 
                                           { 0, 0, 0, 0, 0, 0 }, 
                                           { 0, 0, 0, 0, 0, 0 }, 
                                           { 0, 0, 0, 0, 0, 0 } };

    public int[,] submit = new int[6, 6] { { 0, 0, 0, 0, 0, 0 },
                                           { 0, 0, 0, 0, 0, 0 },
                                           { 0, 0, 0, 0, 0, 0 },
                                           { 0, 0, 0, 0, 0, 0 },
                                           { 0, 0, 0, 0, 0, 0 },
                                           { 0, 0, 0, 0, 0, 0 } };

    private int[] lovewho; //= {1, 5, 7, 4, 2, 1};
    public bool check = true;

    private void Awake()
    {
        lovewho = DataController.Instance.gameData.loveWho;
        Debug.Log(lovewho[0]);
        Debug.Log(lovewho[1]);
        Debug.Log(lovewho[2]);
        Debug.Log(lovewho[3]);
        Debug.Log(lovewho[4]);
        Debug.Log(lovewho[5]);

        SetAnswer();
        DrawSubmitLines();
    }
    private void Update()
    {
        DrawSubmitLines();
    }

    public void SetAnswer()
    {
        if (lovewho[0] == 1)
        {
            answer[0, 1] = 1;
        }
        else if (lovewho[0] == 2)
        {
            answer[0, 2] = 1;
        }
        else if (lovewho[0] == 3)
        {
            answer[0, 3] = 1;
        }
        else if (lovewho[0] == 4)
        {
            answer[0, 4] = 1;
        }
        else if (lovewho[0] == 5)
        {
            answer[0, 5] = 1;
        }
        else
        {

        }

        if (lovewho[1] == 0)
        {
            answer[1, 0] = 1;
        }
        else if (lovewho[1] == 2)
        {
            answer[1, 2] = 1;
        }
        else if (lovewho[1] == 3)
        {
            answer[1, 3] = 1;
        }
        else if (lovewho[1] == 4)
        {
            answer[1, 4] = 1;
        }
        else if (lovewho[1] == 5)
        {
            answer[1, 5] = 1;
        }
        else
        {

        }

        if (lovewho[2] == 0)
        {
            answer[2, 0] = 1;
        }
        else if (lovewho[2] == 1)
        {
            answer[2, 1] = 1;
        }
        else if (lovewho[2] == 3)
        {
            answer[2, 3] = 1;
        }
        else if (lovewho[2] == 4)
        {
            answer[2, 4] = 1;
        }
        else if (lovewho[2] == 5)
        {
            answer[2, 5] = 1;
        }
        else
        {

        }

        if (lovewho[3] == 0)
        {
            answer[3, 0] = 1;
        }
        else if (lovewho[3] == 1)
        {
            answer[3, 1] = 1;
        }
        else if (lovewho[3] == 2)
        {
            answer[3, 2] = 1;
        }
        else if (lovewho[3] == 4)
        {
            answer[3, 4] = 1;
        }
        else if (lovewho[3] == 5)
        {
            answer[3, 5] = 1;
        }
        else
        {

        }

        if (lovewho[4] == 0)
        {
            answer[4, 0] = 1;
        }
        else if (lovewho[4] == 1)
        {
            answer[4, 1] = 1;
        }
        else if (lovewho[4] == 2)
        {
            answer[4, 2] = 1;
        }
        else if (lovewho[4] == 3)
        {
            answer[4, 3] = 1;
        }
        else if (lovewho[4] == 5)
        {
            answer[4, 5] = 1;
        }
        else
        {

        }

        if (lovewho[5] == 0)
        {
            answer[5, 0] = 1;
        }
        else if (lovewho[5] == 1)
        {
            answer[5, 1] = 1;
        }
        else if (lovewho[5] == 2)
        {
            answer[5, 2] = 1;
        }
        else if (lovewho[5] == 3)
        {
            answer[5, 3] = 1;
        }
        else if (lovewho[5] == 4)
        {
            answer[5, 4] = 1;
        }
        else
        {

        }

        for (int i = 0; i < 6; i++)
        {
            for (int j = 0; j < 6; j++)
            {
                Debug.Log(answer[i, j]);
            }
        }
    }

    public void DrawSubmitLines()
    {   //가영 R>G
        if (GameObject.Find("UI").transform.Find("Note").transform.Find("ContentArea").transform.Find("Inference").transform.Find("GridButton").transform.Find("b2").gameObject.GetComponentInChildren<TextMeshProUGUI>().text == "O")
        {
            GameObject.Find("UI").transform.Find("Note").transform.Find("ContentArea").transform.Find("Submit").transform.Find("RArrows").transform.Find("RArrowG").gameObject.SetActive(true);
        }
        else
        {
            GameObject.Find("UI").transform.Find("Note").transform.Find("ContentArea").transform.Find("Submit").transform.Find("RArrows").transform.Find("RArrowG").gameObject.SetActive(false);
        }
        //R>B
        if (GameObject.Find("UI").transform.Find("Note").transform.Find("ContentArea").transform.Find("Inference").transform.Find("GridButton").transform.Find("b3").gameObject.GetComponentInChildren<TextMeshProUGUI>().text == "O")
        {
            GameObject.Find("UI").transform.Find("Note").transform.Find("ContentArea").transform.Find("Submit").transform.Find("RArrows").transform.Find("RArrowB").gameObject.SetActive(true);
        }
        else
        {
           GameObject.Find("UI").transform.Find("Note").transform.Find("ContentArea").transform.Find("Submit").transform.Find("RArrows").transform.Find("RArrowB").gameObject.SetActive(false);
        }
        //R>V
        if (GameObject.Find("UI").transform.Find("Note").transform.Find("ContentArea").transform.Find("Inference").transform.Find("GridButton").transform.Find("b4").gameObject.GetComponentInChildren<TextMeshProUGUI>().text == "O")
        {
            GameObject.Find("UI").transform.Find("Note").transform.Find("ContentArea").transform.Find("Submit").transform.Find("RArrows").transform.Find("RArrowV").gameObject.SetActive(true);
        }
        else
        {
           GameObject.Find("UI").transform.Find("Note").transform.Find("ContentArea").transform.Find("Submit").transform.Find("RArrows").transform.Find("RArrowV").gameObject.SetActive(false);
        }
        //R>P
        if (GameObject.Find("UI").transform.Find("Note").transform.Find("ContentArea").transform.Find("Inference").transform.Find("GridButton").transform.Find("b5").gameObject.GetComponentInChildren<TextMeshProUGUI>().text == "O")
        {
            GameObject.Find("UI").transform.Find("Note").transform.Find("ContentArea").transform.Find("Submit").transform.Find("RArrows").transform.Find("RArrowP").gameObject.SetActive(true);
        }
        else
        {
            GameObject.Find("UI").transform.Find("Note").transform.Find("ContentArea").transform.Find("Submit").transform.Find("RArrows").transform.Find("RArrowP").gameObject.SetActive(false);
        }
        //R>Y
        if (GameObject.Find("UI").transform.Find("Note").transform.Find("ContentArea").transform.Find("Inference").transform.Find("GridButton").transform.Find("b6").gameObject.GetComponentInChildren<TextMeshProUGUI>().text == "O")
        {
            GameObject.Find("UI").transform.Find("Note").transform.Find("ContentArea").transform.Find("Submit").transform.Find("RArrows").transform.Find("RArrowY").gameObject.SetActive(true);
        }
        else
        {
            GameObject.Find("UI").transform.Find("Note").transform.Find("ContentArea").transform.Find("Submit").transform.Find("RArrows").transform.Find("RArrowY").gameObject.SetActive(false);
        }

        //서준 G>R
        if (GameObject.Find("UI").transform.Find("Note").transform.Find("ContentArea").transform.Find("Inference").transform.Find("GridButton").transform.Find("b7").gameObject.GetComponentInChildren<TextMeshProUGUI>().text == "O")
        {
            GameObject.Find("UI").transform.Find("Note").transform.Find("ContentArea").transform.Find("Submit").transform.Find("GArrows").transform.Find("GArrowR").gameObject.SetActive(true);
        }
        else
        {
            GameObject.Find("UI").transform.Find("Note").transform.Find("ContentArea").transform.Find("Submit").transform.Find("GArrows").transform.Find("GArrowR").gameObject.SetActive(false);
        }
        //G>B
        if (GameObject.Find("UI").transform.Find("Note").transform.Find("ContentArea").transform.Find("Inference").transform.Find("GridButton").transform.Find("b9").gameObject.GetComponentInChildren<TextMeshProUGUI>().text == "O")
        {
            GameObject.Find("UI").transform.Find("Note").transform.Find("ContentArea").transform.Find("Submit").transform.Find("GArrows").transform.Find("GArrowB").gameObject.SetActive(true);
        }
        else
        {
            GameObject.Find("UI").transform.Find("Note").transform.Find("ContentArea").transform.Find("Submit").transform.Find("GArrows").transform.Find("GArrowB").gameObject.SetActive(false);
        }
        //G>V
        if (GameObject.Find("UI").transform.Find("Note").transform.Find("ContentArea").transform.Find("Inference").transform.Find("GridButton").transform.Find("b10").gameObject.GetComponentInChildren<TextMeshProUGUI>().text == "O")
        {
            GameObject.Find("UI").transform.Find("Note").transform.Find("ContentArea").transform.Find("Submit").transform.Find("GArrows").transform.Find("GArrowV").gameObject.SetActive(true);
        }
        else
        {
            GameObject.Find("UI").transform.Find("Note").transform.Find("ContentArea").transform.Find("Submit").transform.Find("GArrows").transform.Find("GArrowV").gameObject.SetActive(false);
        }
        //G>P
        if (GameObject.Find("UI").transform.Find("Note").transform.Find("ContentArea").transform.Find("Inference").transform.Find("GridButton").transform.Find("b11").gameObject.GetComponentInChildren<TextMeshProUGUI>().text == "O")
        {
            GameObject.Find("UI").transform.Find("Note").transform.Find("ContentArea").transform.Find("Submit").transform.Find("GArrows").transform.Find("GArrowP").gameObject.SetActive(true);
        }
        else
        {
            GameObject.Find("UI").transform.Find("Note").transform.Find("ContentArea").transform.Find("Submit").transform.Find("GArrows").transform.Find("GArrowP").gameObject.SetActive(false);
        }
        //G>Y
        if (GameObject.Find("UI").transform.Find("Note").transform.Find("ContentArea").transform.Find("Inference").transform.Find("GridButton").transform.Find("b12").gameObject.GetComponentInChildren<TextMeshProUGUI>().text == "O")
        {
            GameObject.Find("UI").transform.Find("Note").transform.Find("ContentArea").transform.Find("Submit").transform.Find("GArrows").transform.Find("GArrowY").gameObject.SetActive(true);
        }
        else
        {
            GameObject.Find("UI").transform.Find("Note").transform.Find("ContentArea").transform.Find("Submit").transform.Find("GArrows").transform.Find("GArrowY").gameObject.SetActive(false);
        }

        //테오 B>R
        if (GameObject.Find("UI").transform.Find("Note").transform.Find("ContentArea").transform.Find("Inference").transform.Find("GridButton").transform.Find("b13").gameObject.GetComponentInChildren<TextMeshProUGUI>().text == "O")
        {
            GameObject.Find("UI").transform.Find("Note").transform.Find("ContentArea").transform.Find("Submit").transform.Find("BArrows").transform.Find("BArrowR").gameObject.SetActive(true);
        }
        else
        {
            GameObject.Find("UI").transform.Find("Note").transform.Find("ContentArea").transform.Find("Submit").transform.Find("BArrows").transform.Find("BArrowR").gameObject.SetActive(false);
        }
        //B>G
        if (GameObject.Find("UI").transform.Find("Note").transform.Find("ContentArea").transform.Find("Inference").transform.Find("GridButton").transform.Find("b14").gameObject.GetComponentInChildren<TextMeshProUGUI>().text == "O")
        {
            GameObject.Find("UI").transform.Find("Note").transform.Find("ContentArea").transform.Find("Submit").transform.Find("BArrows").transform.Find("BArrowG").gameObject.SetActive(true);
        }
        else
        {
            GameObject.Find("UI").transform.Find("Note").transform.Find("ContentArea").transform.Find("Submit").transform.Find("BArrows").transform.Find("BArrowG").gameObject.SetActive(false);
        }
        //B>V
        if (GameObject.Find("UI").transform.Find("Note").transform.Find("ContentArea").transform.Find("Inference").transform.Find("GridButton").transform.Find("b16").gameObject.GetComponentInChildren<TextMeshProUGUI>().text == "O")
        {
            GameObject.Find("UI").transform.Find("Note").transform.Find("ContentArea").transform.Find("Submit").transform.Find("BArrows").transform.Find("BArrowV").gameObject.SetActive(true);
        }
        else
        {
            GameObject.Find("UI").transform.Find("Note").transform.Find("ContentArea").transform.Find("Submit").transform.Find("BArrows").transform.Find("BArrowV").gameObject.SetActive(false);
        }
        //B>P
        if (GameObject.Find("UI").transform.Find("Note").transform.Find("ContentArea").transform.Find("Inference").transform.Find("GridButton").transform.Find("b17").gameObject.GetComponentInChildren<TextMeshProUGUI>().text == "O")
        {
            GameObject.Find("UI").transform.Find("Note").transform.Find("ContentArea").transform.Find("Submit").transform.Find("BArrows").transform.Find("BArrowP").gameObject.SetActive(true);
        }
        else
        {
            GameObject.Find("UI").transform.Find("Note").transform.Find("ContentArea").transform.Find("Submit").transform.Find("BArrows").transform.Find("BArrowP").gameObject.SetActive(false);
        }
        //B>Y
        if (GameObject.Find("UI").transform.Find("Note").transform.Find("ContentArea").transform.Find("Inference").transform.Find("GridButton").transform.Find("b18").gameObject.GetComponentInChildren<TextMeshProUGUI>().text == "O")
        {
            GameObject.Find("UI").transform.Find("Note").transform.Find("ContentArea").transform.Find("Submit").transform.Find("BArrows").transform.Find("BArrowY").gameObject.SetActive(true);
        }
        else
        {
            GameObject.Find("UI").transform.Find("Note").transform.Find("ContentArea").transform.Find("Submit").transform.Find("BArrows").transform.Find("BArrowY").gameObject.SetActive(false);
        }

         //유이 V>R
        if (GameObject.Find("UI").transform.Find("Note").transform.Find("ContentArea").transform.Find("Inference").transform.Find("GridButton").transform.Find("b19").gameObject.GetComponentInChildren<TextMeshProUGUI>().text == "O")
        {
            GameObject.Find("UI").transform.Find("Note").transform.Find("ContentArea").transform.Find("Submit").transform.Find("VArrows").transform.Find("VArrowR").gameObject.SetActive(true);
        }
        else
        {
            GameObject.Find("UI").transform.Find("Note").transform.Find("ContentArea").transform.Find("Submit").transform.Find("VArrows").transform.Find("VArrowR").gameObject.SetActive(false);
        }
        //V>G
        if (GameObject.Find("UI").transform.Find("Note").transform.Find("ContentArea").transform.Find("Inference").transform.Find("GridButton").transform.Find("b20").gameObject.GetComponentInChildren<TextMeshProUGUI>().text == "O")
        {
            GameObject.Find("UI").transform.Find("Note").transform.Find("ContentArea").transform.Find("Submit").transform.Find("VArrows").transform.Find("VArrowG").gameObject.SetActive(true);
        }
        else
        {
            GameObject.Find("UI").transform.Find("Note").transform.Find("ContentArea").transform.Find("Submit").transform.Find("VArrows").transform.Find("VArrowG").gameObject.SetActive(false);
        }
        //V>B
        if (GameObject.Find("UI").transform.Find("Note").transform.Find("ContentArea").transform.Find("Inference").transform.Find("GridButton").transform.Find("b21").gameObject.GetComponentInChildren<TextMeshProUGUI>().text == "O")
        {
            GameObject.Find("UI").transform.Find("Note").transform.Find("ContentArea").transform.Find("Submit").transform.Find("VArrows").transform.Find("VArrowB").gameObject.SetActive(true);
        }
        else
        {
            GameObject.Find("UI").transform.Find("Note").transform.Find("ContentArea").transform.Find("Submit").transform.Find("VArrows").transform.Find("VArrowB").gameObject.SetActive(false);
        }
        //V>P
        if (GameObject.Find("UI").transform.Find("Note").transform.Find("ContentArea").transform.Find("Inference").transform.Find("GridButton").transform.Find("b23").gameObject.GetComponentInChildren<TextMeshProUGUI>().text == "O")
        {
            GameObject.Find("UI").transform.Find("Note").transform.Find("ContentArea").transform.Find("Submit").transform.Find("VArrows").transform.Find("VArrowP").gameObject.SetActive(true);
        }
        else
        {
            GameObject.Find("UI").transform.Find("Note").transform.Find("ContentArea").transform.Find("Submit").transform.Find("VArrows").transform.Find("VArrowP").gameObject.SetActive(false);
        }
        //V>Y
        if (GameObject.Find("UI").transform.Find("Note").transform.Find("ContentArea").transform.Find("Inference").transform.Find("GridButton").transform.Find("b24").gameObject.GetComponentInChildren<TextMeshProUGUI>().text == "O")
        {
            GameObject.Find("UI").transform.Find("Note").transform.Find("ContentArea").transform.Find("Submit").transform.Find("VArrows").transform.Find("VArrowY").gameObject.SetActive(true);
        }
        else
        {
            GameObject.Find("UI").transform.Find("Note").transform.Find("ContentArea").transform.Find("Submit").transform.Find("VArrows").transform.Find("VArrowY").gameObject.SetActive(false);
        }

        //하나 P>R
        if (GameObject.Find("UI").transform.Find("Note").transform.Find("ContentArea").transform.Find("Inference").transform.Find("GridButton").transform.Find("b25").gameObject.GetComponentInChildren<TextMeshProUGUI>().text == "O")
        {
            GameObject.Find("UI").transform.Find("Note").transform.Find("ContentArea").transform.Find("Submit").transform.Find("PArrows").transform.Find("PArrowR").gameObject.SetActive(true);
        }
        else
        {
            GameObject.Find("UI").transform.Find("Note").transform.Find("ContentArea").transform.Find("Submit").transform.Find("PArrows").transform.Find("PArrowR").gameObject.SetActive(false);
        }
        //P>G
        if (GameObject.Find("UI").transform.Find("Note").transform.Find("ContentArea").transform.Find("Inference").transform.Find("GridButton").transform.Find("b26").gameObject.GetComponentInChildren<TextMeshProUGUI>().text == "O")
        {
            GameObject.Find("UI").transform.Find("Note").transform.Find("ContentArea").transform.Find("Submit").transform.Find("PArrows").transform.Find("PArrowG").gameObject.SetActive(true);
        }
        else
        {
            GameObject.Find("UI").transform.Find("Note").transform.Find("ContentArea").transform.Find("Submit").transform.Find("PArrows").transform.Find("PArrowG").gameObject.SetActive(false);
        }
        //P>B
        if (GameObject.Find("UI").transform.Find("Note").transform.Find("ContentArea").transform.Find("Inference").transform.Find("GridButton").transform.Find("b27").gameObject.GetComponentInChildren<TextMeshProUGUI>().text == "O")
        {
            GameObject.Find("UI").transform.Find("Note").transform.Find("ContentArea").transform.Find("Submit").transform.Find("PArrows").transform.Find("PArrowB").gameObject.SetActive(true);
        }
        else
        {
            GameObject.Find("UI").transform.Find("Note").transform.Find("ContentArea").transform.Find("Submit").transform.Find("PArrows").transform.Find("PArrowB").gameObject.SetActive(false);
        }
        //P>V
        if (GameObject.Find("UI").transform.Find("Note").transform.Find("ContentArea").transform.Find("Inference").transform.Find("GridButton").transform.Find("b28").gameObject.GetComponentInChildren<TextMeshProUGUI>().text == "O")
        {
            GameObject.Find("UI").transform.Find("Note").transform.Find("ContentArea").transform.Find("Submit").transform.Find("PArrows").transform.Find("PArrowV").gameObject.SetActive(true);
        }
        else
        {
            GameObject.Find("UI").transform.Find("Note").transform.Find("ContentArea").transform.Find("Submit").transform.Find("PArrows").transform.Find("PArrowV").gameObject.SetActive(false);
        }
        //P>Y
        if (GameObject.Find("UI").transform.Find("Note").transform.Find("ContentArea").transform.Find("Inference").transform.Find("GridButton").transform.Find("b30").gameObject.GetComponentInChildren<TextMeshProUGUI>().text == "O")
        {
            GameObject.Find("UI").transform.Find("Note").transform.Find("ContentArea").transform.Find("Submit").transform.Find("PArrows").transform.Find("PArrowY").gameObject.SetActive(true);
        }
        else
        {
            GameObject.Find("UI").transform.Find("Note").transform.Find("ContentArea").transform.Find("Submit").transform.Find("PArrows").transform.Find("PArrowY").gameObject.SetActive(false);
        }

        //시우 Y>R
        if (GameObject.Find("UI").transform.Find("Note").transform.Find("ContentArea").transform.Find("Inference").transform.Find("GridButton").transform.Find("b31").gameObject.GetComponentInChildren<TextMeshProUGUI>().text == "O")
        {
            GameObject.Find("UI").transform.Find("Note").transform.Find("ContentArea").transform.Find("Submit").transform.Find("YArrows").transform.Find("YArrowR").gameObject.SetActive(true);
        }
        else
        {
            GameObject.Find("UI").transform.Find("Note").transform.Find("ContentArea").transform.Find("Submit").transform.Find("YArrows").transform.Find("YArrowR").gameObject.SetActive(false);
        }
        //Y>G
        if (GameObject.Find("UI").transform.Find("Note").transform.Find("ContentArea").transform.Find("Inference").transform.Find("GridButton").transform.Find("b32").gameObject.GetComponentInChildren<TextMeshProUGUI>().text == "O")
        {
            GameObject.Find("UI").transform.Find("Note").transform.Find("ContentArea").transform.Find("Submit").transform.Find("YArrows").transform.Find("YArrowG").gameObject.SetActive(true);
        }
        else
        {
            GameObject.Find("UI").transform.Find("Note").transform.Find("ContentArea").transform.Find("Submit").transform.Find("YArrows").transform.Find("YArrowG").gameObject.SetActive(false);
        }
        //Y>B
        if (GameObject.Find("UI").transform.Find("Note").transform.Find("ContentArea").transform.Find("Inference").transform.Find("GridButton").transform.Find("b33").gameObject.GetComponentInChildren<TextMeshProUGUI>().text == "O")
        {
            GameObject.Find("UI").transform.Find("Note").transform.Find("ContentArea").transform.Find("Submit").transform.Find("YArrows").transform.Find("YArrowB").gameObject.SetActive(true);
        }
        else
        {
            GameObject.Find("UI").transform.Find("Note").transform.Find("ContentArea").transform.Find("Submit").transform.Find("YArrows").transform.Find("YArrowB").gameObject.SetActive(false);
        }
        //Y>V
        if (GameObject.Find("UI").transform.Find("Note").transform.Find("ContentArea").transform.Find("Inference").transform.Find("GridButton").transform.Find("b34").gameObject.GetComponentInChildren<TextMeshProUGUI>().text == "O")
        {
            GameObject.Find("UI").transform.Find("Note").transform.Find("ContentArea").transform.Find("Submit").transform.Find("YArrows").transform.Find("YArrowV").gameObject.SetActive(true);
        }
        else
        {
            GameObject.Find("UI").transform.Find("Note").transform.Find("ContentArea").transform.Find("Submit").transform.Find("YArrows").transform.Find("YArrowV").gameObject.SetActive(false);
        }
        //Y>P
        if (GameObject.Find("UI").transform.Find("Note").transform.Find("ContentArea").transform.Find("Inference").transform.Find("GridButton").transform.Find("b35").gameObject.GetComponentInChildren<TextMeshProUGUI>().text == "O")
        {
            GameObject.Find("UI").transform.Find("Note").transform.Find("ContentArea").transform.Find("Submit").transform.Find("YArrows").transform.Find("YArrowP").gameObject.SetActive(true);
        }
        else
        {
            GameObject.Find("UI").transform.Find("Note").transform.Find("ContentArea").transform.Find("Submit").transform.Find("YArrows").transform.Find("YArrowP").gameObject.SetActive(false);
        }
    }

    public void Submit()
    {
        //가영
        if (GameObject.Find("UI").transform.Find("Note").transform.Find("ContentArea").transform.Find("Inference").transform.Find("GridButton").transform.Find("b2").gameObject.GetComponentInChildren<TextMeshProUGUI>().text == "O")
        {
            submit[0, 1] = 1;
        }
        else
        {
            submit[0, 1] = 0;
        }
        if (GameObject.Find("UI").transform.Find("Note").transform.Find("ContentArea").transform.Find("Inference").transform.Find("GridButton").transform.Find("b3").gameObject.GetComponentInChildren<TextMeshProUGUI>().text == "O")
        {
            submit[0, 2] = 1;
        }
        else
        {
            submit[0, 2] = 0;
        }
        if (GameObject.Find("UI").transform.Find("Note").transform.Find("ContentArea").transform.Find("Inference").transform.Find("GridButton").transform.Find("b4").gameObject.GetComponentInChildren<TextMeshProUGUI>().text == "O")
        {
            submit[0, 3] = 1;
        }
        else
        {
            submit[0, 3] = 0;
        }
        if (GameObject.Find("UI").transform.Find("Note").transform.Find("ContentArea").transform.Find("Inference").transform.Find("GridButton").transform.Find("b5").gameObject.GetComponentInChildren<TextMeshProUGUI>().text == "O")
        {
            submit[0, 4] = 1;
        }
        else
        {
            submit[0, 4] = 0;
        }
        if (GameObject.Find("UI").transform.Find("Note").transform.Find("ContentArea").transform.Find("Inference").transform.Find("GridButton").transform.Find("b6").gameObject.GetComponentInChildren<TextMeshProUGUI>().text == "O")
        {
            submit[0, 5] = 1;
        }
        else
        {
            submit[0, 5] = 0;
        }
        //서준
        if (GameObject.Find("UI").transform.Find("Note").transform.Find("ContentArea").transform.Find("Inference").transform.Find("GridButton").transform.Find("b7").gameObject.GetComponentInChildren<TextMeshProUGUI>().text == "O")
        {
            submit[1, 0] = 1;
        }
        else
        {
            submit[1, 0] = 0;
        }
        if (GameObject.Find("UI").transform.Find("Note").transform.Find("ContentArea").transform.Find("Inference").transform.Find("GridButton").transform.Find("b9").gameObject.GetComponentInChildren<TextMeshProUGUI>().text == "O")
        {
            submit[1, 2] = 1;
        }
        else
        {
            submit[1, 2] = 0;
        }
        if (GameObject.Find("UI").transform.Find("Note").transform.Find("ContentArea").transform.Find("Inference").transform.Find("GridButton").transform.Find("b10").gameObject.GetComponentInChildren<TextMeshProUGUI>().text == "O")
        {
            submit[1, 3] = 1;
        }
        else
        {
            submit[1, 3] = 0;
        }
        if (GameObject.Find("UI").transform.Find("Note").transform.Find("ContentArea").transform.Find("Inference").transform.Find("GridButton").transform.Find("b11").gameObject.GetComponentInChildren<TextMeshProUGUI>().text == "O")
        {
            submit[1, 4] = 1;
        }
        else
        {
            submit[1, 4] = 0;
        }
        if (GameObject.Find("UI").transform.Find("Note").transform.Find("ContentArea").transform.Find("Inference").transform.Find("GridButton").transform.Find("b12").gameObject.GetComponentInChildren<TextMeshProUGUI>().text == "O")
        {
            submit[1, 5] = 1;
        }
        else
        {
            submit[1, 5] = 0;
        }
        //테오
        if (GameObject.Find("UI").transform.Find("Note").transform.Find("ContentArea").transform.Find("Inference").transform.Find("GridButton").transform.Find("b13").gameObject.GetComponentInChildren<TextMeshProUGUI>().text == "O")
        {
            submit[2, 0] = 1;
        }
        else
        {
            submit[2, 0] = 0;
        }
        if (GameObject.Find("UI").transform.Find("Note").transform.Find("ContentArea").transform.Find("Inference").transform.Find("GridButton").transform.Find("b14").gameObject.GetComponentInChildren<TextMeshProUGUI>().text == "O")
        {
            submit[2, 1] = 1;
        }
        else
        {
            submit[2, 1] = 0;
        }
        if (GameObject.Find("UI").transform.Find("Note").transform.Find("ContentArea").transform.Find("Inference").transform.Find("GridButton").transform.Find("b16").gameObject.GetComponentInChildren<TextMeshProUGUI>().text == "O")
        {
            submit[2, 3] = 1;
        }
        else
        {
            submit[2, 3] = 0;
        }
        if (GameObject.Find("UI").transform.Find("Note").transform.Find("ContentArea").transform.Find("Inference").transform.Find("GridButton").transform.Find("b17").gameObject.GetComponentInChildren<TextMeshProUGUI>().text == "O")
        {
            submit[2, 4] = 1;
        }
        else
        {
            submit[2, 4] = 0;
        }
        if (GameObject.Find("UI").transform.Find("Note").transform.Find("ContentArea").transform.Find("Inference").transform.Find("GridButton").transform.Find("b18").gameObject.GetComponentInChildren<TextMeshProUGUI>().text == "O")
        {
            submit[2, 5] = 1;
        }
        else
        {
            submit[2, 5] = 0;
        }
        //유이
        if (GameObject.Find("UI").transform.Find("Note").transform.Find("ContentArea").transform.Find("Inference").transform.Find("GridButton").transform.Find("b19").gameObject.GetComponentInChildren<TextMeshProUGUI>().text == "O")
        {
            submit[3, 0] = 1;
        }
        else
        {
            submit[3, 0] = 0;
        }
        if (GameObject.Find("UI").transform.Find("Note").transform.Find("ContentArea").transform.Find("Inference").transform.Find("GridButton").transform.Find("b20").gameObject.GetComponentInChildren<TextMeshProUGUI>().text == "O")
        {
            submit[3, 1] = 1;
        }
        else
        {
            submit[3, 1] = 0;
        }
        if (GameObject.Find("UI").transform.Find("Note").transform.Find("ContentArea").transform.Find("Inference").transform.Find("GridButton").transform.Find("b21").gameObject.GetComponentInChildren<TextMeshProUGUI>().text == "O")
        {
            submit[3, 2] = 1;
        }
        else
        {
            submit[3, 2] = 0;
        }
        if (GameObject.Find("UI").transform.Find("Note").transform.Find("ContentArea").transform.Find("Inference").transform.Find("GridButton").transform.Find("b23").gameObject.GetComponentInChildren<TextMeshProUGUI>().text == "O")
        {
            submit[3, 4] = 1;
        }
        else
        {
            submit[3, 4] = 0;
        }
        if (GameObject.Find("UI").transform.Find("Note").transform.Find("ContentArea").transform.Find("Inference").transform.Find("GridButton").transform.Find("b24").gameObject.GetComponentInChildren<TextMeshProUGUI>().text == "O")
        {
            submit[3, 5] = 1;
        }
        else
        {
            submit[3, 5] = 0;
        }
        //하나
        if (GameObject.Find("UI").transform.Find("Note").transform.Find("ContentArea").transform.Find("Inference").transform.Find("GridButton").transform.Find("b25").gameObject.GetComponentInChildren<TextMeshProUGUI>().text == "O")
        {
            submit[4, 0] = 1;
        }
        else
        {
            submit[4, 0] = 0;
        }
        if (GameObject.Find("UI").transform.Find("Note").transform.Find("ContentArea").transform.Find("Inference").transform.Find("GridButton").transform.Find("b26").gameObject.GetComponentInChildren<TextMeshProUGUI>().text == "O")
        {
            submit[4, 1] = 1;
        }
        else
        {
            submit[4, 1] = 0;
        }
        if (GameObject.Find("UI").transform.Find("Note").transform.Find("ContentArea").transform.Find("Inference").transform.Find("GridButton").transform.Find("b27").gameObject.GetComponentInChildren<TextMeshProUGUI>().text == "O")
        {
            submit[4, 2] = 1;
        }
        else
        {
            submit[4, 2] = 0;
        }
        if (GameObject.Find("UI").transform.Find("Note").transform.Find("ContentArea").transform.Find("Inference").transform.Find("GridButton").transform.Find("b28").gameObject.GetComponentInChildren<TextMeshProUGUI>().text == "O")
        {
            submit[4, 3] = 1;
        }
        else
        {
            submit[4, 3] = 0;
        }
        if (GameObject.Find("UI").transform.Find("Note").transform.Find("ContentArea").transform.Find("Inference").transform.Find("GridButton").transform.Find("b30").gameObject.GetComponentInChildren<TextMeshProUGUI>().text == "O")
        {
            submit[4, 5] = 1;
        }
        else
        {
            submit[4, 5] = 0;
        }
        //시우
        if (GameObject.Find("UI").transform.Find("Note").transform.Find("ContentArea").transform.Find("Inference").transform.Find("GridButton").transform.Find("b31").gameObject.GetComponentInChildren<TextMeshProUGUI>().text == "O")
        {
            submit[5, 0] = 1;
        }
        else
        {
            submit[5, 0] = 0;
        }
        if (GameObject.Find("UI").transform.Find("Note").transform.Find("ContentArea").transform.Find("Inference").transform.Find("GridButton").transform.Find("b32").gameObject.GetComponentInChildren<TextMeshProUGUI>().text == "O")
        {
            submit[5, 1] = 1;
        }
        else
        {
            submit[5, 1] = 0;
        }
        if (GameObject.Find("UI").transform.Find("Note").transform.Find("ContentArea").transform.Find("Inference").transform.Find("GridButton").transform.Find("b33").gameObject.GetComponentInChildren<TextMeshProUGUI>().text == "O")
        {
            submit[5, 2] = 1;
        }
        else
        {
            submit[5, 2] = 0;
        }
        if (GameObject.Find("UI").transform.Find("Note").transform.Find("ContentArea").transform.Find("Inference").transform.Find("GridButton").transform.Find("b34").gameObject.GetComponentInChildren<TextMeshProUGUI>().text == "O")
        {
            submit[5, 3] = 1;
        }
        else
        {
            submit[5, 3] = 0;
        }
        if (GameObject.Find("UI").transform.Find("Note").transform.Find("ContentArea").transform.Find("Inference").transform.Find("GridButton").transform.Find("b35").gameObject.GetComponentInChildren<TextMeshProUGUI>().text == "O")
        {
            submit[5, 4] = 1;
        }
        else
        {
            submit[5, 4] = 0;
        }

        check = true;
        for (int i = 0; i < 6; i++)
        {
            for (int j = 0; j < 6; j++)
            {
                Debug.Log(submit[i,j]);
                if (answer[i, j] != submit[i, j])
                {
                    check = false;
                }
            }
        }

        if (check == true)
        {
            Debug.Log("정답입니다!!");
            SceneManager.LoadScene("SelectChar_PSY");
        }
        else
        {
            Debug.Log("틀렸습니다!!");
            SceneManager.LoadScene("GameOver");

        }

    }
}
