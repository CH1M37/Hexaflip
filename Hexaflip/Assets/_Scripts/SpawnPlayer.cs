using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPlayer : MonoBehaviour {

    public GameObject playerPrefab;
    public float positionX = 0;
    public float positionZ = 0;
    public float positionY = 1.6f;
	
	void Start () {

        Instantiate(playerPrefab, new Vector3(positionX, positionY, positionZ), Quaternion.identity);

	}
		
}
