using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelManager : MonoBehaviour
{

    // abgespeichert: akutelle Checkpoint, Spieler gameobjekt
    public GameObject currentCheckpoint;
    public GameObject spieler;

    public int leben;
    public Text textLeben;



    //Escape
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            //Spiel wird beendet
            Application.Quit();
        }
    }

    
    public void RespawnPlayer()
    {
        

        spieler.transform.position = currentCheckpoint.transform.position;
    }
    

}
