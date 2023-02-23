using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using TMPro;
using System.Linq;

public class FlirtDirectionManager : MonoBehaviour
{
    public int[] RedLove, GreenLove, BlueLove, VioletLove, PinkLove, YellowLove, CoyLove;
    public int max;
    public List<Heart> RedLoveList, GreenLoveList, BlueLoveList, VioletLoveList, PinkLoveList, YellowLoveList, CoyLoveList;
    public class Heart
    {
        public int Index { get; set; }
        public int value { get; set; }
    }

    private void Awake()
    {
        RedLove = DataController.Instance.gameData.RedLove;
        GreenLove = DataController.Instance.gameData.GreenLove;
        BlueLove = DataController.Instance.gameData.BlueLove;
        VioletLove = DataController.Instance.gameData.PurpleLove;
        PinkLove = DataController.Instance.gameData.PinkLove;
        YellowLove = DataController.Instance.gameData.YellowLove;
        CoyLove = DataController.Instance.gameData.CoyLove;
    }

    private void Update()
    {
    }

    public void SetIndex()
    {
        RedLoveList = new List<Heart>() {
            new Heart() { Index = 0, value = RedLove[0] },
            new Heart() { Index = 1, value = RedLove[1] },
            new Heart() { Index = 2, value = RedLove[2] },
            new Heart() { Index = 3, value = RedLove[3] },
            new Heart() { Index = 4, value = RedLove[4] },
            new Heart() { Index = 5, value = RedLove[5] },
            new Heart() { Index = 6, value = RedLove[6] }
        };

        GreenLoveList = new List<Heart>() {
            new Heart() { Index = 0, value = GreenLove[0] },
            new Heart() { Index = 1, value = GreenLove[1] },
            new Heart() { Index = 2, value = GreenLove[2] },
            new Heart() { Index = 3, value = GreenLove[3] },
            new Heart() { Index = 4, value = GreenLove[4] },
            new Heart() { Index = 5, value = GreenLove[5] },
            new Heart() { Index = 6, value = GreenLove[6] }
        };
        BlueLoveList = new List<Heart>() {
            new Heart() { Index = 0, value = BlueLove[0] },
            new Heart() { Index = 1, value = BlueLove[1] },
            new Heart() { Index = 2, value = BlueLove[2] },
            new Heart() { Index = 3, value = BlueLove[3] },
            new Heart() { Index = 4, value = BlueLove[4] },
            new Heart() { Index = 5, value = BlueLove[5] },
            new Heart() { Index = 6, value = BlueLove[6] }
        };
        VioletLoveList = new List<Heart>() {
            new Heart() { Index = 0, value = VioletLove[0] },
            new Heart() { Index = 1, value = VioletLove[1] },
            new Heart() { Index = 2, value = VioletLove[2] },
            new Heart() { Index = 3, value = VioletLove[3] },
            new Heart() { Index = 4, value = VioletLove[4] },
            new Heart() { Index = 5, value = VioletLove[5] },
            new Heart() { Index = 6, value = VioletLove[6] }
        };
        PinkLoveList = new List<Heart>() {
            new Heart() { Index = 0, value = PinkLove[0] },
            new Heart() { Index = 1, value = PinkLove[1] },
            new Heart() { Index = 2, value = PinkLove[2] },
            new Heart() { Index = 3, value = PinkLove[3] },
            new Heart() { Index = 4, value = PinkLove[4] },
            new Heart() { Index = 5, value = PinkLove[5] },
            new Heart() { Index = 6, value = PinkLove[6] }
        };
        YellowLoveList = new List<Heart>() {
            new Heart() { Index = 0, value = YellowLove[0] },
            new Heart() { Index = 1, value = YellowLove[1] },
            new Heart() { Index = 2, value = YellowLove[2] },
            new Heart() { Index = 3, value = YellowLove[3] },
            new Heart() { Index = 4, value = YellowLove[4] },
            new Heart() { Index = 5, value = YellowLove[5] },
            new Heart() { Index = 6, value = YellowLove[6] }
        };
        CoyLoveList = new List<Heart>() {
            new Heart() { Index = 0, value = CoyLove[0] },
            new Heart() { Index = 1, value = CoyLove[1] },
            new Heart() { Index = 2, value = CoyLove[2] },
            new Heart() { Index = 3, value = CoyLove[3] },
            new Heart() { Index = 4, value = CoyLove[4] },
            new Heart() { Index = 5, value = CoyLove[5] },
            new Heart() { Index = 6, value = CoyLove[6] }
        };
    }

