using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class FuelSystem : MonoBehaviour
{
    public float maxFuel = 5f;
    public float currentFuel;
    public float fuelDrainRate = 1f;

    public Image fuelBarFill;
    private bool isSpraying => Input.GetMouseButton(0);

    public bool reachedExit = false;
    private bool triggeredOutcome = false;

    void Start()
    {
        currentFuel = maxFuel;
    }

    void Update()
    {
        if (isSpraying && currentFuel > 0f)
        {
            currentFuel -= fuelDrainRate * Time.deltaTime;
            if (currentFuel < 0f) currentFuel = 0f;
        }

        UpdateFuelBar();
        if (currentFuel <= 0f && !reachedExit && !triggeredOutcome)
        {
            triggeredOutcome = true;
            GameOutcomeManager.lastOutcome = GameOutcomeManager.Outcome.GameOver;
            SceneManager.LoadScene("Outcome");
        }

    }

    void UpdateFuelBar()
    {
        if (fuelBarFill != null)
        {
            fuelBarFill.fillAmount = currentFuel / maxFuel;
        }
    }

    public bool HasFuel()
    {
        return currentFuel > 0f;
    }

    public void AddFuel(float amount)
    {
        currentFuel += amount;
        if (currentFuel > maxFuel)
        {
            currentFuel = maxFuel;
        }

        UpdateFuelBar();
    }

}
