using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class ExtinguisherSoundPlayer : MonoBehaviour
{
    private AudioSource extinguisherAudio;

    void Start()
    {
        extinguisherAudio = GetComponent<AudioSource>();
        extinguisherAudio.loop = true;
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0)) 
        {
            if (!extinguisherAudio.isPlaying)
                extinguisherAudio.Play();
        }
        else if (Input.GetMouseButtonUp(0)) 
        {
            extinguisherAudio.Stop();
        }
    }
}
