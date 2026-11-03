using UnityEngine;

public class Sounds : MonoBehaviour
{
    private AudioSource audioSource;
    public AudioClip cannonClip;
    public AudioClip PegDestroyClip;
    public AudioClip PegHitClip;
    public AudioClip FireworksClip;
    public void Awake()
    {
        audioSource = GetComponent<AudioSource>();
    }
    // Play cannon
    public void PlayCannonSound()
    {
        audioSource.PlayOneShot(cannonClip);
    }
    // play hit
    public void PlayPegHitSound()
    {
        audioSource.PlayOneShot(PegHitClip);
    }
    // play destroyed
    public void PlayPegDestroySound()
    {
        audioSource.PlayOneShot(PegDestroyClip);
    }
    // play fireworks
    public void PlayFireworksSound()
    {
        audioSource.PlayOneShot(FireworksClip);
    }
}
