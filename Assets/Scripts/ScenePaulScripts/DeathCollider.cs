using UnityEngine;

public class DeathCollider : MonoBehaviour
{
    [SerializeField] private AudioSource deathsound;
    private void OnTriggerEnter(Collider other)
    {
        if (GameManager.player == other.gameObject)
        {
            ScenePaulFonctionnement.RespawnPlayer();
            deathsound.Play();
        }
    }
}
