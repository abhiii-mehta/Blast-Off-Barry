using UnityEngine;

public class ExtinguisherController : MonoBehaviour
{
    public Transform extinguisher;
    public SpriteRenderer barryRenderer;
    public float horizontalOffset = 0.5f;
    public Vector3 extinguisherSize = new Vector3(1f, 1f, 1f);

    void Update()
    {
        Vector3 mouseWorld = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        Vector2 dir = (mouseWorld - transform.position).normalized;

        // Flip Barry and rotate extinguisher accordingly
        if (dir.x < 0)
        {
            barryRenderer.flipX = true;
            extinguisher.localScale = new Vector3(-extinguisherSize.x, extinguisherSize.y, extinguisherSize.z);

            // Flip arc direction on left side
            float angle = Mathf.Atan2(dir.y, -dir.x) * Mathf.Rad2Deg;
            extinguisher.rotation = Quaternion.Euler(0f, 0f, angle);
        }
        else
        {
            barryRenderer.flipX = false;
            extinguisher.localScale = extinguisherSize;

            float angle = Mathf.Atan2(dir.y, dir.x) * Mathf.Rad2Deg;
            extinguisher.rotation = Quaternion.Euler(0f, 0f, angle);
        }

        // Keep extinguisher at horizontal offset, allow some vertical if needed
        float xOffset = Mathf.Sign(dir.x) * horizontalOffset;
        extinguisher.localPosition = new Vector3(xOffset, 0f, 0f);
    }
}
