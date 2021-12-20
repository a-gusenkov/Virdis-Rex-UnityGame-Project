using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Levels : MonoBehaviour
{
    public Text leafPointText;
    public Text pointText;
    public Text moneyText;
    
    //leaf variable is general leaf point tracker of entire game
    //publicLeaf is the point tracker player sees
    public int leaf = 0;
    int point = 0;
    int money = 3;
    
    
    
    // Start is called before the first frame update
    void Start()
    {
        pointText.text = "Green Points : " + PlayerPrefs.GetInt("points", point).ToString();
        Debug.Log(point);
        
        moneyText.text = "Money : " + PlayerPrefs.GetInt("money", money).ToString();
        Debug.Log(money);
        
        leafPointText.text = "Leaves : " + leaf;
       DisplayScore();

    }

    // Update is called once per frame
    void Update()
    {
        

    }
    public void DisplayScore()
    {
        //leafPointText.text = "Leaves : " + leaf;
    }
    //in the future we can try making a hidden counter
    //for total points via leaf varibale
    public void AddPoints(){
        leaf += 1;
        
        leafPointText.text = "Leaves : " + leaf;
        DisplayScore();
        if(leaf == 5){
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
            leafPointText.text = "Leaves : " + leaf;
        }
      
    }


    public void AddPoint(){

        point = PlayerPrefs.GetInt("points");
        point = point + 1;
        PlayerPrefs.SetInt("points", point);

    }
    public void AddMoney(){
        money = PlayerPrefs.GetInt("money");
        money += 1;
        PlayerPrefs.SetInt("money", money);

    }
    public void LosePoint(){

        point = PlayerPrefs.GetInt("points");
        point = point - 1;
        PlayerPrefs.SetInt("points", point);
    }
    public void LoseMoney(){
        money = PlayerPrefs.GetInt("money");
        money = money - 1;

        // if( money == 0){

        // SceneManager.LoadScene("GameEndPoor");
        // //     SceneManager.LoadScene("Stage");
        // //     //PlayerPrefs.DeleteAll();
        // }
        PlayerPrefs.SetInt("money", money);
    }

    public void checkMoneyZero(){
         money = PlayerPrefs.GetInt("money");
         if (money == 0){
             SceneManager.LoadScene("EndScreenPoor"); 
             resertAllLevels();
         }

    }

    public void resertAllLevels(){
   
     //points
     int m = 3;
     int p = 0;
     PlayerPrefs.SetInt("money", m);
     PlayerPrefs.SetInt("points", p);
     moneyText.text = "Money : " + m.ToString();
     pointText.text = "Green Points : " + p.ToString();

    }
}
