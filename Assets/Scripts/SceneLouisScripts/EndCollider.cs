using System;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndCollider : MonoBehaviour
{
    public static bool canEnd = false;
    private void OnTriggerEnter(Collider other)
    {
        MonsterManager.nbOfKill = 0;
        MonsterManager.nbOfMonster = 0;
        EndCollider.canEnd = false;
        SceneManager.LoadScene("ScenePaul");
    }

    private void Update()
    {
        if (canEnd)
        {
            transform.GetComponent<BoxCollider>().isTrigger = true;
        }
    }
}
