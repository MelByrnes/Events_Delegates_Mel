using UnityEngine;

public class PrefabSpawner : MonoBehaviour
{

    objectPooler pooler;

    private void Start()
    {
        pooler = objectPooler.Instance;
    }


    private void FixedUpdate()
    {
        pooler.SpawnFromPool("Cube", transform.position, Quaternion.identity);
    }
}
