using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AI : MonoBehaviour
{

public float speed=10;
public GameObject ball;
private Vector2 ballPosition;

    // Update is called once per frame
    void Update()
    {
        Move();
    }
    
    void Move ()
    {
        ballPosition = ball.transform.position;
        if (transform.position.y > ballPosition.y)
        {
            transform.position += new Vector3(0, -speed*Time.deltaTime);
        }
        if (transform.position.y < ballPosition.y)
        {
            transform.position += new Vector3(0, speed*Time.deltaTime);
        }
    }
}
