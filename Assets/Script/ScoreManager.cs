using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    public int score = 0;
    // Start is called before the first frame update
    public void IncrementScore()
    {
        score += 1;
        if(score >= 5) {
            Debug.Log("You Win!");
            score = 0;
        }
    }
}
