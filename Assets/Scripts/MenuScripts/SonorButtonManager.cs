using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class MusicButtonManager : MonoBehaviour
{
    [SerializeField] private TMP_InputField _affichageText;

    private void Start()
    {
        _affichageText.text = GameManager.sensiValue.ToString();
    }

    public void SoundInput(dynamic input)
    {
        int inputValue = int.Parse(input);
        if (inputValue<0)
        {
            _affichageText.text = "0";
            inputValue = 0;

        }
        if (inputValue>1000)
        {
            _affichageText.text = "1000";
            inputValue = 1000;
        }
        GameManager.sensiValue = inputValue;
    }
}
