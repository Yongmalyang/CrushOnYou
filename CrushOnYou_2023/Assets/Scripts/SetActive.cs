using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SetActive : MonoBehaviour
{

    public Character character;
    public int index;
    public GameObject Target;
    // Start is called before the first frame update
    void Start()
    {
        Target.SetActive(true);
        if(DataMgr.instance.currentCharacter == character)
        {
            Target.SetActive(false);
        }
    }

    private void OnMouseUpAsButton() {
        Debug.Log("클릭");
        TalkManager.ppToTalk = index;
        DontDestroyOnLoad(Target);
        SceneManager.LoadScene("TalkScene");
    }
}
