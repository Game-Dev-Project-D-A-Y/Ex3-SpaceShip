using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

/**
 * This component spawns the given object whenever the player clicks a given key.
 */
public class KeyboardSpawnerWithDelay : MonoBehaviour
{
    [Tooltip("Key to trigger a spawn")]
    [SerializeField]
    protected KeyCode keyToPress;

    [Tooltip("Prefab object to spawn")]
    [SerializeField]
    protected GameObject prefabToSpawn;

    [Tooltip("Object velocity")]
    [SerializeField]
    protected Vector3 velocityOfSpawnedObject;

    [Tooltip("Delay time in seconds")]
    [SerializeField]
    protected float delay;

    private float time;

    private bool hasShoted; // Flag that indicates if shot has been shoted

    protected virtual GameObject spawnObject()
    {
        // Step 1: spawn the new object.
        Vector3 positionOfSpawnedObject = transform.position; // span at the containing object position.
        Quaternion rotationOfSpawnedObject = Quaternion.identity; // no rotation.
        GameObject newObject =
            Instantiate(prefabToSpawn, positionOfSpawnedObject, rotationOfSpawnedObject);

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
        hasShoted = false;
        time = 0;
    }

    private void Update()
    {
        if (hasShoted)
        {
            time += Time.deltaTime;
            if (time >= delay)
            {
                hasShoted = false;
                time = 0;
            }
        }

        if (Input.GetKeyDown(keyToPress) && !hasShoted)
        {
            spawnObject();
            hasShoted = true;
        }
    }
}
