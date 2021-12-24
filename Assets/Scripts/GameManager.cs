using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    Puntuacion puntos;
    public Spawner spawn;
    UserScore user;
    timer time;
    public GameObject PanelPausa;
    public GameObject PanelGameOver;
    int mult;
    public float speed;
    
    public GameObject Player;
    // Start is called before the first frame update
    void Awake()
    {
        PanelGameOver.SetActive(false);
        PanelPausa.SetActive(false);
        time=GetComponent<timer>();
        puntos=GetComponent<Puntuacion>();
        spawn=GetComponent<Spawner>();
        user=FindObjectOfType<UserScore>();
        Time.timeScale=1;
        speed=3f;


        
        
    }

    // Update is called once per frame
    void Update()
    {
      

        
    }
    public void Pause()
    {
        time.stopTimer();
        puntos.pausarPuntos();
        Time.timeScale=0;

    }
    public void Reanudar()
    {
        time.updateTimer();
        puntos.StartPuntos();
        Time.timeScale=1;

    }
    public void GameOver()
    {
         time.stopTimer();
        puntos.pausarPuntos();
        Time.timeScale=0;
        PanelGameOver.SetActive(true);

    }
   
}
