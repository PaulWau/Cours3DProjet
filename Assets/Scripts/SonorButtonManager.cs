using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class MusicButtonManager : MonoBehaviour
{
    private GameObject gameManager;
    private GameManager gameManagerClass;
    [SerializeField] private TMP_InputField _affichageText;

    private void Start()
    {
        gameManager = GameObject.Find("GameManager");
        gameManagerClass = gameManager.GetComponent<GameManager>();
        _affichageText.text = gameManagerClass.sensiValue.ToString();
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
        gameManagerClass.sensiValue = inputValue;
    }
}
