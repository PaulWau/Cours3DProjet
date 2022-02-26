using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    //Settings variables
    public static GameObject settingsMenu;
    public static int sensiValue;
    public static int sensiMax = 1000;
    public static int sensiMin = 50;
    public static int musicVolume;
    public static int soundVolume;
    public static int audioVolumMax = 100;
    public static int audioVolumMin = 0;
    
    //Player variables
    public static int playerLife;
    public static int playerAmmo;


    private void Start()
    {
        DontDestroyOnLoad(this);
        settingsMenu = Instantiate(Resources.Load("SettingsMenu") as GameObject);
        settingsMenu.SetActive(false);
        DontDestroyOnLoad(settingsMenu);
        sensiValue = 100;
        musicVolume = 100;
        soundVolume = 100;
    }
}
