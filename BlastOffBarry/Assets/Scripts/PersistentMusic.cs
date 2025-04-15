using UnityEngine;

public class PersistentMusic : MonoBehaviour
{
    public static PersistentMusic instance;

    private void Awake()
    {
        if (instance != null && instance != this)
        {
            Destroy(gameObject);
        }
        else
        {
            instance = this;
            DontDestroyOnLoad(gameObject); 
        }
    }
}
