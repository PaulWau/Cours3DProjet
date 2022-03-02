using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLouisManager : MonoBehaviour
{
    [SerializeField] private GameObject pointSpawnPlayer;
    //private bool playerIsDead = false;

    private void Awake()
    {
        GameManager.PlayerSpawn(pointSpawnPlayer.transform.position);
    }

    private void Update()
    {
        PlayerDeath();
        //if (playerIsDead)
        {
            //playerIsDead = false;
            //UnityEngine.SceneManagement.SceneManager.LoadScene(UnityEngine.SceneManagement.SceneManager.GetActiveScene().buildIndex);

            //Scene scene = UnityEngine.SceneManagement.SceneManager.GetActiveScene();
            //UnityEngine.SceneManagement.SceneManager.LoadScene(scene.name);
        }
    }

    private void PlayerDeath()
    {
        if (GameManager.playerLife <= GameManager.playerLifeMin)
        {
            //playerIsDead = true;

            GameManager.PlayerSpawn(pointSpawnPlayer.transform.position);
            GameManager.SetPlayerLife(GameManager.playerLifeMax);
        }
    }
}
