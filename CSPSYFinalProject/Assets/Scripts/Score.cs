using UnityEngine;
using UnityEngine.UI;

public class ScoreCounter : MonoBehaviour
{
    public Transform player;
    public Text scoreText;
    public int score;

    // Update is called once per frame
    void Update()
    {
        scoreText.text = "Score: " + score;
    }

    void incrementScore()
    {
        score++;
    }
}
