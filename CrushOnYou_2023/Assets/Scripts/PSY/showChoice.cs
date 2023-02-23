using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class showChoice : MonoBehaviour
{
    public TMP_Text myChoice;
    void Start()
    {
        int myLover = DataController.Instance.gameData.myLover;

        switch(myLover){
            case 0 : myChoice.text = "가영"; break;
            case 1 : myChoice.text = "서준"; break;
            case 2 : myChoice.text = "테오"; break;
            case 3 : myChoice.text = "유이"; break;
            case 4 : myChoice.text = "하나"; break;
            case 5 : myChoice.text = "시우"; break;
        }
    }

}
