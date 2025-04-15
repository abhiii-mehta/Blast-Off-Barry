using UnityEngine;
using UnityEngine.SceneManagement;

public class OutcomeManager : MonoBehaviour
{
    public GameObject gameOverPanel;
    public GameObject victoryPanel;

    void Start()
    {
        Time.timeScale = 0f;

        Debug.Log("Game Outcome: " + GameOutcomeManager.lastOutcome); //  Debug line

        if (GameOutcomeManager.lastOutcome == GameOutcomeManager.Outcome.Victory)
        {
            victoryPanel.SetActive(true);
        }
        else
        {
            gameOverPanel.SetActive(true);
        }
    }

    public void RestartGame()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("Level01");
    }

    public void ReturnToMainMenu()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("MainMenu");
    }

    public void ExitGame()
    {
        Application.Quit();
    }
}
