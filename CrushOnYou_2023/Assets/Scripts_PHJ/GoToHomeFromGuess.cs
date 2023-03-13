using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GoToHomeFromGuess : MonoBehaviour
{

    public GameObject DigController, BackgroundMgr, QMake;

    public void GotoHome()
    {
        if(SceneManager.GetActiveScene().name == "Guess")
        {
            Destroy(BackgroundMgr);
            Destroy(QMake);
            Destroy(DigController);
            SceneManager.LoadScene("Start_LJY");
        }
    }

    
}
