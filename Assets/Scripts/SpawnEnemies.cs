﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEnemies : MonoBehaviour
{
    public float initialTime;
    public float minTime;
    public float maxTime;
    public List<GameObject> EnemiesList = new List<GameObject>();
    float timeControl;
    void Update()
    {
        timeControl += Time.deltaTime;

        if(timeControl >= initialTime) {
            Instantiate(EnemiesList[Random.Range(0, EnemiesList.Count)]
                ,transform.position
                ,transform.rotation);

            initialTime = Random.Range(minTime, maxTime);
            timeControl = 0;
        }
    }
}
