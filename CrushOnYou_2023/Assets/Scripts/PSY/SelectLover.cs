using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SelectLover : MonoBehaviour
{
    public int CharIndex;
    public void Select() {

        DataController.Instance.gameData.myLover = CharIndex; //선택한 캐릭터의 번호 저장
        SceneManager.LoadScene("PlaceScene_PSY"); //다음 씬으로 이동
        
    }
}
