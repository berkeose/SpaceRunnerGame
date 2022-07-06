using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Shoot : MonoBehaviour
{
    public GameObject Ammo;
    public Transform ammo;
    public Transform bullet;
    public GameObject Bullet;
    public GameObject Burstshoot;
    Vector2 direction;
    public float BulletSpeed;
    public static int BulletCount =10;
    public bool isFiring;
    public Text ammoDisplay;
    public bool isTouched;
     
    public float coolDown;

    public float Timer;
    public bool isChange;
    
   
    
    

    // Start is called before the first frame update
    void Start()
    {
        isChange=false;
        Timer=0;
        
        
        Bullet.SetActive(true);
        
       
        


        
    }
    
    

    // Update is called once per frame
    void Update()
    {
        
       
        Vector2 mousePose=Camera.main.ScreenToWorldPoint(Input.mousePosition);
        direction=mousePose-(Vector2)bullet.position;
        if(Input.GetMouseButtonDown(0)){
            shoot();
            destroy();
            if(Burst.change==true){
            burst();
           
            
            
           
            
        }}

    
          ammoDisplay.text=BulletCount.ToString();
           if(Input.GetMouseButtonDown(0)&&BulletCount>0){
            
            BulletCount--;
           
            

        
        
        
     } 
     if(isChange){
         Timer+=Time.deltaTime;
         if(Timer>=3){
             isChange=false;
             Timer=0;
         }
     }
       
       
        

        
        
    }
    void destroy(){
        if(BulletCount==0){
            
            Bullet.SetActive(false);
           
            
        }
    
    }
    
    void shoot(){
      GameObject BulletIn=  Instantiate(Bullet,bullet.position,bullet.rotation);
      BulletIn.GetComponent<Rigidbody2D>().AddForce(BulletIn.transform.right*BulletSpeed);
      
    }
    
     void burst(){
        for(int i =0;i<=2;i++){
       GameObject BulletIn= Instantiate(Bullet,bullet.position,bullet.rotation) ;
       switch (i){
           case 0:
           BulletIn.GetComponent<Rigidbody2D>().AddForce(BulletIn.transform.right*BulletSpeed+new Vector3(0f,-90f,0f));
           break;
           case 1:
           BulletIn.GetComponent<Rigidbody2D>().AddForce(BulletIn.transform.right*BulletSpeed+new Vector3(0f,0f,0f));
           break;
           case 2:
           BulletIn.GetComponent<Rigidbody2D>().AddForce(BulletIn.transform.right*BulletSpeed+new Vector3(0f,90f,0f));
           break;
           
          
           
       }


    }}
     private void OnTriggerEnter2D(Collider2D other) {
       
         if(other.tag=="Sınır"){
             Destroy(bullet);
             Bullet.SetActive(false);
         }
         if(other.gameObject.CompareTag("ammo")){
             Bullet.SetActive(true);
         }
        
         }
        
    }
     
        
    

     
    

  

