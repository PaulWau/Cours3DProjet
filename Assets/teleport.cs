using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class teleport : MonoBehaviour
{
    public Transform destination;
    public GameObject player;
    [SerializeField] private CharacterController controller;
    

    private void OnCollisionExit(Collision other)
    {
        controller.transform.position = destination.transform.position;
        Debug.Log(other.gameObject.name);
    }
}
