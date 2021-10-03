using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationSound : MonoBehaviour
{
    private AudioSource audioSource;

    private void Start()
    {
        audioSource = GetComponent<AudioSource>();   
    }
    public void playSound(AudioClip sound)
    {
        audioSource.PlayOneShot(sound);
    }
}
