using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayBGM_Flirt : MonoBehaviour
{
    private AudioSource Audio;
    public static PlayBGM_Flirt FlirtBGM;
    [SerializeField] private AudioClip[] clip;

    void Awake(){
        
        if(FlirtBGM == null) FlirtBGM = this;

        else if (FlirtBGM != this) Destroy(gameObject);

        DontDestroyOnLoad(gameObject);
        Audio = GetComponent<AudioSource>();
        
    }

    void Update(){

        int turn = DataController.Instance.gameData.turn;

        if(SceneManager.GetActiveScene().name == "PlaceScene_PSY" || SceneManager.GetActiveScene().name == "TalkScene0_PSY" || SceneManager.GetActiveScene().name == "TalkScene1_PSY"){
    
            
        }
        else{
            Debug.Log("파괴");
            Destroy(gameObject);
        }
        if(Audio.isPlaying){
            if(turn >= 5 && turn <10 && Audio.clip != clip[1]){
                PlayBgm();
            }
            else if(turn >= 10 && Audio.clip != clip[2]){
                PlayBgm();
            }
        }
        else PlayBgm();


    }

    public void PlayBgm(){

        if(DataController.Instance.gameData.turn < 5){
            Audio.clip = clip[0];
            Audio.Play();
        }
        else if(DataController.Instance.gameData.turn < 10){
            Audio.clip = clip[1];
            Audio.Play();
        }
        else{
            Audio.clip = clip[2];
            Audio.Play();
        }
    }

}
