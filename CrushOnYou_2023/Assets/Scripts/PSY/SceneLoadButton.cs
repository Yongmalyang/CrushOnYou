using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoadButton : MonoBehaviour
{
    public void loadScene(){
        SceneManager.LoadScene("PlaceScene_PSY");
        DataController.Instance.gameData.turn++; //턴 증가
    }
}
