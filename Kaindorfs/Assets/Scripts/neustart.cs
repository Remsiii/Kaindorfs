using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class neustart : MonoBehaviour
{
    public LevelManager levelManager;


    // Start is called before the first frame update
    void Start()
    {
        levelManager = FindObjectOfType<LevelManager>();
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        
        if(other.tag == "Spieler")
        {
            //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
            levelManager.RespawnPlayer();
        }
    }
}
