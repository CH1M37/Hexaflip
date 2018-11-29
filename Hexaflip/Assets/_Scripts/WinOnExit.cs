using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinOnExit : MonoBehaviour {

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            Debug.Log("Tu gagnes là maintenant tout de suite");
        }
    }
}
