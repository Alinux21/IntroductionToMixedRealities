using UnityEngine;
using TMPro;
public class ScoreManager : MonoBehaviour
{
    public TextMeshPro scoreText; 
    private int score = 0; 

    public void AddScore()
    {
        score++; 
        DisplayScoreUpdate(); 
    }

    void DisplayScoreUpdate()
    {
        scoreText.text = "Holes Scored: " + score;
    }
}


