using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterSpawn : MonoBehaviour
{
    [SerializeField] private GameObject monster;
    void Start()
    {
        Instantiate(monster, transform.position + transform.right * 0.8f, Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
