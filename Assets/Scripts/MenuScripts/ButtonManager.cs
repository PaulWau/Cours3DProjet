using JetBrains.Annotations;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

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
        if (GameManager.inGame)
        {
            Cursor.lockState = CursorLockMode.Locked;
        }
    }
    public void OpenButton()
    {
        GameManager.settingsMenu.SetActive(true);
    }

    public void PlayButton()
    {
        SceneManager.LoadScene("SceneLouis");
        GameManager.playerInterface.SetActive(true);
    }

    public void ExitGame()
    {
        Application.Quit();
    }

    public void dropMenu(int renderDistance)
    {
        //0 pour low
        //1 pour medium
        //2 pour high
        GameManager.playerRenderDistance = renderDistance;
    }

    public void RestartButton()
    {
        GameManager.playerInterface.SetActive(false);
        SceneManager.LoadScene("PlayingMenuAfterRestart");
        GameManager.resetStaticVariable();
    }

}
