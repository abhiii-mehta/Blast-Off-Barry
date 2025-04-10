using UnityEngine;

public class ExtinguisherController : MonoBehaviour
{
    public float offsetDistance = 0.4f; // how far in front of the player it sticks out

    void Update()
    {
        if (Camera.main == null) return;

        // Get mouse and player positions
        Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        Vector3 playerPos = transform.parent.position;

        // Direction from player to mouse
        Vector3 direction = (mousePos - playerPos).normalized;

        // Move extinguisher to front of player, toward mouse
        Vector3 offset = direction * offsetDistance;
        transform.localPosition = offset;

        // Rotate extinguisher to face mouse
        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(0f, 0f, angle);
    }
}
