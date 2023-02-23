using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using static Define;

public class GameSceneManager :  MonoBehaviour
{
    public static GameSceneManager instance;

    public string nextscene; 


    public void SceneChange()
    {
       
        SceneManager.LoadScene(nextscene);
       
    }

    

}