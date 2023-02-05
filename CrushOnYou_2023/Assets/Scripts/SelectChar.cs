using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SelectChar : MonoBehaviour
{
    public Character character;
    
    void Start()
    {
        
    }

    private void OnMouseUpAsButton()
    {
        
        DataMgr.instance.currentCharacter = character;
        DataMgr.instance.loveWho = CharManage.instance.SetStat(character);
        Debug.Log("온클릭 실행" + DataMgr.instance.currentCharacter);
        Debug.Log("짝사랑 방향" + DataMgr.instance.loveWho[0] + " " + DataMgr.instance.loveWho[1] + " " +  DataMgr.instance.loveWho[2] 
            + " " +  DataMgr.instance.loveWho[3] + " " + DataMgr.instance.loveWho[4]);
        SceneManager.LoadScene("TalkSelect");

    }
}
