using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField]
    GameObject spawnPrefab;
    [SerializeField]
    int spawnCount = 5;
    [SerializeField]
    float spawnOffset = 1.5f;
    [SerializeField]
    float spawnTime = 1;

    private void Start()
    {
        if (spawnPrefab == null)
        {
            Debug.LogError("Missing prefab.");
        }
        else
        {
            StartCoroutine(SpawnEnemies());
        }
    }

    IEnumerator SpawnEnemies() 
    {
          for (int i = 0; i < spawnCount; i++)
        {
            float randomPosition = i * spawnOffset;
            Instantiate(spawnPrefab, new Vector3(transform.position.x + randomPosition, 0, 0), Quaternion.identity);

            yield return new WaitForSeconds(spawnTime);
        }
    }
}
