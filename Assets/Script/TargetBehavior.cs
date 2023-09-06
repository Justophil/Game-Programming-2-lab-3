using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetBehavior : MonoBehaviour
{
    public ScoreManager scoreManager;
    public void Start()
    {
        scoreManager = FindFirstObjectByType<ScoreManager>();
    }
    public void OnCollisionEnter(Collision other) {
        if(scoreManager != null) {
            if(other.gameObject.tag == "Projectile") {
                scoreManager.IncrementScore();
                Invoke("UnhideTargets",5.0f);
                gameObject.transform.parent.GetComponent<Renderer>().material.color = Color.red;
                gameObject.SetActive(false);
            }
        }
    }
    public void UnhideTargets() {
        gameObject.SetActive(true);
        gameObject.transform.parent.GetComponent<Renderer>().material.color = Color.green;
    }
}
