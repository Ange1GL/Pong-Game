using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.WSA;

public class Ball : MonoBehaviour
{
    
    public float speed = 7;
    public Rigidbody2D rb;
    public Vector2 startPos;

    void Start()
    {
        startPos = transform.position;
        Launch();
    }


    void Update()
    {

    }


    public void Reset()
    {
        transform.position = startPos;
        rb.velocity = Vector2.zero;
        Launch();
    }

    public void Launch()
    {
        float x = Random.Range(0, 2) == 0 ? -1 : 1;
        float y = Random.Range(0, 2) == 0 ? -1 : 1;

        rb.velocity = new Vector2(speed * x, speed * y);

    }
}
