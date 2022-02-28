using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    //Settings variables
    public static GameObject settingsMenu;
    public static GameObject playerInterface;
    public static int sensiValue;
    public static int sensiMax = 1000;
    public static int sensiMin = 50;
    public static int musicVolume;
    public static int soundVolume;
    public static int audioVolumMax = 100;
    public static int audioVolumMin = 0;
    
    //Player variables
    public static int playerLife = 100;
    public static int playerLifeMax = 100;
    public static int playerLifeMin = 0;
    
    public static int playerAmmo = 60;
    public static int playerAmmoMax = 60;
    public static int playerAmmoMin = 0;


    private void Start()
    {
        DontDestroyOnLoad(this);
        settingsMenu = Instantiate(Resources.Load("SettingsMenu") as GameObject);
        settingsMenu.SetActive(false);
        
        playerInterface = Instantiate(Resources.Load("PlayerInterface") as GameObject);
        playerInterface.SetActive(false);
        
        DontDestroyOnLoad(settingsMenu);
        DontDestroyOnLoad(playerInterface);
        sensiValue = 100;
        musicVolume = 100;
        soundVolume = 100;

        playerInterface.GetComponent<IndicatorReference>().LifeIndicator.text = playerLife.ToString();
        playerInterface.GetComponent<IndicatorReference>().AmmoIndicator.text = playerAmmo.ToString();
    }

    public static void ChangeWeapon()
    {
        
    }

    public static void TakeDamage(int damageTaken)
    {
        if (playerLife - damageTaken <= playerLifeMin)
        {
            playerLife = playerLifeMin;
        }
        else if (playerLife - damageTaken >= playerLifeMax)
        {
            playerLife = playerLifeMax;
        }
        else
        {
            playerLife = playerLife - damageTaken;
        }
        
        playerInterface.GetComponent<IndicatorReference>().LifeIndicator.text = playerLife.ToString();
    }

    public static void SetPlayerLife(int life)
    {
        if (life<=playerLifeMin)
        {
            playerLife = playerLifeMin;
        }
        else if (life>=playerLifeMax)
        {
            playerLife = playerLifeMax;
        }
        else
        {
            playerLife = life;
        }
        playerInterface.GetComponent<IndicatorReference>().LifeIndicator.text = playerLife.ToString();
    }
    
    public static void DecreaseAmmo(int ammoToDecrease)
    {
        if (playerAmmo - ammoToDecrease <= playerAmmoMin)
        {
            playerAmmo = playerLifeMin;
        }
        else if (playerLife - ammoToDecrease >= playerAmmoMax)
        {
            playerAmmo = playerLifeMax;
        }
        else
        {
            playerAmmo = playerAmmo - ammoToDecrease;
        }
        
        playerInterface.GetComponent<IndicatorReference>().AmmoIndicator.text = playerAmmo.ToString();
    }

    public static void SetAmmo(int ammo)
    {
        if (ammo<=playerAmmoMin)
        {
            playerAmmo = playerAmmoMin;
        }
        else if (ammo>=playerAmmoMax)
        {
            playerAmmo = playerAmmoMax;
        }
        else
        {
            playerAmmo = ammo;
        }
        playerInterface.GetComponent<IndicatorReference>().LifeIndicator.text = playerLife.ToString();
    }
    
}
