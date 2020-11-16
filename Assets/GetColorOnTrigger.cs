using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetColorOnTrigger : MonoBehaviour
{
    [Tooltip("Destroy object with the triggeringTag")]
    [SerializeField] string triggeringTag;
    [Tooltip("Destroy object a specific key from the keyboard")]
    [SerializeField] KeyCode keyToPress;
    [SerializeField] NumberField scoreField;
    [SerializeField] int pointsToAdd; 

    bool active = false;
    GameObject color;

    void OnTriggerEnter2D(Collider2D other)
    {
        active = true;
        if(other.tag == triggeringTag)
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
                Debug.Log("second");
                Destroy(color);
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

    /*
    private void OnTriggerStay2D(Collider2D other)
    {
        if (other.tag == triggeringTag && enabled)
        {
            Debug.Log("first ");

            if (Input.GetKeyDown(keyToPress)) { 
                Debug.Log("second");
                Destroy(other.gameObject);
            }
        }
    }
    */
}
