using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManageGame : MonoBehaviour
{
    [SerializeField] private GameObject Chemin;
    [SerializeField] private GameObject Holes;

    [SerializeField] private PlayerController Move;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(StartLevel2());
        

    }

    // Update is called once per frame
    void Update()
    {
        
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
