using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Wave_Scripts;

public class WaveSpawner : MonoBehaviour
{
    
    public GameObject prefab;
    public float startTime, endTime, spawnRate;
    // Start is called before the first frame update
    void Start()
    {
        WavesManager.instance.waves.Add(this);
        InvokeRepeating("Spawn", startTime, spawnRate);
        Invoke("EndSpawner", endTime);
    }

    private void EndSpawner()
    {
        WavesManager.instance.waves.Remove(this);
        CancelInvoke();
    }

    private void Spawn()
    {
        Instantiate(prefab, transform.position, transform.rotation);
    }
    

    // Update is called once per frame
    void Update()
    {
        
    }
}
