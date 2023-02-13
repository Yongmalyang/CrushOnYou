using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndingScene : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        DataController.Instance.gameData.turn = 0;
    }

}
