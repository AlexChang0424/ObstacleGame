using UnityEngine;
using UnityEngine.UI; 

public class Scorer : MonoBehaviour
{
    private int hits; 
    public Text ScoreText;

    void Start() 
    {
        hits = 0;
        SetScoreText();    
    }
    void OnCollisionEnter(Collision other) 
    {

        if(other.gameObject.tag != "Hit")
        {
             hits++;
             SetScoreText();
             Debug.Log("Number of times you've bumped into something :"+ hits);
        }
    }

    void SetScoreText()
    {
        ScoreText.text = "HitCounts = " + hits.ToString();
    }
}
