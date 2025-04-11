using UnityEngine;
using UnityEngine.UI;

public class FuelSystem : MonoBehaviour
{
    public float maxFuel = 5f;
    public float currentFuel;
    public float fuelDrainRate = 1f;

    public Image fuelBarFill;
    private bool isSpraying => Input.GetMouseButton(0);

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
