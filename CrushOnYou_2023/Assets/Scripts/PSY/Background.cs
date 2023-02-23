using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Background : MonoBehaviour
{
    public GameObject BackPanel;
    public Sprite[] classroom, hall, lib, music, art, gym;

    public List<Sprite[]> Backgrounds;

    void Awake() {
        classroom = Resources.LoadAll<Sprite>("classroom");
        hall = Resources.LoadAll<Sprite>("hallway");
        lib = Resources.LoadAll<Sprite>("library");
        music = Resources.LoadAll<Sprite>("musicroom");
        art = Resources.LoadAll<Sprite>("artroom");
        gym = Resources.LoadAll<Sprite>("gym");

        Backgrounds = new List<Sprite[]>{classroom, hall, lib, music, art, gym};

        BackPanel.GetComponent<Image>().sprite = Backgrounds[DataController.Instance.gameData.myPlace][Random.Range(0,2)];
    }

}
