using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class timer : MonoBehaviour
{
    // Start is called before the first frame update
     private  float minutes;
    private  float seconds;

    public float m,s;

    void Start()
    {
        minutes=0;
        seconds=0;        
        //startTimer(minutes,seconds);
    
      
    }
   

    // Update is called once per frame
  

    public void startTimer()
    {
    
        m=minutes;
        s=seconds;
       
        Invoke("updateTimer",1f);
    
    }
    public void stopTimer()
    {
        CancelInvoke();

    }

    public void updateTimer()
    {
        s++;
       
            if(s==59)
            {
                m++;
                s=0;
            }
          
        Invoke("updateTimer",1f);
         
    }
    

   
}
