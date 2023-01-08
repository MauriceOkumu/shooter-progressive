using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Score : MonoBehaviour
{
    public TMP_Text scoretext;
    public static int score = 0;

    void Start() {
       scoretext = GetComponent<TMP_Text>();
       scoretext.text = "SCORE : 0";
    }
     private void Update() {
       
        scoretext.text = score.ToString();
    }

    public void updateScore(int amount){
        score = score + amount;
        Debug.Log(score.ToString());
       
    }

}
