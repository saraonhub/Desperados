using System.Collections;
using Unity.VisualScripting;
using UnityEngine;

public class SafeInteract : MonoBehaviour, IInteractable
{
    [SerializeField] GameObject glow;
    [SerializeField] GameObject dialogue;
    [SerializeField] ObjectiveUI objectiveUI;
    [SerializeField] GameObject dollarSign;
    [SerializeField] AudioSource collectSound;
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
        dollarSign.SetActive(true);
        collectSound.Play();
        UIManager.Instance.Completed();
    }

    IEnumerator DialougePopup()
    {
        yield return new WaitForSeconds(2.35f);
        dialogue.SetActive(false);
    }




}
