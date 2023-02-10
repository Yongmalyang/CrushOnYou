using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptManager
{ 
    public static Dictionary<string, List<string>> ScriptsInfo1 = new Dictionary<string, List<string>>(){

        {"True운동", new List<string>(){"운동 선택했을 때", "긍정이", "친밀도 상승"}},
        {"False운동", new List<string>(){"음, 난 운동하는 거 별로 좋아하지 않아", "땀 나고 숨 차는 거 딱 질색이야", "(더 이상 이어나갈 이야기가 없습니다. 친밀도가 하락합니다.)"}},

        {"True필름 카메라", new List<string>(){"너 필름 카메라도 있어?", "긍정이", "친밀도 상승"}},
        {"False필름 카메라", new List<string>(){"필름 카메라 선택했을 때", "부정이", "친밀도 하락"}},

        {"True클래식 음악", new List<string>(){"클래식 선택했을 때", "긍정이", "친밀도 상승"}},
        {"False클래식 음악",new List<string>(){"클래식 선택했을 때", "부정이", "친밀도 하락"}},

        {"True인디 음악", new List<string>(){"인디 음악 선택했을 때", "긍정이", "친밀도 상승"}},
        {"False인디 음악", new List<string>(){"인디 음악 선택했을 때", "부정이", "친밀도 하락"}},

        {"True드라마", new List<string>(){"드라마 선택했을 때", "긍정이", "친밀도 상승"}},
        {"False드라마", new List<string>(){"드라마 선택했을 때", "부정이", "친밀도 하락"}},

        {"True노래방", new List<string>(){"노래방 선택했을 때", "긍정이", "친밀도 상승"}},
        {"False노래방", new List<string>(){"노래방 선택했을 때", "부정이", "친밀도 하락"}},

    };

    public static Dictionary<string, List<string>> ScriptsInfo2 = new Dictionary<string, List<string>>(){

        {"tt운동", new List<string>(){"나 요즘 운동 시작했어.", "오! 나도 관심있는데. 어떤 운동 해?", "(분위기가 좋아보입니다. 모두에 대한 친밀도가 상승합니다.)"}},
        {"ff운동", new List<string>(){"운동? 난 운동은 잘 못해서...", "나도 운동은 별로 안좋아해.", "(두 사람이 공감대를 형성합니다. 서로에 대한 친밀도가 상승합니다.)"}},
        {"tf운동", new List<string>(){"나 운동하는 거 정말 좋아하는데! 넌 어때?", "아아.. 난 운동 잘 못하기도 하고 별로 좋아하진 않아.", "(대화거리가 더 이상 없어보입니다. 서로에 대한 친밀도가 하락합니다.)"}},

        {"tt필름 카메라", new List<string>(){"필카", "긍정긍정", "(분위기가 좋아보입니다. 모두에 대한 친밀도가 상승합니다.)"}},
        {"ff필름 카메라", new List<string>(){"필카", "ㅂㅂ", "(두 사람이 공감대를 형성합니다. 서로에 대한 친밀도가 상승합니다.)"}},
        {"tf필름 카메라", new List<string>(){"ㅍㅋ", "ㄱㅂ", "(대화거리가 더 이상 없어보입니다. 서로에 대한 친밀도가 하락합니다.)"}},

        {"tt클래식 음악", new List<string>(){"클래식", "ㄱㄱ", "(분위기가 좋아보입니다. 모두에 대한 친밀도가 상승합니다.)"}},
        {"ff클래식 음악", new List<string>(){"클래식", "ㅂㅂ", "(두 사람이 공감대를 형성합니다. 서로에 대한 친밀도가 상승합니다.)"}},
        {"tf클래식 음악", new List<string>(){"클래식", "ㄱㅂ", "(대화거리가 더 이상 없어보입니다. 서로에 대한 친밀도가 하락합니다.)"}},

        {"tt인디 음악", new List<string>(){"인디", "ㄱㄱ", "(분위기가 좋아보입니다. 모두에 대한 친밀도가 상승합니다.)"}},
        {"ff인디 음악", new List<string>(){"인디", "ㅂㅂ", "(두 사람이 공감대를 형성합니다. 서로에 대한 친밀도가 상승합니다.)"}},
        {"tf인디 음악", new List<string>(){"인디", "ㄱㅂ", "(대화거리가 더 이상 없어보입니다. 서로에 대한 친밀도가 하락합니다.)"}},

        {"tt드라마", new List<string>(){"ㄷㄻ", "ㄱㄱ", "(분위기가 좋아보입니다. 모두에 대한 친밀도가 상승합니다.)"}},
        {"ff드라마", new List<string>(){"ㄷㄻ", "ㅂㅂ", "(두 사람이 공감대를 형성합니다. 서로에 대한 친밀도가 상승합니다.)"}},
        {"tf드라마", new List<string>(){"ㄷㄻ", "ㄱㅂ", "(대화거리가 더 이상 없어보입니다. 서로에 대한 친밀도가 하락합니다.)"}},

        {"tt노래방", new List<string>(){"ㄴㄼ", "ㄱㄱ", "(분위기가 좋아보입니다. 모두에 대한 친밀도가 상승합니다.)"}},
        {"ff노래방", new List<string>(){"ㄴㄼ", "ㅂㅂ", "(두 사람이 공감대를 형성합니다. 서로에 대한 친밀도가 상승합니다.)"}},
        {"tf노래방", new List<string>(){"ㄴㄼ", "ㄱㅂ", "(대화거리가 더 이상 없어보입니다. 서로에 대한 친밀도가 하락합니다.)"}},

    };
}
