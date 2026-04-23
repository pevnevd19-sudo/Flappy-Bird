using TMPro;
using UnityEngine;

public class PlayerScore : MonoBehaviour
{
    [SerializeField] private TMP_Text scoreTXT;
    private int score;

    private void Start()
    {
        scoreTXT = GetComponent<TMP_Text>();
        scoreTXT.text = "Score: " + 0;
    }

    public void AddScore(int amount)
    {
        score += amount ;
        UpdateScoreUI();
    }
    private void UpdateScoreUI()
    {
        scoreTXT.text = "Score: " + score;
    }
}
