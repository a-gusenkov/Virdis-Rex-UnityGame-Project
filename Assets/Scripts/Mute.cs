using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mute : MonoBehaviour
{
    bool isMute;
 
    public void MuteThis (){
        isMute = ! isMute;
        AudioListener.volume =  isMute ? 0 : 1;
    }
}
