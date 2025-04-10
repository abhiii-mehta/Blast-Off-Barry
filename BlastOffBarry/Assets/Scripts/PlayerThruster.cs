using UnityEngine;

public class PlayerThrust : MonoBehaviour
{
    public float thrustForce = 15f;
    public float drag = 1.5f;
    public float gravityScale = 0.3f;
    public ParticleSystem sprayParticles; // assign in Inspector

    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.linearDamping = drag;
        rb.gravityScale = gravityScale;
    }

    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            Vector2 direction = (mousePos - transform.position).normalized;
            rb.AddForce(-direction * thrustForce);

            if (!sprayParticles.isPlaying)
                sprayParticles.Play();
        }
        else
        {
            if (sprayParticles.isPlaying)
                sprayParticles.Stop();
        }

    }
}
