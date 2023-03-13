using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

//red, green, blue, ourple, pink, yellow


public class SetLoveStat : MonoBehaviour
{
    public static SetLoveStat  instance;

    public static int[] lovewho;
    public static int[] redCanLove;
    public static int[] greenCanLove;
    public static int[] blueCanLove;
    public static int[] purpleCanLove;
    public static int[] pinkCanLove;
    public static int[] yellowCanLove;
    public static int noLove;

    public void Start()
    {
        if(DataController.Instance.gameData.GPlayedBefore == true || DataController.Instance.gameData.WPlayedBefore == true)
        {
            return;
        }
        
        {
            SetStat();
        }
        
    }

    public void SetStat()
    {
        noLove = Random.Range(0, 6);
        redCanLove = new int[] { 1, 2, 3, 4, 5 };
        greenCanLove = new int[] { 0, 2, 3, 4, 5};
        blueCanLove = new int[] { 0, 1, 3, 4, 5 };
        purpleCanLove = new int[] { 0, 1, 2, 4, 5 };
        pinkCanLove = new int[] { 0, 1, 2, 3, 5 };
        yellowCanLove = new int[] { 0, 1, 2, 3, 4 };
        
        


       if(noLove == 0) //red은 아무도 안 좋아할 때
       {
            DataController.Instance.gameData.loveWho = new int[] { 7, greenCanLove[Random.Range(0, 5)], blueCanLove[Random.Range(0, 5)], purpleCanLove[Random.Range(0, 5)], pinkCanLove[Random.Range(0, 5)], yellowCanLove[Random.Range(0, 5)] };

        }
        else if(noLove == 1) // green는 아무도 안 좋아할 때
       {
            DataController.Instance.gameData.loveWho = new int[] { redCanLove[Random.Range(0, 5)], 7, blueCanLove[Random.Range(0, 5)], purpleCanLove[Random.Range(0, 5)], pinkCanLove[Random.Range(0, 5)], yellowCanLove[Random.Range(0, 5)] };

        }
        else if(noLove == 2) // blue는 아무도 안 좋아할 때
       {
            DataController.Instance.gameData.loveWho = new int[] { redCanLove[Random.Range(0, 5)], greenCanLove[Random.Range(0, 5)], 7, purpleCanLove[Random.Range(0, 5)], pinkCanLove[Random.Range(0, 5)], yellowCanLove[Random.Range(0, 5)] };

        }
        else if(noLove == 3) // purple은 아무도 안 좋아할 때
       {
            DataController.Instance.gameData.loveWho = new int[] { redCanLove[Random.Range(0, 5)], greenCanLove[Random.Range(0, 5)], blueCanLove[Random.Range(0, 5)], 7, pinkCanLove[Random.Range(0, 5)], yellowCanLove[Random.Range(0, 5)] };

        }
        else if(noLove == 4) // pink는 아무도 안 좋아할 때
       {
            DataController.Instance.gameData.loveWho = new int[] { redCanLove[Random.Range(0, 5)], greenCanLove[Random.Range(0, 5)], blueCanLove[Random.Range(0, 5)], purpleCanLove[Random.Range(0, 5)], 7, yellowCanLove[Random.Range(0, 5)] };

        }
        else // yellow는 아무도 안 좋아할 때
       {
            DataController.Instance.gameData.loveWho = new int[] { redCanLove[Random.Range(0, 5)], greenCanLove[Random.Range(0, 5)], blueCanLove[Random.Range(0, 5)], purpleCanLove[Random.Range(0, 5)], pinkCanLove[Random.Range(0, 5)], 7 };

        }

    }
} 
    


