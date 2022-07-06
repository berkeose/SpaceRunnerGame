using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletScript : MonoBehaviour

{ 
    void Start() {
        
        
        
    }
    
       private void OnTriggerEnter2D(Collider2D other) {
       
         if(other.tag=="Sınır"){
             Destroy(this.gameObject);

        
        }

         
    
        
    }
    
}
    
        

    
