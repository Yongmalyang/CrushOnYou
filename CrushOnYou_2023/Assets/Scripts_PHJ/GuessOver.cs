using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GuessOver : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        if(DataMgr.instance.day == 11)
        {
            SceneManager.LoadScene("GuessEnd");            
        }
        
    }
}
