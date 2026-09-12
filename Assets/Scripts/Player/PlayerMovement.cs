using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] Rigidbody2D rb;
    [SerializeField] float speed;
    [SerializeField] InputActionReference moveInput;
    [SerializeField] Animator playerAnimator;
    [SerializeField] PlayerInput playerInput;


    private Vector2 moveVector;
    void Start()
    {
        playerInput.SwitchCurrentActionMap("UI");
    }

    void Update()
    {
        moveVector = moveInput.action.ReadValue<Vector2>().normalized;
        playerAnimator.SetBool("isWalking", moveVector != Vector2.zero);

        if (moveVector != Vector2.zero)
        {
            playerAnimator.SetFloat("moveX", moveVector.x);
            playerAnimator.SetFloat("moveY", moveVector.y);
        }
    }

    void FixedUpdate()
    {
        rb.linearVelocity = moveVector * speed;
    }


}
