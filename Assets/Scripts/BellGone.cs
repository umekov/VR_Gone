using UnityEngine;

public class BellGone : MonoBehaviour
{

    public AudioSource bell_gone_sound;
    public AudioClip bell_sound;
    private int bell_count;
    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Stick")
        {
            PlaySound();
        }
    }

    public void PlaySound()
    {
        bell_gone_sound.Play();
        bell_count += 1;
    }
}
