using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootScript : MonoBehaviour
{
    [SerializeField] Rigidbody projectile;
    [SerializeField] float speed = 100;
    public AudioSource shootSound;
    public AudioSource reloadSound;
    //[SerializeField] private Transform bulletHolder;
    
    void Update()
    {
        Shoot();
        ReloadAmmo();
    }

    private void Shoot()
    {
        if (GameManager.playerAmmo > 0)
        {
            if (Input.GetButtonDown("Fire1"))
            {
                shootSound.Play();
                Rigidbody p = Instantiate(projectile, transform.position + transform.right * 0.8f, Quaternion.identity);
                //p.transform.SetParent(bulletHolder);
                p.velocity = transform.right * speed;
                //Debug.Log("bang");
                GameManager.playerAmmo -= 1;
            }
        }
    }
    private void ReloadAmmo()
    {
        if (Input.GetButton("Reload"))
        {
            reloadSound.Play();
            GameManager.playerAmmo = GameManager.playerAmmoMax;
        }
    }
}
