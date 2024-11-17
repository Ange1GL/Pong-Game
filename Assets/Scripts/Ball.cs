using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    
    public float speed = 7;
    public Rigidbody2D rb;
    public Vector2 startPos;
    private AudioSource audioSource;

    void Start()
    {
        startPos = transform.position;
        audioSource = GetComponent<AudioSource>();
        StartCoroutine(WaitAndLaunch());
    }


    void Update()
    {

    }


    public void Reset()
    {
        transform.position = startPos;
        rb.velocity = Vector2.zero;
        StartCoroutine(WaitAndLaunch());
    }

    public void Launch()
    {
        float x = Random.Range(0, 2) == 0 ? -1 : 1;
        float y = Random.Range(0, 2) == 0 ? -1 : 1;

        rb.velocity = new Vector2(speed * x, speed * y);

    }


    private void OnCollisionEnter2D(Collision2D collision)
    {
        
        if (audioSource != null)
        {
            audioSource.Play();
        }
    }

    private IEnumerator WaitAndLaunch()
    {
        yield return new WaitForSeconds(2); 
        Launch();
    }
}
