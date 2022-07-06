using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnAsteroids : MonoBehaviour

{
    public GameObject ammo;
    
    
    public bool destroyed=false;
    public GameObject asteroid;
    public GameObject star;
    public float maxX;
    public float minX;
    public float maxY;
    public float minY;
    public float timeNeedSpawn;
    public float timeNeedSpawnAmmo;
    public float spawnAmmoTime;
    public float spawnTime;
    public float maxStarX;
    public float maxStarY;
    public float minStarX;
    public float minStarY;
    public GameObject movingAsteroid;
    public float speed =2;
    


        void Start() {
            
           
       }
    
    
        void Update()
    {
        if(Time.time>spawnTime){
            Spawn();
            SpawnStar();
            spawnTime=Time.time+timeNeedSpawn;
        }
        if(Time.time>spawnAmmoTime){
            SpawnAmmo();
            spawnAmmoTime=Time.time+timeNeedSpawnAmmo;
           
        }
       
        
         
    }
       void Spawn(){
           float randomX=Random.Range(maxX,minX);
           float randomY=Random.Range(maxY,minY);
          
           
           Instantiate(asteroid,transform.position+new Vector3(randomX,randomY,0),transform.rotation);
           
          
        }
        void SpawnAmmo(){
            float randomAx=Random.Range(maxX,minX);
            float randomAy=Random.Range(maxY,minY);
            Instantiate(ammo,transform.position+new Vector3(randomAx,randomAy,0),transform.rotation);

        }
        void SpawnStar(){
             float RandomStarX=Random.Range(maxStarX,minStarX);
             float RandomStarY=Random.Range(maxStarX,minStarY);
             Instantiate(star,transform.position+new Vector3(RandomStarX,RandomStarY,0),transform.rotation);
        
}
        void Moving(){
           Instantiate(movingAsteroid,transform.position+=(Vector3.forward*speed*Time.deltaTime),transform.rotation);
            
            
        }
}
