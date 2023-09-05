using UnityEngine.Audio;
using System;
using UnityEngine;

public class AuidoManager : MonoBehaviour
{
    public Sound[] sounds;
    public GameObject Off;
    public GameObject On;
    void Awake()
    {
        foreach(Sound s in sounds)
        {
            s.source = gameObject.AddComponent<AudioSource>();
            s.source.clip = s.clip;
            s.source.volume = s.volume;
            s.source.pitch = s.pitch;
            s.source.loop = s.loop;
        }
        
    }

    // Update is called once per frame
    void Start()
    {
        Play("GameSound");
    }
    public void Play(string name)
    {
        Sound s = Array.Find(sounds, Sound => Sound.name == name);
        if (s == null)
        {
            return;
        }
        s.source.volume = 0.05f;
        s.source.Play();
    }
    public void Stop(string name)
    {
        Sound s = Array.Find(sounds, Audio => Audio.name == name);
        s.source.volume = 0;
        s.source.Stop();

    }

    public void MusicOff()
    {
        Stop("GameSound");
        Off.SetActive(false);
        On.SetActive(true);

    }
    public void MusicOn()
    {

        Play("GameSound");
        On.SetActive(false);
        Off.SetActive(true);
    }
}
