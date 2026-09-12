using UnityEngine;
using UnityEngine.InputSystem;

public class Interaction : MonoBehaviour
{
    [SerializeField] InputActionReference interactInput;

    IInteractable currentInteractable;

    void OnEnable()
    {
        if (interactInput != null)
        {
            interactInput.action.Enable();
            interactInput.action.performed += OnKeyTriggered;
        }
    }

    void OnDisable()
    {
        if (interactInput != null)
        {
            interactInput.action.Disable();
            interactInput.action.performed -= OnKeyTriggered;
        }
    }

    void OnKeyTriggered(InputAction.CallbackContext context)
    {
        if (currentInteractable != null)
        {
            currentInteractable.Interact();
        }
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        IInteractable interactable = collision.GetComponent<IInteractable>();

        if (interactable != null)
        {
            currentInteractable = interactable;
            interactable.Highlight();
        }
    }

    void OnTriggerStay2D(Collider2D collision)
    {
        IInteractable interactable = collision.GetComponent<IInteractable>();

        if (interactable != null)
        {
            currentInteractable = interactable;
            interactable.Highlight();
        }
    }

    void OnTriggerExit2D(Collider2D collision)
    {
        IInteractable interactable = collision.GetComponent<IInteractable>();

        if (interactable != null)
        {
            interactable.HideHighlight();

            if (interactable == currentInteractable)
            {
                currentInteractable = null;
            }
        }
    }
}