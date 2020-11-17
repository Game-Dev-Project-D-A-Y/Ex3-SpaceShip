using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreSpawner : MonoBehaviour
{
    [SerializeField] int scoreToReload;
    [SerializeField] NumberField numberField;
    [SerializeField] GameObject prefabToSpawn;


       // Start is called before the first frame update
    // void Start()
    // {
    //     GameObject sf = GameObject.Find("/PlayerSpaceship/ScoreField");
    //     numberField = sf.GetComponent<NumberField>();
    // }

    // Update is called once per frame
    void Update()
    {
        if(numberField.GetNumber() % scoreToReload == 0 && numberField.GetNumber() != 0)
        {
            Vector3 positionOfSpawnedObject = new Vector3(
                transform.position.x,
                transform.position.y,
                transform.position.z);
            GameObject newObject = Instantiate(prefabToSpawn.gameObject, positionOfSpawnedObject, Quaternion.identity);

        }
    }

}