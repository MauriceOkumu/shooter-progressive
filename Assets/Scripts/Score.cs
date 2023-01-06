using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Score : MonoBehaviour
{
    int score = 1;
    private void OnCollisionEnter(Collision other)
    {
        score = score + 1;
        Debug.Log("The score is :" + score);
    }
}
