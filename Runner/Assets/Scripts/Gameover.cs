 using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using  UnityEngine.SceneManagement;

public class Gameover : MonoBehaviour
{
    
    [SerializeField] Text text;
    public GameObject gameOver;
    static GameObject totalover;
   
    bool isFinish;

    


     
    // Start is called before the first frame update
    void Start()
    {
        //
        gameOver.gameObject.SetActive(false);
        Asteroid.isDestroy=false;
        
        
       
        
    }

    // Update is called once per frame
    void Update()
    {
       if(Asteroid.isDestroy==true){
             //Vector3 totalPos=totalover.transform.position;
             //totalPos.x=-282;
             //totalover.transform.position=totalPos;
             //totalover.gameObject.GetComponent<ScoreManager>().total.ToString();
            
          
            gameOver.SetActive(true);


             if(GameObject.FindGameObjectsWithTag("Player")==null){
            gameOver.SetActive(true);
           
        }
        
       
       
    
        
    }
    

    }
    
    
    public void Restrat(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    
    
    
    }}

