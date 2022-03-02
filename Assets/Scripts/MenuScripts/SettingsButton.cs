using UnityEngine;

public class SettingsButton : MonoBehaviour
{
    public void ResumeButton()
    {
        GameObject.Find("SettingsMenu").SetActive(false);
    }
    public void OpenButton()
    {
        GameObject.Find("SettingsMenu").SetActive(true);
    }
}
