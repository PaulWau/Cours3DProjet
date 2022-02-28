using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletDestroy : MonoBehaviour

{
    [SerializeField] private float counter = 0;
    [SerializeField] public float timer = 5;

    private void OnCollisionEnter(Collision collision)
    {
        Destroy(this.gameObject);
    }

    private void Update()
    {
        counter += Time.deltaTime;
        if (counter > timer)
        {
            Destroy(this.gameObject);
        }
    }
}
