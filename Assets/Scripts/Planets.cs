using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Planet", menuName = "Planet", order = 51)]
public class Planets : ScriptableObject
{

    [SerializeField]
    private float gravity;
    [SerializeField]
    private Color skyColor;

    public float Gravity
    {
        get { return gravity; }
    }

    public Color SkyColor
    {
        get { return skyColor; }
    }

}
