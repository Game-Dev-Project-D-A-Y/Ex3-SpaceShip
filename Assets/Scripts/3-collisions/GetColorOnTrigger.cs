using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 * This script Goal is to open a time space which allow you to destroy once activated while colition.
*/
public class GetColorOnTrigger : MonoBehaviour
{
    [Tooltip("Destroy object with the triggeringTag")]
    [SerializeField]
    string triggeringTag;

    [Tooltip("Destroy object a specific key from the keyboard")]
    [SerializeField]
    KeyCode keyToPress;

    [Tooltip("Score field to update the score")]
    [SerializeField]
    NumberField scoreField;

    [Tooltip("Points to add")]
    [SerializeField]
    int pointsToAdd;

    private bool active = false;

    private GameObject color;

    void OnTriggerEnter2D(Collider2D other)
    {
        active = true;
        if (other.tag == triggeringTag)
        {
            color = other.gameObject;
        }
    }

    void Update()
    {
        if (Input.GetKeyDown(keyToPress) && Time.timeScale > 0)
        {
            if (active)
            {
                Destroy (color);
                scoreField.SetNumber(scoreField.GetNumber() + pointsToAdd);
            }
            else
            {
                scoreField.SetNumber(scoreField.GetNumber() - pointsToAdd);
            }
        }
    }

    void OnTriggerExit2D(Collider2D other)
    {
        active = false;
    }
}
