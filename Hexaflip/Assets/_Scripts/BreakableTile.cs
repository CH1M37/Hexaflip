using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BreakableTile : MonoBehaviour {

    [SerializeField]
    GameObject hexaTriggerPrefab;

    private void Awake()
    {
        GameObject hexaTrigger = Instantiate(hexaTriggerPrefab);
        hexaTrigger.transform.SetParent(this.transform, true);
    }
}
