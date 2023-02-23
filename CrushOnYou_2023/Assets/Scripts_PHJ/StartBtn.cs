using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartBtn : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void StartButton()
    {
        //if(DataController.Instance.gameData.playedBefore == true)
        //{
        //    SceneManager.LoadScene("EpiSelectNew");
        //}
        //else
        //{
            SceneManager.LoadScene("Prologue");
        //}
    }
}
