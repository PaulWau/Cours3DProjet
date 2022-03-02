using TMPro;
using UnityEngine;

public class InputFieldManager : MonoBehaviour
{
    [SerializeField] private TMP_InputField _affichageText;

    private void Start()
    {
        _affichageText.text = GameManager.sensiValue.ToString(); //Car tous les input field commencent à 100
    }

    public void SensiInput(dynamic input)
    {
        int inputValue = int.Parse(input);
        if (inputValue<GameManager.sensiMin)
        {
            _affichageText.text = GameManager.sensiMin.ToString();
            inputValue = GameManager.sensiMin;

        }
        if (inputValue>GameManager.sensiMax)
        {
            _affichageText.text = GameManager.sensiMax.ToString();
            inputValue = GameManager.sensiMax;
        }
        GameManager.sensiValue = inputValue;
        Debug.Log(GameManager.sensiValue);
    }
    
    public void SoundInput(dynamic input)
    {
        int inputValue = int.Parse(input);
        if (inputValue<GameManager.audioVolumMin)
        {
            _affichageText.text = GameManager.audioVolumMin.ToString();
            inputValue = 0;

        }
        if (inputValue>GameManager.audioVolumMax)
        {
            _affichageText.text = GameManager.audioVolumMax.ToString();
            inputValue = GameManager.audioVolumMax;
        }
        GameManager.soundVolume = inputValue;
    }
    
    public void MusicInput(dynamic input)
    {
        int inputValue = int.Parse(input);
        if (inputValue<GameManager.audioVolumMin)
        {
            _affichageText.text = GameManager.audioVolumMin.ToString();
            inputValue = GameManager.audioVolumMin;

        }
        if (inputValue>GameManager.audioVolumMax)
        {
            _affichageText.text = GameManager.audioVolumMax.ToString();
            inputValue = GameManager.audioVolumMax;
        }
        GameManager.musicVolume = inputValue;
    }
}
