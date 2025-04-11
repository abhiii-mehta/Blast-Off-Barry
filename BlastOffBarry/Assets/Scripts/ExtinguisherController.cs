using UnityEngine;

public class ExtinguisherController : MonoBehaviour
{
    public float offsetDistance = 0.4f;

    void Update()
    {
        if (Camera.main == null) return;

        Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        Vector3 playerPos = transform.parent.position;

        Vector3 direction = (mousePos - playerPos).normalized;

        Vector3 offset = direction * offsetDistance;
        transform.localPosition = offset;

        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(0f, 0f, angle);
    }
}
