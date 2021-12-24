using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner1 : MonoBehaviour
{
    public GameObject SpawnPoint;
    GameManager GM;
    public float TimeSpawn;
    public List<GameObject> obstaculos;

    public int randval;
    

    // Start is called before the first frame update
    void Start()
    {
         GM=FindObjectOfType<GameManager>();
        
       TimeSpawn=GM.speed;
    
        Spawn();
       
        
    }
    void Spawn()
    {
       
        randval=Random.Range(0,obstaculos.Count);
   
        
        Instantiate(obstaculos[randval],SpawnPoint.transform.position,SpawnPoint.transform.rotation);
        
        Invoke("Spawn",TimeSpawn);
    }
    
}
