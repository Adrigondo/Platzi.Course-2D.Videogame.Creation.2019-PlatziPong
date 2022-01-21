using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallBehavior : MonoBehaviour
{
    public Transform paddle;
    public bool gameStarted;
    float posDifX, posX, posY, posZ;
    public Rigidbody2D rbBall;
    public AudioSource audioBall;

    // Start is called before the first frame update
    void Start()
    {
        posDifX=paddle.position.x - transform.position.x;
    }

    // Update is called once per frame
    void Update()
    {
        if(!gameStarted){
            ///Calculate the position of paddle and assign to the ball
            posX=paddle.position.x - posDifX;
            posY=paddle.position.y;
            posZ=paddle.position.z;
            transform.position= new Vector3(posX,posY,posZ);

            if(Input.GetMouseButtonDown(0)){
                gameStarted=true;
                rbBall.velocity= new Vector2(10,10);
            }
        }
    }
    private void OnCollisionEnter2D(Collision2D collision){
        if (gameStarted){
            audioBall.Play();
        }
    }
}
