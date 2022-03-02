using System.Collections;
using JetBrains.Annotations;
using UnityEngine;

public class ShootScript : MonoBehaviour
{
    [SerializeField] Rigidbody projectile;
    [SerializeField] float speed = 100;
    [CanBeNull] public AudioSource shootSound;
    [CanBeNull] public AudioSource reloadSound;

    [SerializeField] private Animator animator;
    private bool canReload = true;
    
    void Update()
    {
        Shoot();
        ReloadAmmo();
    }

    private void Shoot()
    {
        animator.SetBool("Fire",false);
        if (GameManager.playerAmmo > 0)
        {
            if (Input.GetButtonDown("Fire1"))
            {
                animator.SetBool("Fire",true);
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
        animator.SetBool("Reload",false);
        if (canReload)
        {
            if (Input.GetButtonUp("Reload"))
            {
                StartCoroutine(CanTReload());
                animator.SetBool("Reload",true);
                reloadSound.Play();
                GameManager.playerAmmo = GameManager.playerAmmoMax;
            }
        }
    }

    private IEnumerator CanTReload()
    {
        canReload = false;
        yield return new WaitForSeconds(1f);
        canReload = true;
    }
}
