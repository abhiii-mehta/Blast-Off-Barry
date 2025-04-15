using UnityEngine;
using TMPro;

public class TimedMessage : MonoBehaviour
{
    public float displayTime = 5f;
    private TextMeshProUGUI messageText;

    void Start()
    {
        messageText = GetComponent<TextMeshProUGUI>();
        messageText.enabled = true;
        Invoke("HideMessage", displayTime);
    }

    void HideMessage()
    {
        messageText.enabled = false;
    }
}
