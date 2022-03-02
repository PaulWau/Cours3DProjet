using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class MissionScriptPaul : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI missionText;
    
    private bool isNotDestroy = true;

    private void Update()
    {
        DestroyMission();
    }

    private IEnumerator WaitMissionDespawn()
    {
        yield return new WaitForSeconds(10f);
        missionText.text = "";
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
