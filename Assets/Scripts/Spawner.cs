using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject SpawnPoint;
    public float TimeSpawn=3f;
    public List<GameObject> obstaculos;

    public int randval;

    // Start is called before the first frame update
    void Start()
    {
        Spawn();
        
    }

  
    void Spawn()
    {
        randval=Random.Range(0,obstaculos.Count);
        Instantiate(obstaculos[randval],SpawnPoint.transform.position,SpawnPoint.transform.rotation);
        Invoke("Spawn",TimeSpawn);
    }
}
