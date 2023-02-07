using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

//red, green, blue, purple, pink


public class CharManage : MonoBehaviour
{

    public static CharManage instance;

    public static int[] lovewho;
    public static int[] redCanLove;
    public static int[] greenCanLove;
    public static int[] blueCanLove;
    public static int[] purpleCanLove;
    public static int[] pinkCanLove;
    public static int noLove;

    private void Awake()
    {
        if (instance == null) instance = this;
        else if (instance != null) return;
        DontDestroyOnLoad(gameObject);
    }

    public int[] SetStat(Character current)
    {
        switch  (current)
        {
            //내 캐릭터로 red 선택
            case (Character.red):
                greenCanLove = new int[] { 2, 3, 4 };
                blueCanLove = new int[] { 1, 3, 4 };
                purpleCanLove = new int[] { 1, 2, 4 };
                pinkCanLove = new int[] { 1, 2, 3 };

                //나를 제외하고 위의 순서대로 0, 1, 2, 3으로 놓음
                noLove = Random.Range(0, 3);

                if(noLove == 0) //green은 아무도 안 좋아할 때
                {
                    lovewho = new int[] { 7, 7, blueCanLove[Random.Range(0, 2)], purpleCanLove[Random.Range(0, 2)], pinkCanLove[Random.Range(0, 2)] };
                }
                else if(noLove == 1) // blue는 아무도 안 좋아할 때
                {
                    lovewho = new int[] { 7, greenCanLove[Random.Range(0, 2)], 7, purpleCanLove[Random.Range(0, 2)], pinkCanLove[Random.Range(0, 2)] };
                }
                else if(noLove == 2) // purple은 아무도 안 좋아할 때
                {
                    lovewho = new int[] { 7, greenCanLove[Random.Range(0, 2)], blueCanLove[Random.Range(0, 2)], 7, pinkCanLove[Random.Range(0, 2)] };
                }
                else if(noLove == 3) // pink는 아무도 안 좋아할 때
                {
                    lovewho = new int[] { 7, greenCanLove[Random.Range(0, 2)], blueCanLove[Random.Range(0, 2)], purpleCanLove[Random.Range(0, 2)], 7 };
                }
                break;

            //내 캐릭터로 green 선택
            case (Character.green):

                redCanLove = new int[] { 2, 3, 4 };
                blueCanLove = new int[] { 0, 3, 4 };
                purpleCanLove = new int[] { 0, 2, 4 };
                pinkCanLove = new int[] { 0, 2, 3 };

                //나를 제외하고 위의 순서대로 0, 1, 2, 3으로 놓음
                noLove = Random.Range(0, 4);
               
                if(noLove == 0) // red는 아무도 안 좋아할 때
                {
                    lovewho = new int[] { 7, 7, blueCanLove[Random.Range(0, 2)], purpleCanLove[Random.Range(0, 2)], pinkCanLove[Random.Range(0, 2)] };
                }
                else if(noLove == 1) // blue는 아무도 안 좋아할 때
                {
                    lovewho = new int[] { redCanLove[Random.Range(0, 2)], 7, 7, purpleCanLove[Random.Range(0, 2)], pinkCanLove[Random.Range(0, 2)] };
                }
                else if(noLove == 2) // purple은 아무도 안 좋아할 때
                {
                    lovewho = new int[] { redCanLove[Random.Range(0, 2)], 7, blueCanLove[Random.Range(0, 2)], 7, pinkCanLove[Random.Range(0, 2)] };
                }
                else if(noLove == 3) // pink는 아무도 안 좋아할 때
                {
                    lovewho = new int[] { redCanLove[Random.Range(0, 2)], 7, blueCanLove[Random.Range(0, 2)], purpleCanLove[Random.Range(0, 2)], 7};
                }
                
                break;

            //내 캐릭터로 blue 선택
            case (Character.blue):

                redCanLove = new int[] { 1, 3, 4 };
                greenCanLove = new int[] { 0, 3, 4 };
                purpleCanLove = new int[] { 0, 1, 4 };
                pinkCanLove = new int[] { 0, 1, 3, };

                //나를 제외하고 위의 순서대로 0, 1, 2, 3으로 놓음
                noLove = Random.Range(0, 3);

                if (noLove == 0) //red은 아무도 안 좋아할 때
                {
                    lovewho = new int[] { 7, greenCanLove[Random.Range(0, 2)], 7, purpleCanLove[Random.Range(0, 2)], pinkCanLove[Random.Range(0, 2)] };
                }
                else if (noLove == 1) // green는 아무도 안 좋아할 때
                {
                    lovewho = new int[] { redCanLove[Random.Range(0, 2)], 7, 7, purpleCanLove[Random.Range(0, 2)], pinkCanLove[Random.Range(0, 2)] };
                }
                else if (noLove == 2) // purple은 아무도 안 좋아할 때
                {
                    lovewho = new int[] { redCanLove[Random.Range(0, 2)], greenCanLove[Random.Range(0, 2)], 7, 7, pinkCanLove[Random.Range(0, 2)] };
                }
                else if (noLove == 3) // pink는 아무도 안 좋아할 때
                {
                    lovewho = new int[] { redCanLove[Random.Range(0, 2)], greenCanLove[Random.Range(0, 2)], 7, purpleCanLove[Random.Range(0, 2)], 7 };
                }
                break;
            

            //내 캐릭터로 purple 선택
            case (Character.purple):

                redCanLove = new int[] { 1, 2, 4 };
                greenCanLove = new int[] { 0, 2, 4 };
                blueCanLove = new int[] { 0, 1, 4 };
                pinkCanLove = new int[] { 0, 1, 2 };

                //나를 제외하고 위의 순서대로 0, 1, 2, 3으로 놓음
                noLove = Random.Range(0, 3);

                if (noLove == 0) //red은 아무도 안 좋아할 때
                {
                    lovewho = new int[] { 7, greenCanLove[Random.Range(0, 2)], blueCanLove[Random.Range(0, 2)], 7, pinkCanLove[Random.Range(0, 2)] };
                }
                else if (noLove == 1) // green는 아무도 안 좋아할 때
                {
                    lovewho = new int[] { redCanLove[Random.Range(0, 2)], 7, blueCanLove[Random.Range(0, 2)], 7, pinkCanLove[Random.Range(0, 2)] };
                }
                else if (noLove == 2) // blue은 아무도 안 좋아할 때
                {
                    lovewho = new int[] { redCanLove[Random.Range(0, 2)], greenCanLove[Random.Range(0, 2)], 7, 7, pinkCanLove[Random.Range(0, 2)] };
                }
                else if (noLove == 3) // pink는 아무도 안 좋아할 때
                {
                    lovewho = new int[] { redCanLove[Random.Range(0, 2)], greenCanLove[Random.Range(0, 2)], blueCanLove[Random.Range(0, 2)], 7, 7 };
                }
                break;
             

            //내 캐릭터로 pink 선택
            case (Character.pink):

                redCanLove = new int[] { 1, 2, 3 };
                greenCanLove = new int[] { 0, 2, 3 };
                blueCanLove = new int[] { 0, 1, 3 };
                purpleCanLove = new int[] { 0, 1, 2 };

                //나를 제외하고 위의 순서대로 0, 1, 2, 3으로 놓음
                noLove = Random.Range(0, 3);

                if (noLove == 0) //red은 아무도 안 좋아할 때
                {
                    lovewho = new int[] { 7, greenCanLove[Random.Range(0, 2)], blueCanLove[Random.Range(0, 2)], purpleCanLove[Random.Range(0, 2)], 7 };
                }
                else if (noLove == 1) // green는 아무도 안 좋아할 때
                {
                    lovewho = new int[] { redCanLove[Random.Range(0, 2)], 7, blueCanLove[Random.Range(0, 2)], purpleCanLove[Random.Range(0, 2)], 7 };
                }
                else if (noLove == 2) // blue은 아무도 안 좋아할 때
                {
                    lovewho = new int[] { redCanLove[Random.Range(0, 2)], greenCanLove[Random.Range(0, 2)], 7, purpleCanLove[Random.Range(0, 2)], 7 };
                }
                else if (noLove == 3) // purple는 아무도 안 좋아할 때
                {
                    lovewho = new int[] { redCanLove[Random.Range(0, 2)], greenCanLove[Random.Range(0, 2)], blueCanLove[Random.Range(0, 2)], 7, 7 };
                }
                break;


            default:
                break;
        }

        //테스트용!!!! 지워야됨!!!!!
        lovewho[0]=2; lovewho[1]=2; lovewho[2]=0; lovewho[3]=2; lovewho[4]=2; 
        return lovewho;
    }
} 
    


