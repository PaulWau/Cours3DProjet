using UnityEngine;

public class MouseLook : MonoBehaviour
{
    private float _mouseSensitivity = 100f;
    public Transform player;
    private float _yawn;
    private float _pitch;
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        _mouseSensitivity = GameManager.sensiValue;
        _yawn += Input.GetAxis("Mouse X") * _mouseSensitivity/100f;
        _pitch -= Input.GetAxis("Mouse Y") * _mouseSensitivity/100f;
        _pitch = Mathf.Clamp(_pitch, -90f, 90f);

        transform.eulerAngles = new Vector3(0f, _yawn, 0f);
        player.eulerAngles = new Vector3(_pitch, 0f, 0f);
    }
}
