using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootScript : MonoBehaviour
{
    [SerializeField] Rigidbody projectile;
    [SerializeField] float speed = 100;
    //[SerializeField] private Transform bulletHolder;
    
    void Update()
    {
        if (GameManager.playerAmmo > 0)
        {
            if (Input.GetButtonDown("Fire1"))
            {
                Rigidbody p = Instantiate(projectile, transform.position + transform.right * 0.8f, Quaternion.identity);
                //p.transform.SetParent(bulletHolder);
                p.velocity = transform.right * speed;
                //Debug.Log("bang");
                GameManager.playerAmmo -= 1;
            }
        }
            
    }
}
