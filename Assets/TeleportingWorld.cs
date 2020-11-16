
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/**
 * This component moves its object when the player clicks the arrow keys.
 */
public class TeleportingWorld: MonoBehaviour {
    [Tooltip("Speed of movement, in meters per second")]
    [SerializeField] float speed = 1f;
    [SerializeField] Rigidbody2D rb;
    [SerializeField] string triggeringTag;




           private void OnTriggerEnter2D(Collider2D other) {
                if (other.tag == triggeringTag && enabled) {
                    
        }
    

    }


}
