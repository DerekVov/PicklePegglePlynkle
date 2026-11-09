using UnityEngine;

public class Ball : MonoBehaviour
{
    public AudioClip PegHitClip;
    private AudioSource audioSource;

    private static bool isBallInPlay;
    public void Awake()
    {
        audioSource = GetComponent<AudioSource>();
        isBallInPlay = true;
    }

    public void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "Peg")
        {
            audioSource.PlayOneShot(PegHitClip);
            audioSource.pitch = audioSource.pitch + 0.1f;
        }
    }

    public static bool IsBallInPlay()
    {
        return isBallInPlay;
    }
    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("SlotTrigger"))
        {
            Destroy(gameObject);
        }
    }

    public void OnDestroy()
    {
        isBallInPlay = false;
    }
}
