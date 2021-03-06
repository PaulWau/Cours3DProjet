using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicVolumeManager : MonoBehaviour
{
    private AudioSource _selfAudioSource;
    private void Awake()
    {
        _selfAudioSource = GetComponent<AudioSource>();
    }

    void Update()
    {
        _selfAudioSource.volume = GameManager.musicVolume/100f;
    }
}
