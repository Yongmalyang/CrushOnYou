using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GDataReset : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        DataController.Instance.gameData.GOver = true;
        DataController.Instance.gameData.Gday = 1;
        DataController.Instance.gameData.Gturn = 4;
        DataController.Instance.gameData.Genergy = 20;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
