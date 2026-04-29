using UnityEngine;

public class AudioManager : MonoBehaviour
{
    [SerializeField] private AudioSource pickUpAudioSource;
    [SerializeField] private AudioSource shootingAudioSource;
    [SerializeField] private AudioSource backgroundMusicSource;

    public void PlayPickUpSound(AudioClip toPlaySound)
    {
        
        pickUpAudioSource.PlayOneShot(toPlaySound);
    }

    public void PlayShootingSound(AudioClip shootSound)
    {
        shootingAudioSource.PlayOneShot(shootSound);
    }

    public void MuteAllMusic()
    {

    }

}
