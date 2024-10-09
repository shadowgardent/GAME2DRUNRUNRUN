using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject []carPrefab;
    public float delay = 0.8f;
    public float nextTime;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (nextTime<=Time.time)
        {
            spawnCar();
            nextTime = Time.time + delay ;
        }
        
    }
    void spawnCar()
    {   
        int randomCar = Random.Range(0,carPrefab.Length);
        Instantiate(carPrefab[randomCar],transform.position,transform.rotation);
    }
}
