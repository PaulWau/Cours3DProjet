using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class AmmoIndicator : MonoBehaviour
{
    public TextMeshProUGUI ammoText;

    public void SetMaxAmmoPlayer(){
        ammoText.text = GameManager.playerAmmoMax.ToString();
    }
    public void SetAmmo()
    {
        ammoText.text = GameManager.playerAmmo.ToString();
    }

    private void Awake()
    {
        SetMaxAmmoPlayer();
    }

    private void Update()
    {
        SetAmmo();
        ReloadAmmo();
    }
    private void ReloadAmmo()
    {
        if (Input.GetButton("Reload"))
        {
            GameManager.playerAmmo = GameManager.playerAmmoMax;
        }
    }
}
