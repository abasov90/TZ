using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Planet : MonoBehaviour
{
    [SerializeField]
    private Planets planet;

    public RawImage planetBackground;

    //private float gravity;
    public float Gravity
    {
        get { return planet.Gravity; }
    }

    private void OnEnable()
    {
        SetBackground();
    }

    public void SetBackground()
    {
        planetBackground.GetComponent<RawImage>().color = new Color(planet.SkyColor.r, planet.SkyColor.g, planet.SkyColor.b);

        
    }


}
