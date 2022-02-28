using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera_Movement : MonoBehaviour
{
        private float yamn = 0f;
        private float pitch = 0f;
        private float sensi = 6f;
    // Start is called before the first frame update
    void Start()
    {
       Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        yamn += Input.GetAxis("Mouse X")*sensi;
        pitch -= Input.GetAxis("Mouse Y")*sensi;
        pitch = Mathf.Clamp(pitch, -90f, 90f);
        transform.eulerAngles = new Vector3(pitch, yamn, 0f);
    }
}
