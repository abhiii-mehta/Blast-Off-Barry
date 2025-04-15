using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class ExtinguisherSoundPlayer : MonoBehaviour
{
    private AudioSource extinguisherAudio;

    void Start()
    {
        extinguisherAudio = GetComponent<AudioSource>();
        extinguisherAudio.loop = true; // Keep looping while LMB is held
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0)) // LMB Pressed
        {
            if (!extinguisherAudio.isPlaying)
                extinguisherAudio.Play();
        }
        else if (Input.GetMouseButtonUp(0)) // LMB Released
        {
            extinguisherAudio.Stop();
        }
    }
}
