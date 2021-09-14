using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour
{
    // abgespeichert: akutelle Checkpoint, Spieler gameobjekt
    public GameObject currentCheckpoint;
    public GameObject spieler;
    // Start is called before the first frame update
    public void RespawnPlayer()
    {
        spieler.transform.position = currentCheckpoint.transform.position;
    }
    

}
