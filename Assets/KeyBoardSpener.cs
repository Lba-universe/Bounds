using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyBoardSpener : MonoBehaviour
{
    [SerializeField] protected KeyCode keyToPress;
    [SerializeField] protected GameObject prefabToSpawn;
    [SerializeField] protected Vector3 velocityOfSpawnedObject;

    protected virtual GameObject spawnObject()
    {
        // Step 1: spawn the new object.
        Vector3 positionOfSpawnedObject = transform.position;  // span at the containing object position.
        Quaternion rotationOfSpawnedObject = Quaternion.identity;  // no rotation.
        GameObject newObject = Instantiate(prefabToSpawn, positionOfSpawnedObject, rotationOfSpawnedObject);



        return newObject;
    }

    private void Update()
    {
        if (Input.GetKeyDown(keyToPress))
        {
            spawnObject();
        }
    }
}
