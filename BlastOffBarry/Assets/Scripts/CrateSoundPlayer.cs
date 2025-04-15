using UnityEngine;

[RequireComponent(typeof(Rigidbody2D), typeof(AudioSource))]
public class CrateSoundPlayer : MonoBehaviour
{
    public float movementThreshold = 0.1f; // Minimum velocity to trigger sound
    private Rigidbody2D rb;
    private AudioSource crateAudio;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        crateAudio = GetComponent<AudioSource>();
        crateAudio.loop = true;
        crateAudio.playOnAwake = false;
    }

    void Update()
    {
        float speed = rb.linearVelocity.magnitude;

        if (speed > movementThreshold)
        {
            if (!crateAudio.isPlaying)
                crateAudio.Play();
        }
        else
        {
            if (crateAudio.isPlaying)
                crateAudio.Stop();
        }
    }
}
