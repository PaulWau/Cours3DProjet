using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using TMPro;
using UnityEngine;

public class ButtonManager : MonoBehaviour
{
    [CanBeNull] [SerializeField] private TMP_InputField _inputFieldToUpdate;

    public void ButtonSensiPlus()
    {
        if (GameManager.sensiValue+50>GameManager.sensiMax)
        {
            _inputFieldToUpdate.text = GameManager.sensiMax.ToString();
            GameManager.sensiValue = GameManager.sensiMax;
        }
        else
        {
            GameManager.sensiValue += 50;
            _inputFieldToUpdate.text = GameManager.sensiValue.ToString();
        }
    }

    public void ButtonSensiMinus()
    {
        if (GameManager.sensiValue-50<GameManager.sensiMin)
        {
            _inputFieldToUpdate.text = GameManager.sensiMin.ToString();
            GameManager.sensiValue = GameManager.sensiMin;
        }
        else
        {
            GameManager.sensiValue -= 50;
            _inputFieldToUpdate.text = GameManager.sensiValue.ToString();
        }
    }
    
    public void ButtonSoundPlus()
    {
        if (GameManager.soundVolume+5>GameManager.audioVolumMax)
        {
            _inputFieldToUpdate.text = GameManager.audioVolumMax.ToString();
            GameManager.soundVolume = GameManager.audioVolumMax;
        }
        else
        {
            GameManager.soundVolume += 5;
            _inputFieldToUpdate.text = GameManager.soundVolume.ToString();
        }
    }

    public void ButtonSoundMinus()
    {
        if (GameManager.soundVolume-5<GameManager.audioVolumMin)
        {
            _inputFieldToUpdate.text = GameManager.audioVolumMin.ToString();
            GameManager.soundVolume = GameManager.audioVolumMin;
        }
        else
        {
            GameManager.soundVolume -= 5;
            _inputFieldToUpdate.text = GameManager.soundVolume.ToString();
        }
    }
    
    public void ButtonMusicPlus()
    {
        if (GameManager.musicVolume+5>GameManager.audioVolumMax)
        {
            _inputFieldToUpdate.text = GameManager.audioVolumMax.ToString();
            GameManager.musicVolume = GameManager.audioVolumMax;
        }
        else
        {
            GameManager.musicVolume += 5;
            _inputFieldToUpdate.text = GameManager.musicVolume.ToString();
        }
    }

    public void ButtonMusicMinus()
    {
        if (GameManager.musicVolume-5<GameManager.audioVolumMin)
        {
            _inputFieldToUpdate.text = GameManager.audioVolumMin.ToString();
            GameManager.musicVolume = GameManager.audioVolumMin;
        }
        else
        {
            GameManager.musicVolume -= 5;
            _inputFieldToUpdate.text = GameManager.musicVolume.ToString();
        }
    }
    
    public void ResumeButton()
    {
        GameManager.settingsMenu.SetActive(false);
    }
    public void OpenButton()
    {
        GameManager.settingsMenu.SetActive(true);
    }


}
