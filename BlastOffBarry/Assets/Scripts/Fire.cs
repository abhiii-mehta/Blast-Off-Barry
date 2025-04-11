using UnityEngine;

public class Fire : MonoBehaviour
{
    private void OnDestroy()
    {
        LevelManager levelManager = Object.FindFirstObjectByType<LevelManager>();
        if (levelManager != null)
        {
            levelManager.FireExtinguished();
        }
    }
}
