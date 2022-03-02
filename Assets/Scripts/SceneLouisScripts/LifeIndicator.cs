using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class LifeIndicator : MonoBehaviour
{
    public TextMeshProUGUI helthText;

    public void SetMaxHealthPlayer(){
        helthText.text = GameManager.playerLifeMax.ToString();
    }
    public void SetHealth()
    {
        helthText.text = GameManager.playerLife.ToString();
    }

    private void Awake()
    {
        SetMaxHealthPlayer();
    }

    private void Update()
    {
        SetHealth();
    }
}
