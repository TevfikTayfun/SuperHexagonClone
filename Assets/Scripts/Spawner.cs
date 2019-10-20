using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{

    public float spawnRate = 1f;
    public GameObject Hexagon;
    private float nextTimetoSpawn = 0f;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Time.time >= nextTimetoSpawn)
        {
            Instantiate(Hexagon, Vector3.zero, Quaternion.identity);
            nextTimetoSpawn = Time.time + 1f / spawnRate;
        }
    }
}
