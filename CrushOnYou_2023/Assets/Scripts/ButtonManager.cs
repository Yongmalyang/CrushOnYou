using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonManager : MonoBehaviour
{
    public int id;
    public static bool isAsked;
    public TalkManager talkManager;
    public GameObject talkPanel;
    public GameObject button;

    private void Update() {
        if(isAsked == true){
            button.SetActive(false);
        }    
    }

    public void WhatToAsk()
    {
        if(isAsked == false){
            useCoin();
            talkManager.setID(id);
            talkManager.Action();
            isAsked = true;
        }
    }
    
    public void useCoin()
    {
        if(id == 0){
            DataMgr.instance.coin -= 3;
            Debug.Log(DataMgr.instance.coin);
        }
        else if(id == 1){
            DataMgr.instance.coin -= 5;
            Debug.Log(DataMgr.instance.coin);
        }
        else if(id == 2){
            DataMgr.instance.coin -= 10;
            Debug.Log(DataMgr.instance.coin);
        }
    }

    
}
