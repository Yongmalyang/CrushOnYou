using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AllReset : MonoBehaviour
{
    // Start is called before the first frame update
    public void AllResetBtn()
    {
        DataController.Instance.gameData.playedBefore = false;
        DataController.Instance.gameData.WPlayedBefore = false;
        DataController.Instance.gameData.turn = 0;
        DataController.Instance.gameData.GPlayedBefore = false;
        DataController.Instance.gameData.GOver = false;
        DataController.Instance.gameData.Submit = false;
        DataController.Instance.gameData.Gday = 1;
        DataController.Instance.gameData.Gturn = 4;
        DataController.Instance.gameData.Genergy = 20;
    }
}
