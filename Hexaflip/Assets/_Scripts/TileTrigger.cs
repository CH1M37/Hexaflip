using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileTrigger : MonoBehaviour {
    [Tooltip("Time before this tile falls")]
    [SerializeField]
    float lifeTime = 2f;

    float t;
    bool objectOnTile = false;
    bool isBroken = false;
    GameObject breakableTile;

    private void Awake()
    {
        transform.position = Vector3.zero;
    }
    void Start ()
    {
        t = 0f;
        breakableTile = transform.parent.gameObject;
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("coucou");
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

        if(!isBroken && t > lifeTime)
        {
            BreakTile();
        }
    }

    private void BreakTile()
    {
        isBroken = true;
        Rigidbody rb = breakableTile.AddComponent<Rigidbody>();
        rb.useGravity = true;
        Invoke("DestroyTile", 2f);
    }

    private void DestroyTile()
    {
        Destroy(breakableTile);
    }

}
