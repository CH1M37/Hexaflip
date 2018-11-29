using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileTrigger : MonoBehaviour {
    [Tooltip("Time before this tile falls")]
    [SerializeField]
    float lifeTime = 2f;

    float t;
    bool objectOnTile = false;
    GameObject breakableTile;

    void Awake ()
    {
        t = 0f;
        breakableTile = transform.parent.gameObject;
    }

    private void OnTriggerEnter(Collider other)
    { 
        objectOnTile = true;
    }
    private void OnTriggerExit(Collider other)
    {
        objectOnTile = false;
    }

    void Update ()
    {
        if (objectOnTile)
        {
            t += Time.deltaTime;
        }

        if(t > lifeTime)
        {
            Rigidbody rb = breakableTile.AddComponent<Rigidbody>();
            rb.useGravity = true;
            Invoke("DestroyTile", 2f);
        }
    }

    private void DestroyTile()
    {
        Destroy(breakableTile);
    }

}
