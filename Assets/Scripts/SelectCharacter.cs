using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectCharacter : MonoBehaviour
{
    public Animator IDLE;
    public GameObject[] playerObjects;


    public int selectedCharacter = 0;
   
    void Start()
    {
         HideAllCharacters();

        selectedCharacter = PlayerPrefs.GetInt("PJ", 0);
        selectedCharacter=selectedCharacter-1;

        playerObjects[selectedCharacter].SetActive(true);
        IDLE.avatar=playerObjects[selectedCharacter].GetComponent<Animator>().avatar;

        
    }

 
  private void HideAllCharacters()
    {
        foreach (GameObject g in playerObjects)
        {
            g.SetActive(false);
        }
    }
    
    public void NextCharacter()
    {
        playerObjects[selectedCharacter].SetActive(false);
        selectedCharacter++;
        if (selectedCharacter >= playerObjects.Length)
        {
            selectedCharacter = 0;
        }
        playerObjects[selectedCharacter].SetActive(true);
        IDLE.avatar=playerObjects[selectedCharacter].GetComponent<Animator>().avatar;
    }

    public void PreviousCharacter()
    {
        playerObjects[selectedCharacter].SetActive(false);
        selectedCharacter--;
        if (selectedCharacter < 0)
        {
            selectedCharacter = playerObjects.Length-1;
        }
        playerObjects[selectedCharacter].SetActive(true);
        IDLE.avatar=playerObjects[selectedCharacter].GetComponent<Animator>().avatar;
    }
    public void StartGame()
    {
        PlayerPrefs.SetInt("PJ", selectedCharacter+1);
    }
}
