using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DB : MonoBehaviour
{
    public static int Score
    {
        get { return PlayerPrefs.GetInt("Score"); }
        set { PlayerPrefs.SetInt("Score", value); }
    }
}
