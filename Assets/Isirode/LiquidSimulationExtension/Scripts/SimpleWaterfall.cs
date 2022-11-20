using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleWaterfall : MonoBehaviour
{
    public GameObject prefab;
    public GameObject owner;

    public int maxSpawn = 10;
    private int currentSpawnCount = 0;

    public float spawnRatePerSeconds = 1f;
    public float spawnTiming = 1f;

    public bool isSpawning = true;

    private Coroutine repeatingCoroutine;

    private void Start()
    {
        spawnTiming = 1f / spawnRatePerSeconds;
        if (isSpawning)
        {
            repeatingCoroutine = StartCoroutine(AddPoint());
        }
    }

    IEnumerator AddPoint()
    {
        while (currentSpawnCount < maxSpawn && isSpawning == true)
        {
            Transform ownerTransform;
            if (owner != null)
            {
                ownerTransform = owner.transform;
            }
            else
            {
                ownerTransform = this.gameObject.transform;
            }
            var gameObject = Instantiate(prefab, ownerTransform);
            gameObject.transform.position = ownerTransform.position;

            currentSpawnCount += 1;

            yield return new WaitForSeconds(spawnTiming);
        }
    }

    public void ResetState(bool removeInstances)
    {
        if (repeatingCoroutine != null) 
        {
            StopCoroutine(repeatingCoroutine);
        }
        if (removeInstances)
        {
            if (owner != null)
            {
                foreach (Transform childTransform in owner.transform)
                {
                    GameObject.Destroy(childTransform.gameObject);
                }
            }
            else
            {
                // TODO : it is not allowed yet because we could put a GameObject 'symbol' in the waterfall
                // By filtering on the tags, it could be possible to enable this functionality
                Debug.LogWarning($"You have asked to remove instances but it required to have the {nameof(owner)} property set.");
            }
        }
        currentSpawnCount = 0;
        isSpawning = false;
    }

    public void Pause()
    {
        isSpawning = false;
    }

    public void ReStart()
    {
        isSpawning = true;
    }
}
