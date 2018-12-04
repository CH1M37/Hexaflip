using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BallController : MonoBehaviour {

    GameObject PauseScreen;

    public float speed;

    GameObject uiManager;
    private UI_Manager uiScript;

    private void Start()
    {
        uiManager = GameObject.Find("UI_Manager");
        uiScript = uiManager.GetComponent<UI_Manager>();
    }


    void Update()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");

        float moveVertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveHorizontal * speed * Time.timeScale, 0.0f, moveVertical * speed * Time.timeScale);

        transform.Translate(movement);

        //Game Over if fall
        if (this.transform.position.y < -6f)
        {
            uiScript.GameOver();
        }
    }

}