using UnityEngine;

public class PlayerThrust : MonoBehaviour
{
    public float thrustForce = 5f;
    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            Vector2 direction = (mousePos - transform.position).normalized;
            rb.AddForce(-direction * thrustForce);
        }
    }
}
