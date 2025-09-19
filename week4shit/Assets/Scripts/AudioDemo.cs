using NUnit.Framework;
using UnityEngine;
using System.Collections.Generic;

public class AudioDemo : MonoBehaviour
{
    public AudioSource Susie;
    public AudioSource funnySounds;
    public List<AudioClip> soundEffects;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void PlayTheMusic()
    {
        //Susie.Play();
        funnySounds.clip = soundEffects[Random.Range(0,soundEffects.Count)];
        funnySounds.Play();
    }

}
