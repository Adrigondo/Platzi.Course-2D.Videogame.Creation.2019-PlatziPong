using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button : MonoBehaviour
{
    public AudioSource buttonAudio;
    public SceneChanger sceneChanger;
    public void ClickButton(string sceneName){
        buttonAudio.Play();
        sceneChanger.ChangeSceneTo(sceneName);
    }
}
