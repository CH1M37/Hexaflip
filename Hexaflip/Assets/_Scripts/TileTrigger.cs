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
            if (!isBroken)
            {
                BreakTile();
            }
        }
    }

    private void BreakTile()
    {
        GameObject hexagon = breakableTile.transform.GetChild(0).gameObject;
        hexagon.GetComponent<MeshCollider>().gameObject.SetActive(false);
        Rigidbody rb = breakableTile.AddComponent<Rigidbody>();
        rb.useGravity = true;
        Invoke("DestroyTile", 2f);
        isBroken = true;
    }

    private void DestroyTile()
    {
        Destroy(breakableTile);
    }

}