    public void DrawSubmitLines()
    {
        Debug.Log("DrawSubmitLines");
        SetIndex();
        ArrowSetFalse();

        //가영 index 0
        max = RedLove.Max();
        List<Heart> RedLoveIndices = RedLoveList.FindAll(element => element.value == max);
        foreach (Heart h in RedLoveIndices)
        {
            if (h.Index == 1)
            {
                GameObject.Find("Note").transform.Find("ContentArea").transform.Find("Direction").transform.Find("RArrows").transform.Find("RArrowG").gameObject.SetActive(true);
            }
            if (h.Index == 2)
            {
                GameObject.Find("Note").transform.Find("ContentArea").transform.Find("Direction").transform.Find("RArrows").transform.Find("RArrowB").gameObject.SetActive(true);
            }
            if (h.Index == 3)
            {
                GameObject.Find("Note").transform.Find("ContentArea").transform.Find("Direction").transform.Find("RArrows").transform.Find("RArrowV").gameObject.SetActive(true);
            }
            if (h.Index == 4)
            {
                GameObject.Find("Note").transform.Find("ContentArea").transform.Find("Direction").transform.Find("RArrows").transform.Find("RArrowP").gameObject.SetActive(true);
            }
            if (h.Index == 5)
            {
                GameObject.Find("Note").transform.Find("ContentArea").transform.Find("Direction").transform.Find("RArrows").transform.Find("RArrowY").gameObject.SetActive(true);
            }
            if (h.Index == 6)
            {
                GameObject.Find("Note").transform.Find("ContentArea").transform.Find("Direction").transform.Find("RArrows").transform.Find("RArrowC").gameObject.SetActive(true);
            }
        }
        //서준 index 1
        max = GreenLove.Max();
        List<Heart> GreenLoveIndices = GreenLoveList.FindAll(element => element.value == max);
        foreach (Heart h in GreenLoveIndices)
        {
            if (h.Index == 0)
            {
                GameObject.Find("Note").transform.Find("ContentArea").transform.Find("Direction").transform.Find("GArrows").transform.Find("GArrowR").gameObject.SetActive(true);
            }
            if (h.Index == 2)
            {
                GameObject.Find("Note").transform.Find("ContentArea").transform.Find("Direction").transform.Find("GArrows").transform.Find("GArrowB").gameObject.SetActive(true);
            }
            if (h.Index == 3)
            {
                GameObject.Find("Note").transform.Find("ContentArea").transform.Find("Direction").transform.Find("GArrows").transform.Find("GArrowV").gameObject.SetActive(true);
            }
            if (h.Index == 4)
            {
                GameObject.Find("Note").transform.Find("ContentArea").transform.Find("Direction").transform.Find("GArrows").transform.Find("GArrowP").gameObject.SetActive(true);
            }
            if (h.Index == 5)
            {
                GameObject.Find("Note").transform.Find("ContentArea").transform.Find("Direction").transform.Find("GArrows").transform.Find("GArrowY").gameObject.SetActive(true);
            }
            if (h.Index == 6)
            {
                GameObject.Find("Note").transform.Find("ContentArea").transform.Find("Direction").transform.Find("GArrows").transform.Find("GArrowC").gameObject.SetActive(true);
            }
        }
        //테오 index 2
        max = BlueLove.Max();
        List<Heart> BlueLoveIndices = BlueLoveList.FindAll(element => element.value == max);
        foreach (Heart h in BlueLoveIndices)
        {
            if (h.Index == 0)
            {
                GameObject.Find("Note").transform.Find("ContentArea").transform.Find("Direction").transform.Find("BArrows").transform.Find("BArrowR").gameObject.SetActive(true);
            }
            if (h.Index == 1)
            {
                GameObject.Find("Note").transform.Find("ContentArea").transform.Find("Direction").transform.Find("BArrows").transform.Find("BArrowG").gameObject.SetActive(true);
            }
            if (h.Index == 3)
            {
                GameObject.Find("Note").transform.Find("ContentArea").transform.Find("Direction").transform.Find("BArrows").transform.Find("BArrowV").gameObject.SetActive(true);
            }
            if (h.Index == 4)
            {
                GameObject.Find("Note").transform.Find("ContentArea").transform.Find("Direction").transform.Find("BArrows").transform.Find("BArrowP").gameObject.SetActive(true);
            }
            if (h.Index == 5)
            {
                GameObject.Find("Note").transform.Find("ContentArea").transform.Find("Direction").transform.Find("BArrows").transform.Find("BArrowY").gameObject.SetActive(true);
            }
            if (h.Index == 6)
            {
                GameObject.Find("Note").transform.Find("ContentArea").transform.Find("Direction").transform.Find("BArrows").transform.Find("BArrowC").gameObject.SetActive(true);
            }
        }
        //유이 index 3
        max = VioletLove.Max();
        List<Heart> VioletLoveIndices = VioletLoveList.FindAll(element => element.value == max);
        foreach (Heart h in VioletLoveIndices)
        {
            if (h.Index == 0)
            {
                GameObject.Find("Note").transform.Find("ContentArea").transform.Find("Direction").transform.Find("VArrows").transform.Find("VArrowR").gameObject.SetActive(true);
            }
            if (h.Index == 1)
            {
                GameObject.Find("Note").transform.Find("ContentArea").transform.Find("Direction").transform.Find("VArrows").transform.Find("VArrowG").gameObject.SetActive(true);
            }
            if (h.Index == 2)
            {
                GameObject.Find("Note").transform.Find("ContentArea").transform.Find("Direction").transform.Find("VArrows").transform.Find("VArrowB").gameObject.SetActive(true);
            }
            if (h.Index == 4)
            {
                GameObject.Find("Note").transform.Find("ContentArea").transform.Find("Direction").transform.Find("VArrows").transform.Find("VArrowP").gameObject.SetActive(true);
            }
            if (h.Index == 5)
            {
                GameObject.Find("Note").transform.Find("ContentArea").transform.Find("Direction").transform.Find("VArrows").transform.Find("VArrowY").gameObject.SetActive(true);
            }
            if (h.Index == 6)
            {
                GameObject.Find("Note").transform.Find("ContentArea").transform.Find("Direction").transform.Find("VArrows").transform.Find("VArrowC").gameObject.SetActive(true);
            }
        }
        //하나 index 4
        max = PinkLove.Max();
        List<Heart> PinkLoveIndices = PinkLoveList.FindAll(element => element.value == max);
        foreach (Heart h in PinkLoveIndices)
        {
            if (h.Index == 0)
            {
                GameObject.Find("Note").transform.Find("ContentArea").transform.Find("Direction").transform.Find("PArrows").transform.Find("PArrowR").gameObject.SetActive(true);
            }
            if (h.Index == 1)
            {
                GameObject.Find("Note").transform.Find("ContentArea").transform.Find("Direction").transform.Find("PArrows").transform.Find("PArrowG").gameObject.SetActive(true);
            }
            if (h.Index == 2)
            {
                GameObject.Find("Note").transform.Find("ContentArea").transform.Find("Direction").transform.Find("PArrows").transform.Find("PArrowB").gameObject.SetActive(true);
            }
            if (h.Index == 3)
            {
                GameObject.Find("Note").transform.Find("ContentArea").transform.Find("Direction").transform.Find("PArrows").transform.Find("PArrowV").gameObject.SetActive(true);
            }
            if (h.Index == 5)
            {
                GameObject.Find("Note").transform.Find("ContentArea").transform.Find("Direction").transform.Find("PArrows").transform.Find("PArrowY").gameObject.SetActive(true);
            }
            if (h.Index == 6)
            {
                GameObject.Find("Note").transform.Find("ContentArea").transform.Find("Direction").transform.Find("PArrows").transform.Find("PArrowC").gameObject.SetActive(true);
            }
        }
        //시우 index 5
        max = YellowLove.Max();
        List<Heart> YellowLoveIndices = YellowLoveList.FindAll(element => element.value == max);
        foreach (Heart h in YellowLoveIndices)
        {
            if (h.Index == 0)
            {
                GameObject.Find("Note").transform.Find("ContentArea").transform.Find("Direction").transform.Find("YArrows").transform.Find("YArrowR").gameObject.SetActive(true);
            }
            if (h.Index == 1)
            {
                GameObject.Find("Note").transform.Find("ContentArea").transform.Find("Direction").transform.Find("YArrows").transform.Find("YArrowG").gameObject.SetActive(true);
            }
            if (h.Index == 2)
            {
                GameObject.Find("Note").transform.Find("ContentArea").transform.Find("Direction").transform.Find("YArrows").transform.Find("YArrowB").gameObject.SetActive(true);
            }
            if (h.Index == 3)
            {
                GameObject.Find("Note").transform.Find("ContentArea").transform.Find("Direction").transform.Find("YArrows").transform.Find("YArrowV").gameObject.SetActive(true);
            }
            if (h.Index == 4)
            {
                GameObject.Find("Note").transform.Find("ContentArea").transform.Find("Direction").transform.Find("YArrows").transform.Find("YArrowP").gameObject.SetActive(true);
            }
            if (h.Index == 6)
            {
                GameObject.Find("Note").transform.Find("ContentArea").transform.Find("Direction").transform.Find("YArrows").transform.Find("YArrowC").gameObject.SetActive(true);
            }
        }
        //코이 index 6
        max = CoyLove.Max();
        List<Heart> CoyLoveIndices = CoyLoveList.FindAll(element => element.value == max);
        foreach (Heart h in CoyLoveIndices)
        {
            if (h.Index == 0)
            {
                GameObject.Find("Note").transform.Find("ContentArea").transform.Find("Direction").transform.Find("CArrows").transform.Find("CArrowR").gameObject.SetActive(true);
            }
            if (h.Index == 1)
            {
                GameObject.Find("Note").transform.Find("ContentArea").transform.Find("Direction").transform.Find("CArrows").transform.Find("CArrowG").gameObject.SetActive(true);
            }
            if (h.Index == 2)
            {
                GameObject.Find("Note").transform.Find("ContentArea").transform.Find("Direction").transform.Find("CArrows").transform.Find("CArrowB").gameObject.SetActive(true);
            }
            if (h.Index == 3)
            {
                GameObject.Find("Note").transform.Find("ContentArea").transform.Find("Direction").transform.Find("CArrows").transform.Find("CArrowV").gameObject.SetActive(true);
            }
            if (h.Index == 4)
            {
                GameObject.Find("Note").transform.Find("ContentArea").transform.Find("Direction").transform.Find("CArrows").transform.Find("CArrowP").gameObject.SetActive(true);
            }
            if (h.Index == 5)
            {
                GameObject.Find("Note").transform.Find("ContentArea").transform.Find("Direction").transform.Find("CArrows").transform.Find("CArrowY").gameObject.SetActive(true);
            }
        }
    }
    
