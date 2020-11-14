using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StopOnTrigger : MonoBehaviour
{
    [SerializeField] string triggeringTag;

    private void OnTriggerEnter2D(Collider2D other)
    {

        if (other.tag == triggeringTag)
        {
            Debug.Log("a: "+other.tag);
        }
    }
}
