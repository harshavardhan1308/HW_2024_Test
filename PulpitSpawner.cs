using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PulpitSpawner : MonoBehaviour
{
    public GameObject pulpitPrefab;
    public float minDestroyTime = 4f;
    public float maxDestroyTime = 5f;
    public float spawnTime = 2.5f;

    private GameObject currentPulpit;
    // Start is called before the first frame update
    void Start()
    {
        SpawnPulpit();
        
    }

    // Update is called once per frame
    void SpawnPulpit()
    {
        float destroyTime = Random.Range(minDestroyTime, maxDestroyTime);

        Vector3 randomPosition = new Vector3(Random.Range(-9, 9), 0.5f, Random.Range(-9, 9));
        currentPulpit = Instantiate(pulpitPrefab, randomPosition, Quaternion.identity);

        Destroy(currentPulpit, destroyTime);

        Invoke("SpawnPulpit", spawnTime);
    }
    
}
