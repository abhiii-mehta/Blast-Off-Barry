using UnityEngine;

public class Fire : MonoBehaviour
{
    public float extinguishTime = 1f;
    private float sprayTimer = 0f;
    private bool beingSprayed = false;

    void Update()
    {
        if (beingSprayed)
        {
            sprayTimer += Time.deltaTime;

            if (sprayTimer >= extinguishTime)
            {
                Extinguish();
            }
        }
        else
        {
            sprayTimer = 0f; // reset if spray stops
        }

        beingSprayed = false; // reset for next frame
    }

    public void SprayHit()
    {
        beingSprayed = true;
    }

    private void Extinguish()
    {
        // You could play an animation or sound here
        Destroy(gameObject);
    }
}
