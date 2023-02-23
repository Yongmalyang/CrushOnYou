using System.Collections;
using System.Collections.Generic;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GuessMusic : MonoBehaviour
{
    private AudioSource Audio;
    public static GuessMusic GuessBGM;
    [SerializeField] private AudioClip[] clip;

    void Start(){
        
        Audio = GetComponent<AudioSource>();
        PlayBgm();
    }

    void Update()
    {
        PlayBgm();

    }

    public void PlayBgm(){

        if(DataController.Instance.gameData.Gturn == 4){
            Audio.clip = clip[0];
            Audio.Play();
            Debug.Log("오전 비지엠");
        }

        else if(DataController.Instance.gameData.Gturn== 3){
            Audio.clip = clip[1];
            Audio.Play();
            Debug.Log("낮 비지엠");
        }
        else if(DataController.Instance.gameData.Gturn == 2){
            Audio.clip = clip[2];
            Audio.Play();
            Debug.Log("오후 비지엠");
        }
        else if(DataController.Instance.gameData.Gturn == 1){
            Audio.clip = clip[3];
            Audio.Play();
            Debug.Log("밤 비지엠");
        }
    }

}