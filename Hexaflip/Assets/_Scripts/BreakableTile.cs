using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BreakableTile : MonoBehaviour {

    private void Awake()
    {
        GameObject hexaTriggerPrefab = Resources.Load<GameObject>("_Prefabs/hexaTrigger");
        GameObject hexaTrigger = Instantiate(hexaTriggerPrefab);
        hexaTrigger.transform.SetParent(this.transform, false);
    }
}
