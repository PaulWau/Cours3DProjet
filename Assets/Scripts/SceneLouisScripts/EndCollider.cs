using System;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndCollider : MonoBehaviour
{
    public static bool canEnd = false;
    private void OnTriggerEnter(Collider other)
    {
        
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
