using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

/*
    Handle the timer
 */
public class CountDownTime : MonoBehaviour
{
    [Tooltip("Time to countdown")]
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