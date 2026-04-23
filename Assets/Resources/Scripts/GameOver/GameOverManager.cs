using UnityEngine;

public class GameOverManager : MonoBehaviour
{
    Vector2 startPos = new Vector2(-10, 0);
   public void StopGame()
    {
        Time.timeScale = 0;
    }
    public void StartGame()
    {
        Time.timeScale = 1;
    }
    public void RestartLevel()
    {
        Time.timeScale = 1;
        GameObject player = GameObject.FindGameObjectWithTag("Player");
        if (CompareTag("Player") == true) player.transform.position = startPos;
    }
    public void EndGame()
    {
        Time.timeScale = 0;

    }
}
