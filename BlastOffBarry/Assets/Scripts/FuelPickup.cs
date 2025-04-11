using UnityEngine;

public class FuelPickup : MonoBehaviour
{
    public float fuelAmount = 2f;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            FuelSystem fuelSystem = other.GetComponent<FuelSystem>();
            if (fuelSystem != null)
            {
                fuelSystem.AddFuel(fuelAmount);
            }

            Destroy(gameObject);
        }
    }
}
