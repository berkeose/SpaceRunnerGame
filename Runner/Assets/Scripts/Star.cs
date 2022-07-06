using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Star : MonoBehaviour
{
    public int starValue=1;
    public int total1=1;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D other) {
         if(other.tag=="Player"){
             Destroy(this.gameObject);

    // Update is called once per frame
    
    

}
if(other.tag=="Sınır"){
    Destroy(this.gameObject);
}
if(other.gameObject.CompareTag("Player")){
    ScoreManager.instance.ChangeScore(starValue);
    ScoreManager.instance.TotalScore(starValue,0);

}
}}
