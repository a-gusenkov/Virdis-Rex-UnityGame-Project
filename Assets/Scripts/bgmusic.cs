using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bgmusic : MonoBehaviour
{
    private static bgmusic BGmusic;

    void Awake(){

        if(BGmusic == null){
            BGmusic = this;
            DontDestroyOnLoad(BGmusic);
        }

        else{
            Destroy(gameObject);
        }
    }
    
}
