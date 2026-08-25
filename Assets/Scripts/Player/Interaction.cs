using System;
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

    private void OnKeyTriggered(InputAction.CallbackContext context)
    {
        if (currentInteractable != null)
        {
            currentInteractable.Interact();
        }
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        currentInteractable = collision.GetComponent<IInteractable>();
        //Debug.Log(currentInteractable);
    }

    void OnTriggerExit2D(Collider2D collision)
    {
        currentInteractable = null;
    }
}
