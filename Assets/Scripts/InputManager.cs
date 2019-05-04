using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : MonoBehaviour
{


    public delegate void ClickAction();

    public static event ClickAction OnFireKeyClicked;
    public static event ClickAction OnFireKeyUnClicked;


    public void FireKeyDown()
    {
        if (OnFireKeyClicked != null)
            OnFireKeyClicked();

    }
    public void FireKeyUp()
    {
        if (OnFireKeyUnClicked != null)
            OnFireKeyUnClicked();
    }


    public void Update()
    {

        if (Input.GetButtonDown("Fire1"))
        {
            OnFireKeyClicked?.Invoke();
        }
        if (Input.GetButtonUp("Fire1"))
        {
            OnFireKeyUnClicked?.Invoke();
        }



        if (Input.GetMouseButtonDown(0))
        {
            Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            Vector2 mousePos2D = new Vector2(mousePos.x, mousePos.y);

            RaycastHit2D hit = Physics2D.Raycast(mousePos2D, Vector2.zero);
            if (hit.collider != null)
            {
                hit.transform.GetComponent<Platform>().ChangeColor();
            }

        }


    }



}
