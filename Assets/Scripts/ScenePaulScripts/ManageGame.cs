using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManageGame : MonoBehaviour
{
    [SerializeField] private GameObject Chemin;
    [SerializeField] private GameObject Holes;
    [SerializeField] private PlayerController Move;
    [SerializeField] private GameObject player;

    private Vector3 positioninit;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(StartLevel2());
        positioninit= Move.transform.position;
        Debug.Log(positioninit);

    }

    
        
    // Update is called once per frame
    void Update()
    {
        if (Move.transform.position.y <= 40)
        {
            Debug.Log("Mort du joueur");
            player.transform.position=positioninit;

        }
    }

    private IEnumerator StartLevel2()
    {
        Holes.SetActive(false);
        
        yield return new WaitForSeconds(5f);
        Holes.SetActive(true);
        Move.setisinmove();
        Move.setgravity(true);
    }
}
