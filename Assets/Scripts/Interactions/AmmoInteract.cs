using System;
using System.Collections;
using UnityEngine;

public class AmmoInteract : MonoBehaviour, IInteractable
{
    [SerializeField] Shooting shooting;
    [SerializeField] GameObject glow;
    void IInteractable.Interact()
    {
        shooting.AddAmmo(6);
        Destroy(gameObject);
    }

    void IInteractable.Highlight()
    {
        glow.SetActive(true);
    }

    void IInteractable.HideHighlight()
    {
        glow.SetActive(false);

    }

}
