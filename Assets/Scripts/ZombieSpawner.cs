using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieSpawner : MonoBehaviour
{
    public GameObject enemigo;
    // Start is called before the first frame update
    void Start()
    {
        Invoke("CrearEnemigo", (Random.Range(3, 15)));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void CrearEnemigo()
    {
        Instantiate(enemigo, transform.position, Quaternion.identity);
        float delay = Random.Range(5, 20);
        Invoke("CrearEnemigo", delay);
    }
}
