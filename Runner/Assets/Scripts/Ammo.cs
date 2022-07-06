using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ammo : MonoBehaviour

{
    public GameObject ammo;
    public float delay;
    private int amountSpawned;
    public float spawnTimer;
    public float needTime;
    public float maxAmmoX;
    public float minAmmoX;
    public float maxAmmoY;
    public float minAmmoY;
   
 
     //Start is called before the first frame update
     
    void Start()

   {
       
       
       
      
      
       
         
        
        
    }

    // Update is called once per frame
    void Update()
   {
      
       }
    
     
       
    
    
       
         
        
    

       
          
    
     private void OnTriggerEnter2D(Collider2D other) {
         if(other.tag=="Player"){
            Destroy(this.gameObject);
            Shoot.BulletCount+=10;
           
           
             
         }
         
         
        
    }
     
         
         
    

    }

