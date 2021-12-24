using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnTrigger : MonoBehaviour
{
    UserScore user;
    GameManager GM;
   public GameObject PanelFin;
    void Awake()
    {
        user=FindObjectOfType<UserScore>();
        GM=FindObjectOfType<GameManager>();
        PanelFin.SetActive(false);

    }
    // Start is called before the first frame update
    void OnTriggerEnter(Collider coll)
    {
        if(coll.gameObject.tag=="Obstacle")
        {
            Debug.Log("pierde");
            PanelFin.SetActive(true);
            Time.timeScale=0;


            /*
            if(user.userLives==0)
            {
                Debug.Log("pierde");
                GM.GameOver();

            }
            else
            {
                user.userLives=user.userLives-1;
            }
            */
        }
    }
}
