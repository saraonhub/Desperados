using System.Collections;
using Unity.VisualScripting;
using UnityEngine;

public class SafeInteract : MonoBehaviour, IInteractable
{
    [SerializeField] GameObject glow;
    [SerializeField] GameObject dialogue;
    [SerializeField] ObjectiveUI objectiveUI;
    void IInteractable.Interact()
    {
        if (!objectiveUI.objective2Active)
        {
            dialogue.SetActive(true);
            StartCoroutine(DialougePopup());
        }
        else
        {
            LootSafe();
        }
    }

    void IInteractable.Highlight()
    {
        glow.SetActive(true);
    }

    void IInteractable.HideHighlight()
    {
        glow.SetActive(false);
    }

    void LootSafe()
    {
        Debug.Log("MONEEEEY");
    }

    IEnumerator DialougePopup()
    {
        yield return new WaitForSeconds(2.35f);
        dialogue.SetActive(false);
    }

}
