using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/**
    This component destroys its object whenever the player hp is zero.
*/
public class DestroyOnTriggerWithHP : MonoBehaviour
{
    [
        Tooltip(
            "Every object tagged with this tag will trigger the destruction of this object")
    ]
    [SerializeField]
    string triggeringTag;

    [SerializeField] HealthPointManager hpManager;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == triggeringTag && enabled)
        {
            if (hpManager.getHP() > 1)
            {
                Destroy(other.gameObject);
                hpManager.reduceHP();
            }
            else
            {
                Destroy(this.gameObject);
                Destroy(other.gameObject);
            }
        }
    }
}
