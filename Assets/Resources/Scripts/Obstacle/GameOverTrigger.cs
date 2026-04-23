using System.Collections;
using UnityEngine;

public class GameOverTrigger : MonoBehaviour
{
    private GameOverManager gameOver;

    private void Start()
    {
        gameOver = FindAnyObjectByType<GameOverManager>();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        collision.GetComponent<BirdMovement>();
        gameOver.EndGame();
        Debug.Log("1");
    }
}
