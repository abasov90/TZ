using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Platform : MonoBehaviour
{

    private SpriteRenderer spriteRenderer;
    Ray ray;
    RaycastHit hit;

    void Start()
    {
        spriteRenderer = gameObject.GetComponent<SpriteRenderer>();
    }


    private void OnCollisionEnter2D(Collision2D c)
    {
        if (c.gameObject.CompareTag("Ball"))
        {
            ChangeColor();

            DB.Score += 1;
        }
    }

    public void ChangeColor()
    {
        spriteRenderer.color = new Color(Random.Range(0, 3), Random.Range(0, 3), Random.Range(0, 3), 1);
    }


}
