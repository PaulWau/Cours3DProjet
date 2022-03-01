using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class HealthBar : MonoBehaviour
{
    public Slider slider;
    [SerializeField] private MonsterType monsterStats;
    [SerializeField] private MonsterKill monsterHealth;

    public void SetMaxHealth()
    {
        slider.maxValue = monsterStats.hpMonsterMax;
        slider.value = monsterHealth.hpMonster;
    }

    public void SetHealth()
    {
        slider.value = monsterHealth.hpMonster;
    }

    private void Awake()
    {
        SetMaxHealth();
    }

    private void Update()
    {
        SetHealth();
    }
}
