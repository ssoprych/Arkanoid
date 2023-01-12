using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundMusic : MonoBehaviour
{
    public AudioSource Music;
    
    public void MusicHandler(bool mute)
    {
        if(mute)
        {
            Music.Stop();
        }
        else
        {
            Music.Play();
        }
    }
}
