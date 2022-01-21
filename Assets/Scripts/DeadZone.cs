using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class DeadZone : MonoBehaviour
{
    // private void OnCollisionEnter2D(Collision2D collision){
    //     Debug.Log("Colisión");
    // }
    public Text scoreLabel1;
    public Text scoreLabel2;
    public SceneChanger sceneChanger;
    int scoreQuantity1=0;
    int scoreQuantity2=0;
    public AudioSource audioPoint;
    
    private void OnTriggerEnter2D(Collider2D ball){
        if(gameObject.tag=="DeadZoneLeft"){
            UpdateScoreLabel(scoreLabel2, ++scoreQuantity2);
        }else if(gameObject.tag=="DeadZoneRight"){
            UpdateScoreLabel(scoreLabel1, ++scoreQuantity1);
        }
        audioPoint.Play();
        ball.GetComponent<BallBehavior>().gameStarted=false;
        CheckScore();
    }

    void CheckScore(){
        if(scoreQuantity1>=5){
            sceneChanger.ChangeSceneTo("WinScene");
        }else if(scoreQuantity2>=5){
            sceneChanger.ChangeSceneTo("LoseScene");
        }
    }
    void UpdateScoreLabel(Text label, int score){
        label.text=score.ToString();
    }
}
