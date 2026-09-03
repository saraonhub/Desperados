using System.Collections;
using Unity.VisualScripting;
using UnityEngine;

public class SecretInteract : MonoBehaviour, IInteractable
{
    [SerializeField] GameObject glow;
    [SerializeField] ObjectiveUI objectiveUI;
    [SerializeField] GameObject dialogue;
    [SerializeField] Animator secretUIPopup;


    void IInteractable.Interact()
    {
        if (!objectiveUI.objective2Active)
        {
            dialogue.SetActive(true);
            StartCoroutine(DialougePopup());
        }
        else
        {
            Pickup();
        }
    }


    public void Pickup()
    {
        glow.SetActive(false);
        UIManager.Instance.SecretOpen(secretUIPopup);
    }
    void IInteractable.Highlight()
    {
        glow.SetActive(true);
    }
    void IInteractable.HideHighlight()
    {
        glow.SetActive(false);
    }
    IEnumerator DialougePopup()
    {
        yield return new WaitForSeconds(2.35f);
        dialogue.SetActive(false);
    }
}
