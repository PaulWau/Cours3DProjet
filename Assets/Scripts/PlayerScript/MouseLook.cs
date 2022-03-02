using UnityEngine;

public class MouseLook : MonoBehaviour
{
    public float MouseSensibility = 100f;
    public Transform PlayerBody;
    private float xRotation;
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        float mouseX = Input.GetAxis("Mouse X")*MouseSensibility * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y")*MouseSensibility * Time.deltaTime;

        xRotation -= mouseY;
        xRotation = Mathf.Clamp(xRotation, -90f, 90f);
        
        transform.localRotation = Quaternion.Euler(xRotation,0f,0f);
        PlayerBody.Rotate(Vector3.up * mouseX);
    }
}
