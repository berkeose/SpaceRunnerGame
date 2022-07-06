using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Burst : MonoBehaviour
{
    public static bool change=false;
    // Start is called before the first frame update
    void Start()
    {
        

        
    }
    private void OnTriggerEnter2D(Collider2D other) {
       
         if(other.tag=="Player"){
             Destroy(this.gameObject);
            change=true;
            Destroy(this.gameObject,5f);
        
    }
}}
        
       

    // Update is called once per frame
    
    

