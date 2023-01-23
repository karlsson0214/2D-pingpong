using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(Rigidbody2D))]
[RequireComponent (typeof(BoxCollider2D))]

public class Racket : MonoBehaviour
{
    public KeyCode keyUp;
    public KeyCode keyDown;
    private Rigidbody2D rb;
    private float speed = 10;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        
    }
    public KeyCode KeyUp
    {
        set { keyUp = value; }
    }
    public KeyCode KeyDown
    {
        set { keyDown = value; }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(keyUp))
        {
            rb.velocity = new Vector2(0f, speed);
        }
        else if (Input.GetKey(keyDown))
        {
            rb.velocity = new Vector2(0f, -speed);
        }
        else
        {
            rb.velocity = new Vector2(0, 0); //or Vector2.zero;
        }
        if (rb.position.y > 3.8f)
        {
            rb.position = new Vector2(rb.position.x, 3.8f);
        }
        else if (rb.position.y < -3.8f)
        {
            rb.position = new Vector2(rb.position.x, -3.8f);
        }
    }
    
}
