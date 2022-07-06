using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    public float playerSpeed;
    public float boostSpeed;
    public float boostTimer;
    public bool boosting;
    public float speedCoolDown;
     
    
    Rigidbody2D RB ;
    private Vector2 playerDirection;

 void Start() {
     playerSpeed=10;
     boostTimer=0;
     boosting=false;
    

    RB=GetComponent<Rigidbody2D>();
    
}
   
    void Update()
    
    {
        float directionX=Input.GetAxisRaw("Horizontal");
        float directionY=Input.GetAxisRaw("Vertical");
        playerDirection=new Vector2(directionX,directionY);
        if(boosting){
            boostTimer+=Time.deltaTime;
            if(boostTimer>=3){
                Backround.backgroundSpeed=2;
                playerSpeed=12;
                boostTimer=0;
                boosting=false;
                Backround.backgroundSpeed=0.5f;

            }
        }
    }
    IEnumerator SpeedDuration(){
        yield return new WaitForSeconds(speedCoolDown);
        boostSpeed=playerSpeed;
        boostSpeed=Backround.backgroundSpeed;

    }
   void FixedUpdate() {
      RB.velocity=new Vector2(playerDirection.x*playerSpeed,playerDirection.y*playerSpeed);
      
  }
  
  
  private void OnTriggerEnter2D(Collider2D other) {
      if(other.tag=="Fast"){
          Destroy(other.gameObject);
          
          boosting=true;
          playerSpeed=12;
          Backround.backgroundSpeed=2;
          StartCoroutine("SpeedDuration");
          
          
         
          
      }
     
          
          
          
      
      }
  }
        
    

    

 

