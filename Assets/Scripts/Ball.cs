using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Rigidbody2D))]
[RequireComponent(typeof(BoxCollider2D))]
public class Ball : MonoBehaviour
{
    private float speed = 10;
    private Rigidbody2D rb;
    public Text leftScoreDisplay;
    public Text rightScoreDisplay;
    private int leftScore = 0;
    private int rightScore = 0;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.velocity = new Vector2(speed, 0);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.collider.gameObject.name == "LeftWall")
        {
            // point to right player
            ++rightScore;
            rightScoreDisplay.text = "Score: " + rightScore;
            

        }
        if (other.collider.gameObject.name == "RightWall")
        {
            // point to left player
            ++leftScore;
            leftScoreDisplay.text = "Score: " + leftScore;
        }
    }
}
