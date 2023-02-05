using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SelectEpisode_LJY : MonoBehaviour
{
    public GameObject Episode1Panel;
    public GameObject Episode2Panel;

    public GameObject EpisodeLeftBtn;
    public GameObject EpisodeRightBtn;

    Button leftBtn, rightBtn;

    void Start()
    {
        Episode1Panel.SetActive(true);
        Episode2Panel.SetActive(false);

        leftBtn = EpisodeLeftBtn.GetComponent<Button>();
        rightBtn = EpisodeRightBtn.GetComponent<Button>();
    }

    void Update()
    {
        if(Episode1Panel.activeSelf && !Episode2Panel.activeSelf)   //에피1 상태
        {
            leftBtn.interactable = false;
            rightBtn.interactable = true;
        }

        else if(!Episode1Panel.activeSelf && Episode2Panel.activeSelf) //에피2상태
        {
            leftBtn.interactable = true;
            rightBtn.interactable = false;
        }
    }

    public void LeftButton()
    {
        Episode1Panel.SetActive(true);
        Episode2Panel.SetActive(false);
    }

    public void RightButton()
    {
        Episode1Panel.SetActive(false);
        Episode2Panel.SetActive(true);
    }
}
