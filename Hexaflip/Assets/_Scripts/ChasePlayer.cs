using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChasePlayer : MonoBehaviour {

    Transform Player;

    public int MoveSpeed = 3;
    public int MaxDist = 10;
    public int MinDist = 1;

    GameObject uiManager;
    private UI_Manager uiScript;
        

    private void Start()
    {
        uiManager = GameObject.Find("UI_Manager");
        Player = GameObject.FindGameObjectWithTag("Player").transform;
        uiScript = uiManager.GetComponent<UI_Manager>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            uiScript.GameOver();
        }
    }

    void Update()
    {
        if (Player != null)
        {
            transform.LookAt(Player);

            if (Vector3.Distance(transform.position, Player.position) >= MinDist)
            {

                transform.position += transform.forward * MoveSpeed * Time.deltaTime;



                if (Vector3.Distance(transform.position, Player.position) <= MaxDist)
                {
                    //Here Call any function U want Like Shoot at here or something
                }

            }
        }
        
    }

}
