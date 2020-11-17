using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/**
    Destroy every object with given tag when colliding.
*/
public class DestroyAllObjectsOnTrigger : MonoBehaviour
{
    [Tooltip("Every object tagged with this tag will trigger the destruction")]
    [SerializeField]
    string triggeringTag;

    private NumberField numberField;

    void Start()
    {
        GameObject sf = GameObject.Find("ScoreField");
        numberField = sf.GetComponent<NumberField>();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player" && enabled)
        {
            Destroy(this.gameObject);
            DestroyAllObjects();
        }
    }

    void DestroyAllObjects()
    {
        GameObject[] gameObjects =
            GameObject.FindGameObjectsWithTag(triggeringTag);

        for (int i = 0; i < gameObjects.Length; i++)
        {
            Destroy(gameObjects[i]);
            numberField.SetNumber(numberField.GetNumber() + 1);
            GAME_STATUS.playerScore = numberField.GetNumber();
        }
    }
}
