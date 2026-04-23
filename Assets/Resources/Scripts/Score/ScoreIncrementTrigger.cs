using UnityEngine;

public class ScoreIncrementTrigger : MonoBehaviour
{
    [SerializeField] private PlayerScore playerScore;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.GetComponent<BirdMovement>())
        {
            playerScore.AddScore(1);
        }
        Destroy(gameObject);
    }
}
