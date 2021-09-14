using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class neustart : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other)
    {
        
        if(other.tag == "Spieler")
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }
}
