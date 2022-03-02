using TMPro;
using UnityEngine;

public class LifeIndicator : MonoBehaviour
{
    public TextMeshProUGUI helthText;

    public void SetMaxHealthPlayer(){
        helthText.text = GameManager.playerLifeMax.ToString();
    }
    public void SetHealth()
    {
        helthText.text = GameManager.playerLife.ToString();
    }

    private void Awake()
    {
        SetMaxHealthPlayer();
    }

    private void Update()
    {
        SetHealth();
    }
}
