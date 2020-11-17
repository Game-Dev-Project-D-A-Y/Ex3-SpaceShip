using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/**
    Spawn prefab every scoreToReload points
*/
public class SpawnByScore : MonoBehaviour
{
    [SerializeField]
    int scoreToReload = 20; // Default value

    [SerializeField]
    NumberField numberField;

    [SerializeField]
    GameObject prefabToSpawn;

    private int score;
    void Update()
    {
        if (
            numberField.GetNumber() % scoreToReload == 0 &&
            numberField.GetNumber() != score
        )
        {
            Vector3 positionOfSpawnedObject =
                new Vector3(transform.position.x,
                    transform.position.y,
                    transform.position.z);
            GameObject newObject =
                Instantiate(prefabToSpawn.gameObject,
                positionOfSpawnedObject,
                Quaternion.identity);

            score = numberField.GetNumber();
            Debug.Log("score: "+score);
        }
    }
}
