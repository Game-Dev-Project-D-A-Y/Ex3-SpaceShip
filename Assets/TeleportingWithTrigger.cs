using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeleportingWithTrigger : MonoBehaviour
{
    [Tooltip("The tag of the Object need to be teleported")]
    [SerializeField]
    string triggeringTag;

    [Tooltip("Destination Object to teleport")]
    [SerializeField]
    GameObject destObject;

    [SerializeField]
    KeyCode directionKey;

    private void OnTriggerStay2D(Collider2D other)
    {
        if (other.tag == triggeringTag && enabled)
        {
            if (Input.GetKey(directionKey) || Input.GetKeyDown(directionKey))
            {
                float x = destObject.transform.position.x;
                float y = other.transform.position.y;
                float z = other.transform.position.z;
                other.transform.position = new Vector3(x, y, z);
            }
        }
    }
}
