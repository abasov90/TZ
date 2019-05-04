using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{

    public Text scoreValue;

    private void Start()
    {
        SetScore();
    }

    public void SetScore()
    {
        scoreValue.text = DB.Score.ToString();
    }


}
