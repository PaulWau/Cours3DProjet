using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class InputFieldManager : MonoBehaviour
{
    private GameObject gameManager;
    private GameManager gameManagerClass;
    [SerializeField] private TMP_InputField _affichageText;

    private void Start()
    {
        gameManager = GameObject.Find("GameManager");
        gameManagerClass = gameManager.GetComponent<GameManager>();
        _affichageText.text = gameManagerClass.sensiValue.ToString(); //Car tous les input field commencent à 100
    }

    public void SensiInput(dynamic input)
    {
        int inputValue = int.Parse(input);
        if (inputValue<gameManagerClass.sensiMin)
        {
            _affichageText.text = gameManagerClass.sensiMin.ToString();
            inputValue = gameManagerClass.sensiMin;

        }
        if (inputValue>gameManagerClass.sensiMax)
        {
            _affichageText.text = gameManagerClass.sensiMax.ToString();
            inputValue = gameManagerClass.sensiMax;
        }
        gameManagerClass.sensiValue = inputValue;
    }
    
    public void SoundInput(dynamic input)
    {
        int inputValue = int.Parse(input);
        if (inputValue<gameManagerClass.audioVolumMin)
        {
            _affichageText.text = gameManagerClass.audioVolumMin.ToString();
            inputValue = 0;

        }
        if (inputValue>gameManagerClass.audioVolumMax)
        {
            _affichageText.text = gameManagerClass.audioVolumMax.ToString();
            inputValue = gameManagerClass.audioVolumMax;
        }
        gameManagerClass.soundVolume = inputValue;
    }
    
    public void MusicInput(dynamic input)
    {
        int inputValue = int.Parse(input);
        if (inputValue<gameManagerClass.audioVolumMin)
        {
            _affichageText.text = gameManagerClass.audioVolumMin.ToString();
            inputValue = gameManagerClass.audioVolumMin;

        }
        if (inputValue>gameManagerClass.audioVolumMax)
        {
            _affichageText.text = gameManagerClass.audioVolumMax.ToString();
            inputValue = gameManagerClass.audioVolumMax;
        }
        gameManagerClass.musicVolume = inputValue;
    }
}
