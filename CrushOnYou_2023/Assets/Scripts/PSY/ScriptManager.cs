using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptManager
{
    public class TalkInfo{
        public string name;
        public List<string> talk;
    }
    public static Dictionary<string, TalkInfo> ScriptsInfo = new Dictionary<string, TalkInfo>(){

        {"0운동", new TalkInfo{name = "배수정", talk = new List<string>(){"운동 선택했을 때", "레드가 하는 말"}}},
        {"1운동", new TalkInfo{name = "도서준", talk = new List<string>(){"운동 선택했을 때", "블루가 하는 말"}}},
        {"2운동", new TalkInfo{name = "장민혁", talk = new List<string>(){"운동 선택했을 때", "그린이 하는 말"}}},
        {"3운동", new TalkInfo{name = "민예리", talk = new List<string>(){"운동 선택했을 때", "옐로가 하는 말"}}},
        {"4운동", new TalkInfo{name = "송현주", talk = new List<string>(){"운동 선택했을 때", "핑크가 하는 말"}}},
        {"5운동", new TalkInfo{name = "김연호", talk = new List<string>(){"운동 선택했을 때", "퍼플이 하는 말"}}},

        {"0필름 카메라", new TalkInfo{name = "배수정", talk = new List<string>(){"필름카메라 선택했을 때", "레드가 하는 말"}}},
        {"1필름 카메라", new TalkInfo{name = "도서준", talk = new List<string>(){"필름카메라 선택했을 때", "블루가 하는 말"}}},
        {"2필름 카메라", new TalkInfo{name = "장민혁", talk = new List<string>(){"필름카메라 선택했을 때", "그린이 하는 말"}}},
        {"3필름 카메라", new TalkInfo{name = "민예리", talk = new List<string>(){"필름카메라 선택했을 때", "옐로가 하는 말"}}},
        {"4필름 카메라", new TalkInfo{name = "송현주", talk = new List<string>(){"필름카메라 선택했을 때", "핑크가 하는 말"}}},
        {"5필름 카메라", new TalkInfo{name = "김연호", talk = new List<string>(){"필름카메라 선택했을 때", "퍼플이 하는 말"}}},

        {"0클래식 음악", new TalkInfo{name = "배수정", talk = new List<string>(){"클래식 음악 선택했을 때", "레드가 하는 말"}}},
        {"1클래식 음악", new TalkInfo{name = "도서준", talk = new List<string>(){"클래식 음악 선택했을 때", "블루가 하는 말"}}},
        {"2클래식 음악", new TalkInfo{name = "장민혁", talk = new List<string>(){"클래식 음악 선택했을 때", "그린이 하는 말"}}},
        {"3클래식 음악", new TalkInfo{name = "민예리", talk = new List<string>(){"클래식 음악 선택했을 때", "옐로가 하는 말"}}},
        {"4클래식 음악", new TalkInfo{name = "송현주", talk = new List<string>(){"클래식 음악 선택했을 때", "핑크가 하는 말"}}},
        {"5클래식 음악", new TalkInfo{name = "김연호", talk = new List<string>(){"클래식 음악 선택했을 때", "퍼플이 하는 말"}}},

        {"0인디 음악", new TalkInfo{name = "배수정", talk = new List<string>(){"인디 음악 선택했을 때", "레드가 하는 말"}}},
        {"1인디 음악", new TalkInfo{name = "도서준", talk = new List<string>(){"인디 음악 선택했을 때", "블루가 하는 말"}}},
        {"2인디 음악", new TalkInfo{name = "장민혁", talk = new List<string>(){"인디 음악 선택했을 때", "그린이 하는 말"}}},
        {"3인디 음악", new TalkInfo{name = "민예리", talk = new List<string>(){"인디 음악 선택했을 때", "옐로가 하는 말"}}},
        {"4인디 음악", new TalkInfo{name = "송현주", talk = new List<string>(){"인디 음악 선택했을 때", "핑크가 하는 말"}}},
        {"5인디 음악", new TalkInfo{name = "김연호", talk = new List<string>(){"인디 음악 선택했을 때", "퍼플이 하는 말"}}},

        {"0드라마", new TalkInfo{name = "배수정", talk = new List<string>(){"드라마 선택했을 때", "레드가 하는 말"}}},
        {"1드라마", new TalkInfo{name = "도서준", talk = new List<string>(){"드라마 선택했을 때", "블루가 하는 말"}}},
        {"2드라마", new TalkInfo{name = "장민혁", talk = new List<string>(){"드라마 선택했을 때", "그린이 하는 말"}}},
        {"3드라마", new TalkInfo{name = "민예리", talk = new List<string>(){"드라마 선택했을 때", "옐로가 하는 말"}}},
        {"4드라마", new TalkInfo{name = "송현주", talk = new List<string>(){"드라마 선택했을 때", "핑크가 하는 말"}}},
        {"5드라마", new TalkInfo{name = "김연호", talk = new List<string>(){"드라마 선택했을 때", "퍼플이 하는 말"}}},

        {"0노래방", new TalkInfo{name = "배수정", talk = new List<string>(){"노래방 선택했을 때", "레드가 하는 말"}}},
        {"1노래방", new TalkInfo{name = "도서준", talk = new List<string>(){"노래방 선택했을 때", "블루가 하는 말"}}},
        {"2노래방", new TalkInfo{name = "장민혁", talk = new List<string>(){"노래방 선택했을 때", "그린이 하는 말"}}},
        {"3노래방", new TalkInfo{name = "민예리", talk = new List<string>(){"노래방 선택했을 때", "옐로가 하는 말"}}},
        {"4노래방", new TalkInfo{name = "송현주", talk = new List<string>(){"노래방 선택했을 때", "핑크가 하는 말"}}},
        {"5노래방", new TalkInfo{name = "김연호", talk = new List<string>(){"노래방 선택했을 때", "퍼플이 하는 말"}}},


    };
}
