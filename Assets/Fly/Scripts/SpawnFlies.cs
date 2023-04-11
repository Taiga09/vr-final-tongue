using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnFlies : MonoBehaviour
{
    [Tooltip("The object to spawn")]
    public GameObject objectToSpawn;

    [Tooltip("Transform for how the object will be spawned")]
    public Transform spawnPoint;

    [Tooltip("Will the spawned object be childed to the point?")]
    public bool attachToSpawnPoint;

    private GameObject currentObject;

    public void SpawnObject()
    {
        if (objectToSpawn != null)
        {
            GameObject newObject = Instantiate(objectToSpawn, spawnPoint.position, spawnPoint.rotation);

            if (attachToSpawnPoint)
                newObject.transform.SetParent(spawnPoint);

            ReplaceObject(newObject);
        }
    }

    private void ReplaceObject(GameObject newObject)
    {
        if (currentObject != null)
            Destroy(currentObject);

        currentObject = newObject;
    }

    private void OnValidate()
    {
        if (spawnPoint == null)
            spawnPoint = transform;
    }
}
