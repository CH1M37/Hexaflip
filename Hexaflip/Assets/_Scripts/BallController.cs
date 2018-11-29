using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour {

    public float speed;

    void Update()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");

        float moveVertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveHorizontal * speed, 0.0f, moveVertical * speed);

        transform.Translate(movement);
    }

}


//public float speed;

//private Rigidbody rb;

//void Start()
//{
//    rb = GetComponent<Rigidbody>();
//}

//void FixedUpdate()
//{
//    float moveHorizontal = Input.GetAxis("Horizontal");
//    float moveVertical = Input.GetAxis("Vertical");

//    Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);

//    rb.AddForce(movement * speed);
//}