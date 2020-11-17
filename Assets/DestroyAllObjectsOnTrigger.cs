using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyAllObjectsOnTrigger : MonoBehaviour
{
    [
        Tooltip(
            "Every object tagged with this tag will trigger the destruction of this object")
    ]
    [SerializeField]
    string triggeringTag;

    [SerializeField] NumberField scoreField;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player" && enabled)
        {
            Debug.Log("OnTrigger");
            DestroyAllObjects();
            Destroy(this.gameObject);
        }
    }

    void DestroyAllObjects()
    {
        GameObject[] gameObjects = GameObject.FindGameObjectsWithTag(triggeringTag);

        for (int i = 0; i < gameObjects.Length; i++)
        {
            Destroy(gameObjects[i]);
            scoreField.SetNumber(scoreField.GetNumber() + 1);
        }
    }
}
