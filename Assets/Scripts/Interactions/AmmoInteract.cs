using System;
using UnityEngine;

public class AmmoInteract : MonoBehaviour, IInteractable
{
    [SerializeField] Shooting shooting;
    void IInteractable.Interact()
    {
        shooting.AddAmmo(6);
        Destroy(gameObject);
    }


}
