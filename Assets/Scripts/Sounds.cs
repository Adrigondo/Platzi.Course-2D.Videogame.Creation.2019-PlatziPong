using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sounds : MonoBehaviour
{
    // Start is called before the first frame update
    public void PlayAudio(AudioSource audio){
        audio.Play();
    }
}
