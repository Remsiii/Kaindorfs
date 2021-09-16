using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OnClickButtons : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void StartButton()
    {
        SceneManager.LoadScene("CharacterSelection");
    }

    public void NextButton()
    {
        SceneManager.LoadScene("SceneEnterSchool");
    }
    public void Quit()
    {


        //im editor qutien
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#else 
Application.Quit();
#endif
    }
}
