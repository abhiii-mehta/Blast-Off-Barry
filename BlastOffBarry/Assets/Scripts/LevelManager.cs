using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{
    public GameObject exitDoor;

    private int firesRemaining;

    void Start()
    {
        firesRemaining = GameObject.FindGameObjectsWithTag("Fire").Length;
        exitDoor.SetActive(false); // Hide exit until fires are gone
    }

    public void FireExtinguished()
    {
        firesRemaining--;

        if (firesRemaining <= 0)
        {
            Debug.Log("All fires out!");
            exitDoor.SetActive(true); // Unlock the exit
        }
    }
}
