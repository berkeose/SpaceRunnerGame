using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager instance;
    public int score;
    public TextMeshProUGUI text;
    public int asteroidScore;
    public int starScore;
    public int asteroidCalculator;
    public int totalScore;
    public TextMeshProUGUI Atext;
    public TextMeshProUGUI total;
    // Start is called before the first frame update
    void Start()
    {
        if(instance==null){
            instance=this;
        }
        
    }
    public void ChangeScore(int starScore){
        score+=starScore;
        text.text="X"+score.ToString();

    }
    public void DestroyedAsteroid(int asteroidScore){
        asteroidCalculator+=asteroidScore;
        Atext.text="X"+score.ToString();
        

    }
    public void TotalScore(int total1,int total2){
        totalScore+=total1+total2;
        total.text=""+totalScore.ToString();
        return;
    }

    // Update is called once per frame
  
}
