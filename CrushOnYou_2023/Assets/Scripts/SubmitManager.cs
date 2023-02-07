using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SubmitManager : MonoBehaviour
{
    public GameObject enemyPrefab;
    public GameObject[] submitProfiles;
    private static string[] charNames = {"B", "D", "J", "M", "S", "K", "P"};
    public GameObject profileCircle;

    private void Awake()
    {
        submitProfiles = new GameObject[7];
        SpawnCircleFormation();
        CircleRotate();
    }

    //Make 7 Circles
    private void SpawnCircleFormation()
    {

        Vector2 centerPosition = new Vector2(540, 1000);
        float radius = 260;

        for (int i = 0, p=0; i < 360; i += 52, p++)
        {

            Vector2 spawnPosition;
            float angle = i * Mathf.Deg2Rad;

            spawnPosition.x = (radius * Mathf.Cos(angle)) + centerPosition.x;
            spawnPosition.y = (radius * Mathf.Sin(angle)) + centerPosition.y;

            GameObject submitProfile = Instantiate(enemyPrefab, spawnPosition, Quaternion.identity) as GameObject;
            submitProfile.name = charNames[p];
            submitProfiles[p] = submitProfile;
            submitProfile.transform.SetParent(GameObject.Find("SubmitProfile").transform);

        }

    }

    private void CircleRotate()
    {
    }
}
