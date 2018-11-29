using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToggleLight : MonoBehaviour {

	
	void Start () {
        GameObject light = GameObject.Find("Directional Light");
        light.SetActive(false);
	}

}
