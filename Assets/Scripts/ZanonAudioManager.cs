using UnityEngine;

public class ZanonAudioManager : MonoBehaviour
{
    [SerializeField] private AudioSource backgroundMusicSource;
    [SerializeField] private AudioClip backgroundMusic;
    [SerializeField] private AudioSource uiSource;
    [SerializeField] private AudioClip clipEffect;

    void Start()
    {
        // assegno la canzone alla sorgente
        backgroundMusicSource.clip = backgroundMusic;
        // riparte quando finisce
        backgroundMusicSource.loop = true;
        // per iniziare dall'inizio
        backgroundMusicSource.time = 0;
        backgroundMusicSource.Play();
    }

    public void PlayClick()
    {
        uiSource.PlayOneShot(clipEffect);
    }
}
