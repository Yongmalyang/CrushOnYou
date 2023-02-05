using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class ScriptManager : MonoBehaviour
{
    public static string test = "dd";
    public static int[] loveWho = DataMgr.instance.loveWho;
    public static string[,] lovers_info = new string [6,3] 
    {
        {"열정적인", "아침운동", "배구부"}, //red 0
        {"냉철한", "바이올린 연주", "반장"}, //green 1
        {"소심한", "혼코노", "댄스부"}, // blue 2
        {"사려깊은", "사진 찍기", "도서부"}, // purple 3
        {"귀여운", "드라마 정주행", "방송부"}, // pink 4
        {"자신만의 세계가 확고한", "인디밴드", "미술부"}
    }; //캐릭터 특성

    public static int GetRandomNumber(int pp) //https://unity-programmer.tistory.com/32
        {
            var exclude = new HashSet<int>() {loveWho[pp]};
            var range = Enumerable.Range(0, 4).Where(i => !exclude.Contains(i));

            var rand = new System.Random();
            int index = rand.Next(0, 4 - exclude.Count);
            return range.ElementAt(index);
        }

#region red

    public static List<List<List<string>>> Red = new List<List<List<string>>>(){

        new List<List<string>> {
            new List<string> {"글쎄...", $"난 {lovers_info[GetRandomNumber(0),0]} 사람과는 잘 안맞는 것 같아."},
            new List<string> {"음...", $"난 {lovers_info[GetRandomNumber(0),1]}에는 별로 관심이 안 생기더라고.."},
        },

        new List<List<string>>(){
            new List<string> {$"요즘 {test}랑 {test}가 좀 수상해.."},
        },

        new List<List<string>>(){
            new List<string> {"좋아하는 사람?", $"난 {lovers_info[loveWho[0],0]} 사람이 좋아."},
            new List<string> {"나는...",$"{lovers_info[loveWho[0],1]}(을/를) 좋아하는 사람이 멋있어 보이더라고"},
        },
    };

#endregion

#region blue
    public static List<List<List<string>>> Blue = new List<List<List<string>>>(){

        new List<List<string>> {
            new List<string> {"글쎄...?", $"난 {lovers_info[GetRandomNumber(2),0]} 사람과는 잘 안맞는 것 같아.?"},
            new List<string> {"음...?", $"난 {lovers_info[GetRandomNumber(2),1]}에는 별로 관심이 안 생기더라고..?"},
        },

        new List<List<string>>(){
            new List<string> {$"요즘 {test}랑 {test}가 좀 수상해..?"},
        },

        new List<List<string>>(){
            new List<string> {"좋아하는 사람??", $"난 {lovers_info[loveWho[2],0]} 사람이 좋아.?"},
            new List<string> {"나는...?",$"{lovers_info[loveWho[2],1]}(을/를) 좋아하는 사람이 멋있어 보이더라고?"},
        },
    };
#endregion

}