    public void ArrowSetFalse()
    {
        Debug.Log("ArrowSetFalse");
        //가영 R
        GameObject.Find("Note").transform.Find("ContentArea").transform.Find("Direction").transform.Find("RArrows").transform.Find("RArrowG").gameObject.SetActive(false);
        GameObject.Find("Note").transform.Find("ContentArea").transform.Find("Direction").transform.Find("RArrows").transform.Find("RArrowB").gameObject.SetActive(false);
        GameObject.Find("Note").transform.Find("ContentArea").transform.Find("Direction").transform.Find("RArrows").transform.Find("RArrowV").gameObject.SetActive(false);
        GameObject.Find("Note").transform.Find("ContentArea").transform.Find("Direction").transform.Find("RArrows").transform.Find("RArrowP").gameObject.SetActive(false);
        GameObject.Find("Note").transform.Find("ContentArea").transform.Find("Direction").transform.Find("RArrows").transform.Find("RArrowY").gameObject.SetActive(false);
        GameObject.Find("Note").transform.Find("ContentArea").transform.Find("Direction").transform.Find("RArrows").transform.Find("RArrowC").gameObject.SetActive(false);

        //서준 G
        GameObject.Find("Note").transform.Find("ContentArea").transform.Find("Direction").transform.Find("GArrows").transform.Find("GArrowR").gameObject.SetActive(false);
        GameObject.Find("Note").transform.Find("ContentArea").transform.Find("Direction").transform.Find("GArrows").transform.Find("GArrowB").gameObject.SetActive(false);
        GameObject.Find("Note").transform.Find("ContentArea").transform.Find("Direction").transform.Find("GArrows").transform.Find("GArrowV").gameObject.SetActive(false);
        GameObject.Find("Note").transform.Find("ContentArea").transform.Find("Direction").transform.Find("GArrows").transform.Find("GArrowP").gameObject.SetActive(false);
        GameObject.Find("Note").transform.Find("ContentArea").transform.Find("Direction").transform.Find("GArrows").transform.Find("GArrowY").gameObject.SetActive(false);
        GameObject.Find("Note").transform.Find("ContentArea").transform.Find("Direction").transform.Find("GArrows").transform.Find("GArrowC").gameObject.SetActive(false);

        //테오 B
        GameObject.Find("Note").transform.Find("ContentArea").transform.Find("Direction").transform.Find("BArrows").transform.Find("BArrowR").gameObject.SetActive(false);
        GameObject.Find("Note").transform.Find("ContentArea").transform.Find("Direction").transform.Find("BArrows").transform.Find("BArrowG").gameObject.SetActive(false);
        GameObject.Find("Note").transform.Find("ContentArea").transform.Find("Direction").transform.Find("BArrows").transform.Find("BArrowV").gameObject.SetActive(false);
        GameObject.Find("Note").transform.Find("ContentArea").transform.Find("Direction").transform.Find("BArrows").transform.Find("BArrowP").gameObject.SetActive(false);
        GameObject.Find("Note").transform.Find("ContentArea").transform.Find("Direction").transform.Find("BArrows").transform.Find("BArrowY").gameObject.SetActive(false);
        GameObject.Find("Note").transform.Find("ContentArea").transform.Find("Direction").transform.Find("BArrows").transform.Find("BArrowC").gameObject.SetActive(false);

        //유이 V
        GameObject.Find("Note").transform.Find("ContentArea").transform.Find("Direction").transform.Find("VArrows").transform.Find("VArrowR").gameObject.SetActive(false);
        GameObject.Find("Note").transform.Find("ContentArea").transform.Find("Direction").transform.Find("VArrows").transform.Find("VArrowG").gameObject.SetActive(false);
        GameObject.Find("Note").transform.Find("ContentArea").transform.Find("Direction").transform.Find("VArrows").transform.Find("VArrowB").gameObject.SetActive(false);
        GameObject.Find("Note").transform.Find("ContentArea").transform.Find("Direction").transform.Find("VArrows").transform.Find("VArrowP").gameObject.SetActive(false);
        GameObject.Find("Note").transform.Find("ContentArea").transform.Find("Direction").transform.Find("VArrows").transform.Find("VArrowY").gameObject.SetActive(false);
        GameObject.Find("Note").transform.Find("ContentArea").transform.Find("Direction").transform.Find("VArrows").transform.Find("VArrowC").gameObject.SetActive(false);

        //하나 P
        GameObject.Find("Note").transform.Find("ContentArea").transform.Find("Direction").transform.Find("PArrows").transform.Find("PArrowR").gameObject.SetActive(false);
        GameObject.Find("Note").transform.Find("ContentArea").transform.Find("Direction").transform.Find("PArrows").transform.Find("PArrowG").gameObject.SetActive(false);
        GameObject.Find("Note").transform.Find("ContentArea").transform.Find("Direction").transform.Find("PArrows").transform.Find("PArrowB").gameObject.SetActive(false);
        GameObject.Find("Note").transform.Find("ContentArea").transform.Find("Direction").transform.Find("PArrows").transform.Find("PArrowV").gameObject.SetActive(false);
        GameObject.Find("Note").transform.Find("ContentArea").transform.Find("Direction").transform.Find("PArrows").transform.Find("PArrowY").gameObject.SetActive(false);
        GameObject.Find("Note").transform.Find("ContentArea").transform.Find("Direction").transform.Find("PArrows").transform.Find("PArrowC").gameObject.SetActive(false);

        //시우 Y
        GameObject.Find("Note").transform.Find("ContentArea").transform.Find("Direction").transform.Find("YArrows").transform.Find("YArrowR").gameObject.SetActive(false);
        GameObject.Find("Note").transform.Find("ContentArea").transform.Find("Direction").transform.Find("YArrows").transform.Find("YArrowG").gameObject.SetActive(false);
        GameObject.Find("Note").transform.Find("ContentArea").transform.Find("Direction").transform.Find("YArrows").transform.Find("YArrowB").gameObject.SetActive(false);
        GameObject.Find("Note").transform.Find("ContentArea").transform.Find("Direction").transform.Find("YArrows").transform.Find("YArrowV").gameObject.SetActive(false);
        GameObject.Find("Note").transform.Find("ContentArea").transform.Find("Direction").transform.Find("YArrows").transform.Find("YArrowP").gameObject.SetActive(false);
        GameObject.Find("Note").transform.Find("ContentArea").transform.Find("Direction").transform.Find("YArrows").transform.Find("YArrowC").gameObject.SetActive(false);

        //코이 C
        GameObject.Find("Note").transform.Find("ContentArea").transform.Find("Direction").transform.Find("CArrows").transform.Find("CArrowR").gameObject.SetActive(false);
        GameObject.Find("Note").transform.Find("ContentArea").transform.Find("Direction").transform.Find("CArrows").transform.Find("CArrowG").gameObject.SetActive(false);
        GameObject.Find("Note").transform.Find("ContentArea").transform.Find("Direction").transform.Find("CArrows").transform.Find("CArrowB").gameObject.SetActive(false);
        GameObject.Find("Note").transform.Find("ContentArea").transform.Find("Direction").transform.Find("CArrows").transform.Find("CArrowV").gameObject.SetActive(false);
        GameObject.Find("Note").transform.Find("ContentArea").transform.Find("Direction").transform.Find("CArrows").transform.Find("CArrowP").gameObject.SetActive(false);
        GameObject.Find("Note").transform.Find("ContentArea").transform.Find("Direction").transform.Find("CArrows").transform.Find("CArrowY").gameObject.SetActive(false);
    }
}
