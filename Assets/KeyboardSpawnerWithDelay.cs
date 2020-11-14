using System;
using System.Threading;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/**
 * This component spawns the given object whenever the player clicks a given key.
 */
public class KeyboardSpawnerWithDelay : MonoBehaviour
{
    [SerializeField] protected KeyCode keyToPress;
    [SerializeField] protected GameObject prefabToSpawn;
    [SerializeField] protected Vector3 velocityOfSpawnedObject;
    [SerializeField] protected float delay;
    
    private float time;
    private int hasShoted; // Flag that indicates if shot has been shoted

    protected virtual GameObject spawnObject()
    {
        // Step 1: spawn the new object.
        Vector3 positionOfSpawnedObject = transform.position;  // span at the containing object position.
        Quaternion rotationOfSpawnedObject = Quaternion.identity;  // no rotation.
        GameObject newObject = Instantiate(prefabToSpawn, positionOfSpawnedObject, rotationOfSpawnedObject);

        // Step 2: modify the velocity of the new object.
        Mover newObjectMover = newObject.GetComponent<Mover>();
        if (newObjectMover)
        {
            newObjectMover.SetVelocity(velocityOfSpawnedObject);
        }

        return newObject;
    }

    private void Start()
    {
        hasShoted = 0;
        time = 0;
    }

    private void Update()
    {
        //Debug.Log("t: " + time);
        if (hasShoted == 1)
        {
            time += Time.deltaTime;
            if (time >= delay)
            {
                hasShoted = 0;
                time = 0;
            }
        }

        if (Input.GetKeyDown(keyToPress) && hasShoted == 0)
        {
            spawnObject();
            hasShoted = 1;
        }
    }
}
