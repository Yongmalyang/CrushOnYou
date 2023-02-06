using System.Collections;
using System.Collections.Generic;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using UnityEngine;
using TMPro;

public class ManagerScript : MonoBehaviour
{
    public string mark = "O";
    public GameObject targetObject;

    public void setNote()
    {
        string ButtonName = EventSystem.current.currentSelectedGameObject.name;
        if (ButtonName == "BookMarkInference")
        {
            targetObject = GameObject.FindWithTag("Profile");
            //targetObject.gameObject.SetActive(false);
            Debug.Log(targetObject.GetComponent<TextMeshProUGUI>().text);
        }
        else if (ButtonName == "BookMarkSubmit")
        {
            /*targetObject = GameObject.Find("Profile");
            targetObject.gameObject.SetActive(false);
            targetObject = GameObject.Find("Inference");
            targetObject.gameObject.SetActive(false);*/
            Debug.Log(targetObject.GetComponent<TextMeshProUGUI>().text);
        }
        else if(ButtonName == "BookMarkProfile")
        {
            /*targetObject = GameObject.Find("Profile");
            targetObject.gameObject.SetActive(true);*/
            Debug.Log(targetObject.GetComponent<TextMeshProUGUI>().text);
        }
        Debug.Log("Note Changed");
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
}