using System.Collections;
using UnityEngine;

public class ScenePaulFonctionnement : MonoBehaviour
{
    [SerializeField] private GameObject Chemin;
    [SerializeField] private GameObject Holes;
    private static Vector3 positioninit;
    // Start is called before the first frame update
    void Awake()
    {
        positioninit = GameObject.Find("Point Spawn Player").transform.position;
        StartCoroutine(StartLevel2());
    }
    

    private IEnumerator StartLevel2()
    {
        RespawnPlayer();
        Holes.SetActive(false);
        GameManager.player.GetComponent<PlayerMovement>().enabled = false;
        
        yield return new WaitForSeconds(5f);
        Holes.SetActive(true);
        GameManager.player.GetComponent<PlayerMovement>().enabled = true;
        
    }

    public static void RespawnPlayer()
    {
        //La scène n'étant pas à l'échelle 1, il faut actualiser à la main toute les valeurs du player
        GameManager.PlayerSpawn(positioninit);
        
        GameManager.player.transform.localScale = GameManager.player.transform.localScale*3;
        PlayerMovement playerMovementScript = GameManager.player.GetComponent<PlayerMovement>();
        playerMovementScript.speed = playerMovementScript.speed * 1.5f;
        playerMovementScript.gravity = playerMovementScript.gravity * 2;
        playerMovementScript.jumpHeight = playerMovementScript.jumpHeight * 2;
    }
}