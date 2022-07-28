using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Generator : MonoBehaviour
{
    public GameObject bulletsPrefab;
    public float delaySpawn = 2f;
    public float intervalSpawn = 2f;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnEnemy", delaySpawn, intervalSpawn);
    }
    private void SpawnEnemy()
    {
       Instantiate(bulletsPrefab);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
