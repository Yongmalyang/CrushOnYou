using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PopUpMgr : MonoBehaviour
{
    public GameObject PausePopup;
    public GameObject NotePopup;
    // Start is called before the first frame update
    public void ClickPause()
    {
        if(PausePopup.activeSelf == true)
        {
            PausePopup.gameObject.SetActive(false);
        }
        else
        {
            PausePopup.gameObject.SetActive(true);
        }
    }

    public void ClickNote()
    {
        if(NotePopup.activeSelf == true)
        {
            NotePopup.gameObject.SetActive(false);
        }
        else
        {
            NotePopup.gameObject.SetActive(true);
        }
    }
}
