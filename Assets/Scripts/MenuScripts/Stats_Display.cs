using UnityEngine;
using TMPro;

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
        texttimeLevel1.text="Temps passe sur le niveau 1: "+(int)GameManager.timeScene1/60+" minutes, "+(int)GameManager.timeScene1%60+" secondes";
        texttimeLevel2.text="Temps passe sur le niveau 2: "+(int)GameManager.timeScene2/60+" minutes, "+(int)GameManager.timeScene2%60+" secondes";
        //texttimeLevel1.text = Time.realtimeSinceStartup;
    }



}
