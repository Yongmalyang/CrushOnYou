using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetPlayedBefore : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        DataController.Instance.gameData.GPlayedBefore = true;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
