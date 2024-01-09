using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField]
    int maxObjectsOnScreen = 10;
    int currentObjectsOnScreen;

    SpawnArea spawnArea;

    void Awake()
    {
        spawnArea = GameObject.Find("SpawnArea").GetComponent<SpawnArea>();
    }

    private void Update()
    {
        if (currentObjectsOnScreen < maxObjectsOnScreen)
        {
            spawnArea.Spawn();
            currentObjectsOnScreen++;
        }
    }

    public void DecreaseCurrentObjectsOnScreen()
    {
        currentObjectsOnScreen--;
    }
}
