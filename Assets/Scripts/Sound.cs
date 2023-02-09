using UnityEngine;
using UnityEngine.Audio;

[System.Serializable]
public class Sound
{
    [HideInInspector]
    public AudioSource source;
    public AudioClip clip;

    public string name;
    
    [Range(0f, 1f)]
    public float volume;

    [Range(0.1f, 1f)]
    public float pitch;

    public bool loop;
}
