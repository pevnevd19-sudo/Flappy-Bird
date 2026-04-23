using UnityEngine;
using UnityEngine.UI;

public class PauseCanvasManager : MonoBehaviour
{

    private GameOverManager gameOverManager;

    private void Start()
    {
        gameOverManager = FindAnyObjectByType<GameOverManager>();
    }

    public void ActivateMenu(bool status)
    {
        gameOverManager.PauseCanvas.SetActive(status);
        if (status)
        {
            gameOverManager.PauseButton.gameObject.SetActive(false);
            gameOverManager.StopGame();
        }
        else if (!status)
        {
            gameOverManager.PauseButton.gameObject.SetActive(true);
            gameOverManager.StartGame();
        }
    }
    public void OptionButtonPress()
    {

    }
    public void ExitButtonPress()
    {

    }
}
