using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class MissionScript : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI missionText;
    [SerializeField] private TextMeshProUGUI missionKill;
    private bool isNotDestroy = true;

    private void Update()
    {
        CountKill();
        DestroyMission();
    }

    private IEnumerator WaitMissionDespawn()
    {
        yield return new WaitForSeconds(5f);
        missionText.text = "";
    }

    private void CountKill()
    {
        missionKill.text = MonsterManager.nbOfKill.ToString();
    }

    private void DestroyMission()
    {
        if (isNotDestroy)
        {
            isNotDestroy = false;
            StartCoroutine(WaitMissionDespawn());
        }
    }
}