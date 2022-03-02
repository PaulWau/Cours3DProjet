using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndScenePaul : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        Cursor.lockState = CursorLockMode.Confined;
        SceneManager.LoadScene("PlayingEnd");
    }
}
