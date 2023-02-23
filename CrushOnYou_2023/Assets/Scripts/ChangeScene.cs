using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class ChangeScene : MonoBehaviour
{
    public void ToChooseEpisode()
    {
        SceneManager.LoadScene("EpisodeSelect");
    }

    public void BackToMain()
    {
        SceneManager.LoadScene("Start_LJY");
    }

    public void ToPrologue()
    {
        SceneManager.LoadScene("Prologue");
    }
}
