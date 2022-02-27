using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class teleport : MonoBehaviour
{
    public Transform destination;
    public GameObject pointdetp;
    private void OnTriggerEnter(Collider other)
    {
        if (other.name == pointdetp.name)
        {
            
            Debug.Log(this.transform.position);
            this.transform.position = destination.transform.position;
            Debug.Log(this.transform.position);
        }
    }
}
