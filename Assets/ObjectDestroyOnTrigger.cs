using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectDestroyOnTrigger : MonoBehaviour
{
    [Tooltip("Destroy object with the triggeringTag")]
    [SerializeField] string triggeringTag;

    private void OnTriggerEnter2D(Collider2D other) {
        if (other.tag == triggeringTag && enabled) {
            Destroy(other.gameObject);
        }
    }
}
