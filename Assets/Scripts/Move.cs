using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    public float speed = 10f;

    Rigidbody2D body;
    public float horizontal;
    public float vertical;

    // Start is called before the first frame update
    void Start()
    {
        body = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.A))
        {
            horizontal = -1;    
        }
        
        else if (Input.GetKey(KeyCode.D))
        {
            horizontal = 1;
        }

        else
        {
            horizontal = 0;
        }
        
        if (Input.GetKey(KeyCode.S))
        {
            vertical = -1;
        }

        else if (Input.GetKey(KeyCode.W))
        {
            vertical = 1;
        }

        else
        {
            vertical = 0;
        }
    }
    
    // Fixed Update is called 50 times a second
    private void FixedUpdate()
    {
        body.velocity = new Vector2 (horizontal * speed, vertical * speed);
    }
}
