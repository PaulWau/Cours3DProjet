using UnityEngine;

public class SceneLouisManager : MonoBehaviour
{
    [SerializeField] private GameObject pointSpawnPlayer;
    [SerializeField] private AudioSource sounddeath;
    //private bool playerIsDead = false;

    private void Awake()
    {
        GameManager.PlayerSpawn(pointSpawnPlayer.transform.position);
    }

    private void Update()
    {
        PlayerDeath();
        GameManager.timeScene1 = Time.timeSinceLevelLoad;
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
            sounddeath.Play();
            GameManager.PlayerSpawn(pointSpawnPlayer.transform.position);
            GameManager.SetPlayerLife(GameManager.playerLifeMax);
        }
    }
}
