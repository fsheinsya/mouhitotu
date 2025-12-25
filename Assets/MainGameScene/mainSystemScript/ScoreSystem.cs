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

    //ƒXƒRƒA‚ª‚½‚è‚Ä‚¢‚é‚©‚Ç‚¤‚©
    public bool CanSpend(int amount)
    {
        return score >= amount;
    }

    public void Spend(int amount)
    {
        score -= amount;
        UpdateScoreUI();
    }
}
