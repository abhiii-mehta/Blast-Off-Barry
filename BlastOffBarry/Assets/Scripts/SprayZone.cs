using UnityEngine;

public class SprayZone : MonoBehaviour
{
    private void OnTriggerStay2D(Collider2D other)
    {
        if (Input.GetMouseButton(0) && other.CompareTag("Fire"))
        {
            Destroy(other.gameObject);
        }
    }
}
