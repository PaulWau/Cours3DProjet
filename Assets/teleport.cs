using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class teleport : MonoBehaviour
{
    public Transform destination;
    public GameObject player;
    public GameObject cam;
    public GameObject lautre;
    
    private void OnTriggerEnter(Collider other)
    {
        player.transform.position = destination.transform.position;
        cam.transform.position = player.transform.position;
        cam.transform.position = new Vector3(0, 1f, 0);
        lautre.transform.position = player.transform.position;
        lautre.transform.position = new Vector3(0, -1.5f, 0);
        Debug.Log(player.gameObject.name);
    }
}
