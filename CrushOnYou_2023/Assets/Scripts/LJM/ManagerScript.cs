using System.Collections;
using System.Collections.Generic;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using UnityEngine;
using TMPro;

public class ManagerScript : MonoBehaviour
{
    public string mark = "O";
    public GameObject Note;

    private void Update()
    {
    }
    public void GetButtonName()
    {
        string ButtonName = EventSystem.current.currentSelectedGameObject.name;
        if (ButtonName == "ButtonO")
        {
            mark ="O";

        }
        else if (ButtonName == "ButtonX")
        {
            mark = "X";
        }
        else
        {
            mark = "E";
        }
        Debug.Log(mark);

    }
    
    public void SetButtonMark()
    {
        GameObject clickedButton = EventSystem.current.currentSelectedGameObject;
        if(mark == "E")
        {
            clickedButton.GetComponentInChildren<TextMeshProUGUI>().text = "";
        }
        else
        {

            clickedButton.GetComponentInChildren<TextMeshProUGUI>().text = mark;
        }
    }

    //추리턴함수
    public void GuessNoteOpenClose()
    {
        Note = GameObject.Find("UI").transform.Find("Note").gameObject;
        if (Note.activeSelf == false)
        {
            GameObject.Find("UI").transform.Find("Note").gameObject.SetActive(true);
        }
        else
        {
            GameObject.Find("UI").transform.Find("Note").gameObject.SetActive(false);
        }
    }


    //공략턴 함수
    public void FlirtNoteOpenClose()
    {
        Note = GameObject.Find("Panel").transform.Find("Note").gameObject;
        if (Note.activeSelf == false)
        {
            GameObject.Find("Panel").transform.Find("Note").gameObject.SetActive(true);
        }
        else
        {
            GameObject.Find("Panel").transform.Find("Note").gameObject.SetActive(false);
        }
    }


}
