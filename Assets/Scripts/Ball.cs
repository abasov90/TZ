using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour, IMovable
{

    Rigidbody2D rb;

    private void Awake()
    {
        InputManager.OnFireKeyClicked += Move;

        rb = gameObject.GetComponent<Rigidbody2D>();
        rb.gravityScale = transform.parent.GetComponent<Planet>().Gravity;
    }

    public void Move()
    {
        var playerScreenPoint = Camera.main.WorldToScreenPoint(transform.position);


        if (Input.mousePosition.x > playerScreenPoint.x)
            rb.AddForce(new Vector2(150, 0));
        else
            rb.AddForce(new Vector2(-150, 0));
        
        if(Input.mousePosition.y > playerScreenPoint.y + 50)
            rb.AddForce(new Vector2(0, 50));



    }

}
