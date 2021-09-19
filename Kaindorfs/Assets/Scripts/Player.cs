using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    private int score;
    public Text scoreText;
    public Text highScoreText;
    public SpriteRenderer spriteRenderer;
    public Sprite newSprite;

    public DatabaseCharacter characterDB;
    public SpriteRenderer artworkSprite;


    // Start is called before the first frame update
    void Start()
    {
        score = 0;
        //aktuellen Highscore laden
        highScoreText.text = "Highscore: " + PlayerPrefs.GetInt("Highscore").ToString();
        

        CharacterSelection character = characterDB.GetCharacter(2);
        artworkSprite.sprite = character.characterSprite;
        //spriteRenderer.sprite = artworkSprite.sprite;

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "Coin")
        {
            //Grafik und Collider ausblenden
            other.gameObject.GetComponent<Renderer>().enabled = false;
            other.gameObject.GetComponent<Collider2D>().enabled = false;
            //Sound der Münze
            AudioSource audio = other.gameObject.GetComponent<AudioSource>();
            audio.Play();
            

            score++;
            scoreText.text = "Score: " + score.ToString();
            Destroy(other.gameObject, audio.clip.length);
            Debug.Log("Score:" + score);

            if(score > PlayerPrefs.GetInt("Highscore"))
            {
                PlayerPrefs.SetInt("Highscore", score);
                highScoreText.text = "Highscore: " + PlayerPrefs.GetInt("Highscore").ToString();
            }
        }
    }
    void ChangeSprite()
    {
        spriteRenderer.sprite = newSprite;
    }
}
