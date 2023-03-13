using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayBGM_Ending : MonoBehaviour
{
    private AudioSource Audio;
    GameObject EndingBGM;
    [SerializeField] private AudioClip[] clip;
    void Start()
    {
        Audio = GetComponent<AudioSource>();
        PlayBgm();
    }

    public void PlayBgm(){

        if(DataController.Instance.gameData.endingNum == 1){
            Audio.clip = clip[0];
            Audio.Play();
        }
        else if(DataController.Instance.gameData.endingNum == 2){
            Audio.clip = clip[1];
            Audio.Play();
        }
        else if(DataController.Instance.gameData.endingNum == 3){
            Audio.clip = clip[2];
            Audio.Play();
        }
        else if(DataController.Instance.gameData.endingNum == 4){
            Audio.clip = clip[3];
            Audio.Play();
        }
    }
}
