using System.Collections;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UIElements;

public class UIManager : MonoBehaviour
{
    public static UIManager Instance;
    [SerializeField] GameObject completed;
    [SerializeField] TextMeshProUGUI seceretsFoundText;
    [SerializeField] GameObject failed;
    [SerializeField] PlayerInput playerInput;
    [SerializeField] AudioSource buttonSound;

    void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public void Completed()
    {
        completed.SetActive(true);
        seceretsFoundText.text = GameManager.Instance.GetSecertsFound().ToString() + "/3";
        StartCoroutine(GameManager.Instance.EndGameplay());
    }
    public void FailedScreen()
    {
        failed.SetActive(true);
        ActivateUIMap();
    }
    public void ActivateUIMap()
    {
        playerInput.SwitchCurrentActionMap("UI");
    }

    public void DeactivateUIMap()
    {
        playerInput.SwitchCurrentActionMap("Movement");
    }

    public void SecretOpen(Animator popup)
    {
        popup.SetTrigger("Open");
        ActivateUIMap();
    }

    public void SecretClose(Animator popup)
    {
        buttonSound.Play();
        popup.SetTrigger("Close");
        DeactivateUIMap();
    }
    public void DeactivatePopup(GameObject popup)
    {
        popup.SetActive(false);
        GameManager.Instance.ResumeGame();
        playerInput.SwitchCurrentActionMap("Movement");
    }

}



