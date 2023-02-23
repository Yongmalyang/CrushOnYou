using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChange : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SceneChangeInEpi1Select()
    {
        if(DataController.Instance.gameData.playedBefore == true)
        {
            SceneManager.LoadScene("Guess");
        }
        else
        {
            SceneManager.LoadScene("Prologue");
        }
    }

    public void SceneChangeInEpi2Select()
    {
        if(DataController.Instance.gameData.WPlayedBefore == true)
        {
            SceneManager.LoadScene("PlaceScene_PSY");
        }
        else
        {
            SceneManager.LoadScene("SelectChar_PSY");
        }
    }

   
}
