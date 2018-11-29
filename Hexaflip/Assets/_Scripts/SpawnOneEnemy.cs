using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnOneEnemy : MonoBehaviour {

    public GameObject self;
    public GameObject enemyPrefab;

    void Start()
    {
        GameObject enemy = Instantiate(enemyPrefab);
        enemy.transform.SetParent(self.transform, false);
    }
}
