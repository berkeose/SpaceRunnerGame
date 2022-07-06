using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Asteroid : MonoBehaviour
{
    public int destroyedAsteroid=1;
    public int total2=1;
    GameObject ammo;
    public static bool isDestroy=false;
    
   
   
        
    void Start() {
      
        
        
    }
    
        private void OnTriggerEnter2D(Collider2D other) {
            if(other.tag=="Sınır"){
                Destroy(this.gameObject);
         }
            if(other.tag=="bullet"){
             Destroy(other.gameObject);
             Destroy(this.gameObject);
             destroyedAsteroid++;
            

             }
             if(other.gameObject.CompareTag("bullet")){
                 ScoreManager.instance.DestroyedAsteroid(destroyedAsteroid);
                 ScoreManager.instance.TotalScore(0,total2);
             }
              if(other.tag=="Player"){
                 Destroy(other.gameObject);
                 isDestroy=true;
                 
                 

             }
         }   
         
              
        
    }
        
    
 
    
    
    
        
       



