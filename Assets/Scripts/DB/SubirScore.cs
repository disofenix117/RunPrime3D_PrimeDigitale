using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SubirScore : MonoBehaviour
{
  string inserarDatos="https://prime-pruebasweb.com/rankingRun/insertar.php";
  //string inserarDatos="http://localhost/paginaweb/Prime%20Digital%20Pruebas/Juego%20Run/Scores/insertar.php";
  
  
    public int score;
    public string tiempo;

    public void Enviar()
{
    StartCoroutine("subirscore");
    SceneManager.LoadScene("TotalScore");
     

}

   IEnumerator subirscore()
   {
        
        score=GetComponent<UserScore>().Score;
        tiempo=GetComponent<UserScore>().Time;
        

        WWWForm form = new WWWForm();
        form.AddField("nombre", PlayerPrefs.GetString("user"));
        form.AddField("score", score);
        form.AddField("tiempo", tiempo);
       
       WWW subir =new WWW(inserarDatos,form);
       yield return subir;
       Debug.Log(subir.text);   
       
   }
}
