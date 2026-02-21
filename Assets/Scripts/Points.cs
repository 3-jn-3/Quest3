using UnityEngine;
using TMPro;

public class Points : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI scoreText;
    private int currentScore = 0;

    void Start()
    {
        UpdateScoreUI();
    }

    public void AddPoints(int points)
    {
        currentScore += points;
        UpdateScoreUI();
        Debug.Log("Score is now: " + currentScore);
    }

    public void SubtractPoints(int points)
    {
        currentScore -= points;
        currentScore = Mathf.Max(0, currentScore);
        UpdateScoreUI();
    }

    void UpdateScoreUI()
    {
        if (scoreText != null)
        {
            scoreText.text = currentScore.ToString();
        }
    }
}