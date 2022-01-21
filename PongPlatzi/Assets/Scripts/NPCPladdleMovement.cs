using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Assertions.Comparers;
using UnityEngine.Timeline;

public class NPCPladdleMovement : MonoBehaviour
{
    public Transform ball;
    public float speed;
    float posX, posY, posZ, posYNueva, speedStable;
    // Update is called once per frame
    void Update()
    {
        if(ball.GetComponent<BallBehavior>().gameStarted){
            posX=transform.position.x;
            posY=transform.position.y;
            posZ=transform.position.z;
            speedStable=speed*Time.deltaTime;
            if((transform.position.y - ball.position.y)<(0-speedStable)){
                posYNueva=posY+speed*Time.deltaTime;
            }else if((transform.position.y - ball.position.y) > speedStable){
                posYNueva=posY-speed*Time.deltaTime;
            }
            transform.position=new Vector3(posX, Mathf.Clamp(posYNueva, -3.9f, 3.9f), posZ);
        }
    }
}
