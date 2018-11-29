using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinOnExit : MonoBehaviour {

    public GameObject uiManager;
    private UI_Manager uiScript;

    private void Start()
    {
        uiScript = uiManager.GetComponent<UI_Manager>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            Debug.Log("Tu gagnes là maintenant tout de suite");
            uiScript.Win();
        }
    }
}
