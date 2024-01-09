
using System.Collections.Generic;
using UnityEngine;

public class SpawnArea : MonoBehaviour
{
    Mesh mesh;

    [SerializeField]
    List<GameObject> prefabs;

    void Awake()
    {
        mesh = GetComponent<MeshFilter>().mesh;
    }

    public void Spawn() 
    {
        Vector3 randomPoint = GetRandomPointInBounds(mesh.bounds);

        Instantiate(GetRandomGameObject(), randomPoint, Quaternion.identity);
    }

    public GameObject GetRandomGameObject()
    {
        int randomIndex = Random.Range(0, prefabs.Count);

        return prefabs[randomIndex];
    }

    public Vector3 GetRandomPointInBounds(Bounds bounds)
    {
        return transform.TransformPoint(new Vector3(
            Random.Range(bounds.min.x, bounds.max.x),
            Random.Range(bounds.min.y, bounds.max.y),
            Random.Range(bounds.min.z, bounds.max.z)
        ));
    }
}
