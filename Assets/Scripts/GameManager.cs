using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public int sensiValue;
    public int sensiMax = 1000;
    public int sensiMin = 50;
    public int musicVolume;
    public int soundVolume;
    public int audioVolumMax = 100;
    public int audioVolumMin = 0;
    public GameObject settingsMenu;

    private void Start()
    {
        DontDestroyOnLoad(this);
        settingsMenu = Instantiate(settingsMenu);
        settingsMenu.SetActive(false);
        DontDestroyOnLoad(settingsMenu);
        sensiValue = 100;
        musicVolume = 100;
        soundVolume = 100;
    }
}
