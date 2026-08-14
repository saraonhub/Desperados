using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] Rigidbody2D rb;
    [SerializeField] float speed;
    [SerializeField] InputActionReference moveInput;
    private Vector2 moveVector;

    void Start()
    {
        moveInput.action.Enable();
    }
    void Update()
    {
        moveVector = moveInput.action.ReadValue<Vector2>().normalized;
    }

    void FixedUpdate()
    {
        rb.linearVelocity = moveVector * speed;
    }


}
