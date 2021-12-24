using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIGame : MonoBehaviour
{

    UserScore user;
    timer Timer;
    Puntuacion puntos;
    public Text Score;
    public Text Time;
 

    // Start is called before the first frame update
    void Start()
    {
        user=GetComponent<UserScore>();
        Timer=GetComponent<timer>();
        puntos=GetComponent<Puntuacion>();
        
        
        user.Score=0;
        Timer.startTimer();
        puntos.StartPuntos();
        
    }

    // Update is called once per frame
    void Update()
    {
        user.Score=puntos.puntos;
        Score.text=user.Score.ToString(); 
        if(Timer.s<10)
        {
            Time.text=Timer.m.ToString()+":0"+Timer.s.ToString();  
        }
        else
        {
            Time.text=Timer.m.ToString()+":"+Timer.s.ToString();  
        }
        user.Time=Timer.m.ToString()+":"+Timer.s.ToString();
        

        
    }
}
