using UnityEngine;
using UnityEngine.SceneManagement;

public class ExitTrigger : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            // Mark the player as having reached the exit
            FuelSystem fuelSystem = other.GetComponent<FuelSystem>();
            if (fuelSystem != null)
            {
                fuelSystem.reachedExit = true;
            }

            // Check if it's the final level
            if (SceneManager.GetActiveScene().name == "Level05")
            {
                GameOutcomeManager.lastOutcome = GameOutcomeManager.Outcome.Victory;
                SceneManager.LoadScene("Outcome");
            }
            else
            {
                // Load next level
                int currentIndex = SceneManager.GetActiveScene().buildIndex;
                SceneManager.LoadScene(currentIndex + 1);
            }
        }
    }
}
