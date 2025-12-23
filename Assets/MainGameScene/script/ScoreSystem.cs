using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ScoreSystem : MonoBehaviour
{
    public int score = 0;
    public TextMeshProUGUI scoreText;
    void Start()
    {
        UpdateScoreUI();
    }

   public void AddScore(int value)
    {
        score += value;
        UpdateScoreUI();
    }

    void UpdateScoreUI()
    {
        scoreText.text = score.ToString();
    }
}
