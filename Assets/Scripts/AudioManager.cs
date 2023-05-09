using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    [SerializeField] AudioSource musicSource;
    [SerializeField] AudioSource SFXSource;

    public AudioClip[] background;
    public AudioClip death;
    public AudioClip touch;
    private int i;

    public static AudioManager instance;

    private void Awake()
    {
        if(instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
        
    }
    public void Start() 
    {
        StartCoroutine(playAudioSequentially());
    }
    private void RepeatAudio()
    {
        StartCoroutine(playAudioSequentially());
    }

IEnumerator playAudioSequentially()
{
    yield return null;
    for (int i = 0; i < background.Length; i++)
    {
        int n = background.Length-1;
        if(i == n)
        {
           Invoke("RepeatAudio",musicSource.clip.length);
        }
        musicSource.clip = background[i];
        musicSource.Play();

        while (musicSource.isPlaying)
        {
            yield return null;
        }
    }
}
    public void PlaySFX(AudioClip clip){
        SFXSource.PlayOneShot(clip);
    }
}
