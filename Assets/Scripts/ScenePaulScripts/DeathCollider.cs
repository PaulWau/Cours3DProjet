using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathCollider : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (GameManager.player == other.gameObject)
        {
            ScenePaulFonctionnement.RespawnPlayer();
        }
    }
}
