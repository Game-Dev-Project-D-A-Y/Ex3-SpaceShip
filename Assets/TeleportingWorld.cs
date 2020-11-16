
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

    void Update() {
        float horizontal = Input.GetAxis("Horizontal"); // +1 if right arrow is pushed, -1 if left arrow is pushed, 0 otherwise
        float vertical = Input.GetAxis("Vertical");     // +1 if up arrow is pushed, -1 if down arrow is pushed, 0 otherwise
        Vector3 movementVector = new Vector3(horizontal, vertical, 0) * speed * Time.deltaTime;
        //transform.position += movementVector;
        if(this.transform.position.x == 5)
        {
            this.transform.position = new Vector3(1,1,0);
        }
       // rb.velocity = new Vector3(horizontal, vertical, 0) * speed; // it'll make the Object go smoothly and not "jump" againts the wall
        //transform.Translate(movementVector);
        // NOTE: "Translate(movementVector)" uses relative coordinates - 
        //       it moves the object in the coordinate system of the object itself.
        // In contrast, "transform.position += movementVector" would use absolute coordinates -
        //       it moves the object in the coordinate system of the world.
        // It makes a difference only if the object is rotated.
    }


}
