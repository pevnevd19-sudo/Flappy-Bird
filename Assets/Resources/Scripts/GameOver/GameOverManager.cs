using UnityEngine;
using UnityEngine.UI;

public class GameOverManager : MonoBehaviour
{
    [SerializeField] private GameObject player;
    Vector2 startPos = new Vector2(-10, 0);
    [SerializeField] private GameObject RestartPanel;

    [SerializeField] private GameObject pauseCanvas;
    [SerializeField] private Button pauseButton;
    public GameObject PauseCanvas => pauseCanvas;
    public Button PauseButton => pauseButton;

    private void Start()
    {
    }
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
        RestartPanel.SetActive(false);
        pauseButton.gameObject.SetActive(true);
        player.transform.position = startPos;
    }
    public void Home()
    {
        Debug.Log(0);
    }
    public void EndGame()
    {
        Time.timeScale = 0;
        RestartPanel.SetActive(true);
        pauseButton.gameObject.SetActive(false);
    }
}
