using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterKill : MonoBehaviour
{
    private LayerMask bulletLayer;
    private int hpMonster = 100 ;
    private void Awake()
    {
        bulletLayer = LayerMask.NameToLayer("bullet");
    }
    private void OnCollisionEnter(Collision collision)
    {
        
        if (collision.gameObject.layer == bulletLayer)
        {
            hpMonster -= 50;
            if (hpMonster <= 0)
            {
                Destroy(transform.gameObject);
            }
            Debug.Log(hpMonster);
        }
    }
}
