using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Puntuacion : MonoBehaviour
{
  GameManager GM;
    UserScore user;
    Spawner1 spawn;
    public int puntos=0;
    int mult=30;
    // Start is called before the first frame update
    void Start()
    {
        GM=FindObjectOfType<GameManager>();
        spawn=FindObjectOfType<Spawner1>();
        user=FindObjectOfType<UserScore>();
    }
    public void StartPuntos()
    {
        Invoke("sumarPuntos",0.5f);
        
    }

   public void pausarPuntos()
   {
       CancelInvoke();
   }
    void sumarPuntos()
    {
        puntos++;
        spawn.  TimeSpawn=GM.speed;
        if(user.Score%mult==0)
        {
            dificultad();
        }
        Invoke("sumarPuntos", 0.5f);
    }
     void dificultad()
    {

       
            if(spawn.TimeSpawn>0.8f)
            {
               spawn. TimeSpawn=spawn.TimeSpawn-0.2f;
            }
            else
            {
               spawn.TimeSpawn=0.7f;
            }
                GM.speed=spawn.TimeSpawn;


        
    }
}
