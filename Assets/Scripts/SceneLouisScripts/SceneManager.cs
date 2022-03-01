using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneManager : MonoBehaviour
{
    [SerializeField] private GameObject pointSpawnPlayer;

    private void Awake()
    {
        GameManager.PlayerSpawn(pointSpawnPlayer.transform.position);
    }

    private void Update()
    {
        PlayerDeath();
    }

    private void PlayerDeath()
    {
        if (GameManager.playerLife <= GameManager.playerLifeMin)
        {
            GameManager.PlayerSpawn(pointSpawnPlayer.transform.position);
            GameManager.SetPlayerLife(GameManager.playerLifeMax);
        }
    }
}
