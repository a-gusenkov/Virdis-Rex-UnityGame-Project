using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Buttons : MonoBehaviour
{

  public Levels sk;

  void Update()
  {
       sk.checkMoneyZero();
        
  }

  public void nextScene()
  {
    SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
  }
 

  public void loadHome()
  {
    SceneManager.LoadScene("WelcomePage");
    sk.resertAllLevels();
  }
    public void loadEnd()
  {
    SceneManager.LoadScene("EndScreen");
  }

  public void loadSettings()
  {
    SceneManager.LoadScene("Settings");
  }

  //levels
  public void loadLevel1()
  {
    sk.resertAllLevels();
    SceneManager.LoadScene("Level1");
    
  }

  public void loadLevel2()
  {
    sk.checkMoneyZero();
    SceneManager.LoadScene("Level2");
  }
  public void loadLevel3()
  {
    sk.checkMoneyZero();
    SceneManager.LoadScene("Level3");
  }
  public void loadLevel4()
  {
    sk.checkMoneyZero();
    SceneManager.LoadScene("Level4");
  }
  public void loadLevel5()
  {
    sk.checkMoneyZero();
    SceneManager.LoadScene("Level5");
  }

  //BCGC
  
    public void loadBC1()
  {
    sk.LosePoint();
    sk.AddMoney();
    SceneManager.LoadScene("BadChoice1");

  }
  public void loadGC1()
  {
    sk.LoseMoney();
    sk.AddPoint();
    SceneManager.LoadScene("GoodChoice1");
  }
  public void loadBC2()
  {
    
    sk.LosePoint();
    SceneManager.LoadScene("BadChoice2");
  }
  public void loadGC2()
  {
    sk.AddMoney();
    sk.AddPoint();
    SceneManager.LoadScene("GoodChoice2");
  }
  public void loadBC3()
  {
    sk.LosePoint();
    sk.AddMoney();
    SceneManager.LoadScene("BC3");

  }
  public void loadGC3()
  {
    sk.LoseMoney();
    sk.AddPoint();
    SceneManager.LoadScene("GC3");
  }
  public void loadBC4()
  {
    sk.LosePoint();
    sk.AddMoney();
    SceneManager.LoadScene("BC4");
  }
  public void loadGC4()
  {
    sk.LoseMoney();
    sk.AddPoint();
    SceneManager.LoadScene("GC4");
  }
    public void loadBC5()
  {
    sk.LoseMoney();
    sk.LosePoint();
    SceneManager.LoadScene("BC5");
  }
  public void loadGC5()
  {
     sk.AddMoney();
    sk.AddPoint();
    SceneManager.LoadScene("GC5");
  }
}
