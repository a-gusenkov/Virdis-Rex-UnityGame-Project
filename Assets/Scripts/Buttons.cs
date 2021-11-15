using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Buttons : MonoBehaviour
{
    public void nextScene(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    public void loadHome(){
        SceneManager.LoadScene("WelcomePage");
    }
    public void loadLevel2(){
        SceneManager.LoadScene(5);
    }
    public void loadEnd(){
        SceneManager.LoadScene("EndScreen");
    }
    public void loadBC1(){
        SceneManager.LoadScene("BadChoice1");

    }
    public void loadGC1(){
        SceneManager.LoadScene("GoodChoice1");
    }
    public void loadBC2(){
        SceneManager.LoadScene("BadChoice2");
    }
    public void loadGC2(){
        SceneManager.LoadScene("GoodChoice2");
    }
}
