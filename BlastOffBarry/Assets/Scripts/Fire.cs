using UnityEngine;

public class Fire : MonoBehaviour
{
    private void OnDestroy()
    {
        // Notify the LevelManager when this fire is destroyed
        LevelManager levelManager = FindObjectOfType<LevelManager>();
        if (levelManager != null)
        {
            levelManager.FireExtinguished();
        }
    }
}
