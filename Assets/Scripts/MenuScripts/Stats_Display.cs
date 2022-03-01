using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class Stats_Display : MonoBehaviour
{
    [SerializeField] private AudioSource audioendgame;
    [SerializeField] private TextMeshProUGUI textlife;
    [SerializeField] private TextMeshProUGUI texttimeLevel1;
    [SerializeField] private TextMeshProUGUI texttimeLevel2;
    // Start is called before the first frame update

    // Update is called once per frame
    void Update()
    {
        textlife.text = " Restantes : " + GameManager.playerLife;
        Debug.Log(Time.realtimeSinceStartup);
        int timer=(int)Time.realtimeSinceStartup;
        texttimeLevel1.text="Temps passé sur le niveau 1: "+timer/60+" minutes, "+timer%60+" secondes";
        texttimeLevel2.text="Temps passé sur le niveau 2: "+timer/60+" minutes, "+timer%60+" secondes";
        //texttimeLevel1.text = Time.realtimeSinceStartup;
    }



}
