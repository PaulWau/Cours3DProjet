using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using TMPro;
using UnityEngine;

public class ButtonManager : MonoBehaviour
{
    private GameObject gameManager;
    private GameManager gameManagerClass;
    [CanBeNull] [SerializeField] private TMP_InputField _inputFieldToUpdate;
    
    private void Start()
    {
        gameManager = GameObject.Find("GameManager");
        gameManagerClass = gameManager.GetComponent<GameManager>();
    }

    public void ButtonSensiPlus()
    {
        if (gameManagerClass.sensiValue+50>gameManagerClass.sensiMax)
        {
            _inputFieldToUpdate.text = gameManagerClass.sensiMax.ToString();
            gameManagerClass.sensiValue = gameManagerClass.sensiMax;
        }
        else
        {
            gameManagerClass.sensiValue += 50;
            _inputFieldToUpdate.text = gameManagerClass.sensiValue.ToString();
        }
    }

    public void ButtonSensiMinus()
    {
        if (gameManagerClass.sensiValue-50<gameManagerClass.sensiMin)
        {
            _inputFieldToUpdate.text = gameManagerClass.sensiMin.ToString();
            gameManagerClass.sensiValue = gameManagerClass.sensiMin;
        }
        else
        {
            gameManagerClass.sensiValue -= 50;
            _inputFieldToUpdate.text = gameManagerClass.sensiValue.ToString();
        }
    }
    
    public void ButtonSoundPlus()
    {
        if (gameManagerClass.soundVolume+5>gameManagerClass.audioVolumMax)
        {
            _inputFieldToUpdate.text = gameManagerClass.audioVolumMax.ToString();
            gameManagerClass.soundVolume = gameManagerClass.audioVolumMax;
        }
        else
        {
            gameManagerClass.soundVolume += 5;
            _inputFieldToUpdate.text = gameManagerClass.soundVolume.ToString();
        }
    }

    public void ButtonSoundMinus()
    {
        if (gameManagerClass.soundVolume-5<gameManagerClass.audioVolumMin)
        {
            _inputFieldToUpdate.text = gameManagerClass.audioVolumMin.ToString();
            gameManagerClass.soundVolume = gameManagerClass.audioVolumMin;
        }
        else
        {
            gameManagerClass.soundVolume -= 5;
            _inputFieldToUpdate.text = gameManagerClass.soundVolume.ToString();
        }
    }
    
    public void ButtonMusicPlus()
    {
        if (gameManagerClass.musicVolume+5>gameManagerClass.audioVolumMax)
        {
            _inputFieldToUpdate.text = gameManagerClass.audioVolumMax.ToString();
            gameManagerClass.musicVolume = gameManagerClass.audioVolumMax;
        }
        else
        {
            gameManagerClass.musicVolume += 5;
            _inputFieldToUpdate.text = gameManagerClass.musicVolume.ToString();
        }
    }

    public void ButtonMusicMinus()
    {
        if (gameManagerClass.musicVolume-5<gameManagerClass.audioVolumMin)
        {
            _inputFieldToUpdate.text = gameManagerClass.audioVolumMin.ToString();
            gameManagerClass.musicVolume = gameManagerClass.audioVolumMin;
        }
        else
        {
            gameManagerClass.musicVolume -= 5;
            _inputFieldToUpdate.text = gameManagerClass.musicVolume.ToString();
        }
    }
    
    public void ResumeButton()
    {
        gameManagerClass.settingsMenu.SetActive(false);
    }
    public void OpenButton()
    {
        gameManagerClass.settingsMenu.SetActive(true);
    }


}
