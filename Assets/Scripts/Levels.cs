using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Levels : MonoBehaviour
{
    [SerializeField] Text leafPointText;
    
    //leaf variable is general leaf point tracker of entire game
    //publicLeaf is the point tracker player sees
    public int leaf = 0;
    public int publicLeaf;
    public int green;
    
    // Start is called before the first frame update
    void Start()
    {
        
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
    public void AddPoints(int points){
        leaf += points;
        publicLeaf += points;
        DisplayScore();
        if(leaf == 5){
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
            publicLeaf = 0;
        }
        if(leaf == 10){
            SceneManager.LoadScene("LevelText2");
        }
    }
}
