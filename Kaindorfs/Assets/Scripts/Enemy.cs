using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Enemy : MonoBehaviour
{
    public LevelManager levelManager;

    // Start is called before the first frame update
    void Start()
    {
        levelManager = FindObjectOfType<LevelManager>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter2D(Collision2D other)
    {
        if(other.gameObject.tag == "Spieler")
        {
            // SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
            levelManager.RespawnPlayer();
        }
    }
}
