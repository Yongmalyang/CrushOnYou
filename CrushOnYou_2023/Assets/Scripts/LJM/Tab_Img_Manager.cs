using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Tab_Img_Manager : MonoBehaviour
{
    public Image Img_button;
    public Sprite Img_button_on;
    public Sprite Img_button_off;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ChangeImage_on()
    {
        Img_button.sprite = Img_button_on; //TestImage�� SourceImage�� TestSprite�� �����ϴ� �̹����� �ٲپ��ݴϴ�
    }
    public void ChangeImage_off()
    {
        Img_button.sprite = Img_button_off; //TestImage�� SourceImage�� TestSprite�� �����ϴ� �̹����� �ٲپ��ݴϴ�
    }
}
