using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMe : MonoBehaviour
{
    
    public Levels sk;

    public static bool GameIsPaused = false;
    public GameObject PauseMenuUI;
    // Update is called once per frame
    void Update()
    {
        
        
    }

    public void Resume(){
        PauseMenuUI.SetActive(false);
        GameIsPaused = false;
        Time.timeScale = 1f;
        

    }
    public void Pause(){
        PauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        GameIsPaused = true;
    }

    public void loadHome(){
    Time.timeScale = 1f;    
    SceneManager.LoadScene("WelcomePage");
    sk.resertAllLevels();
    }

}
