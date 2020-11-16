using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

/*
 */

public class CountDownTime : MonoBehaviour
{
    [SerializeField] float timeRemaining;
    private TextMeshPro textField;

    void Start()
    {
        textField = GetComponent<TextMeshPro>();
    }
    void Update()
    {
        if (timeRemaining > 0)
        {
            timeRemaining -= Time.deltaTime;
            textField.SetText("{0}", timeRemaining);
        }
        else
        {
            textField.fontSize = 12;
            textField.SetText("GameOver");

            Time.timeScale = 0;
        }
        
    }
}