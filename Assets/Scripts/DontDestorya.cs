using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DontDestroy : MonoBehaviour
{
    private static DontDestroy BGmusic;

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
