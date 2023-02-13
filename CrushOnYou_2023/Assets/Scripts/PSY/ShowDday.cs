using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ShowDday : MonoBehaviour // 남은 턴 표시
{
    public TMP_Text Dday;
    private void Awake() {
        Dday.text = $"방학까지 D-{DataController.Instance.gameData.maxTurn - DataController.Instance.gameData.turn}";
    }

}
