using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum Select 
{
    Se1, Se2, Se3       //선택지1, 2, 3
}


public class SelectManager : MonoBehaviour
{
    public static SelectManager instance;     //싱글톤 변수로 선언
    [SerializeField] private int Energy; 

    public void Awake()
    {
        if(instance==null) instance = this;
        else if(instance != null) return;
        DontDestroyOnLoad(gameObject);
    }

    public Select currentselect;
}