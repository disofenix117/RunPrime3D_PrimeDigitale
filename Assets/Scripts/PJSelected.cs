using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PJSelected : MonoBehaviour
{
   //  public Animator IDLE;
     public GameObject playerObject;

    public GameObject[] playerObjects;

    public int selectedCharacter;
    // Start is called before the first frame update
    void Start()
    {
        selectedCharacter = PlayerPrefs.GetInt("PJ",0);
        GameObject Pj=Instantiate(playerObjects[selectedCharacter]) as GameObject;
        Pj.transform.parent=playerObject.transform;
        Pj.transform.position=playerObject.transform.position;
        playerObject.GetComponent<Animator>().avatar=Pj.GetComponent<Animator>().avatar;
        
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
