using System.Collections;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class SecretInteract : MonoBehaviour, IInteractable
{
    [SerializeField] GameObject glow;
    [SerializeField] ObjectiveUI objectiveUI;
    [SerializeField] GameObject dialogue;
    [SerializeField] Animator secretUIPopup;
    [SerializeField] TextMeshProUGUI dialougeText;
    [SerializeField] string text;
    bool pickedup;



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
        if (!pickedup)
            pickedup = true;
        GameManager.Instance.SecretFound();
        glow.SetActive(false);
        UIManager.Instance.SecretOpen(secretUIPopup);
        StartCoroutine(CommentPopup());
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

    IEnumerator CommentPopup()
    {
        yield return new WaitForSeconds(3f);
        dialogue.SetActive(true);
        dialougeText.text = text;
        yield return new WaitForSeconds(4f);
        dialogue.SetActive(false);


    }
}
