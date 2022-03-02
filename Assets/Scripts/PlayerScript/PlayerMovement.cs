using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private AudioSource _jumpSound;
    [SerializeField] private CharacterController _controller;
    public float speed = 10f;
    public float jumpHeight = 3f;
    public float gravity = -9.81f;
    [SerializeField] private Transform _groundCheck;
    [SerializeField] private float _groundDistance = 0.3f;
    public LayerMask groundMask;

    private Vector3 _velocity;
    private bool _isGrounded;
    
    void Update()
    {
    
        _isGrounded = Physics.CheckSphere(_groundCheck.position, _groundDistance, groundMask);

        
        float x = Input.GetAxis("Horizontal");
        float y = Input.GetAxis("Vertical");

        SetSpeed();
        Vector3 move = transform.right * x + transform.forward * y;
        _controller.Move(move * speed * Time.deltaTime);

        //Debug.Log(isGrounded);
        if (_isGrounded && Input.GetButton("Jump"))
        {
            _jumpSound.Play();
            _velocity.y = Mathf.Sqrt(jumpHeight * -2f * gravity);
        }
        _velocity.y += gravity * Time.deltaTime * 2f;
        _controller.Move(_velocity * Time.deltaTime);
    }

    private void SetSpeed()
    {
        if (Input.GetButton("Sprint"))
        {
            speed = 20f;
        }
        else
        {
            speed = 10f;
        }
    }
}
