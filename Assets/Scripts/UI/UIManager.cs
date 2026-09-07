using System.Collections;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;

public class UIManager : MonoBehaviour
{
    public static UIManager Instance;
    [SerializeField] GameObject completed;
    [SerializeField] TextMeshProUGUI seceretsFoundText;
    [SerializeField] GameObject failed;
    [SerializeField] PlayerInput playerInput;



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
        GameManager.Instance.EndGameplay();
    }
    public void FailedScreen()
    {
        failed.SetActive(true);
        ActivateUIMap();

    }

    public void OnClickQuit()
    {
        GameManager.Instance.QuitGame();
    }

    public void OnClickReload()
    {
        Debug.Log("RELOAD");

        GameManager.Instance.ReloadGame();
    }

    public void ActivateUIMap()
    {
        playerInput.SwitchCurrentActionMap("UI");
        Debug.Log("UI MAP");

    }

    public void DeactivateUIMap()
    {
        playerInput.SwitchCurrentActionMap("Movement");
        Debug.Log("MOVEMENT MAP");

    }

    public void SecretOpen(Animator popup)
    {
        popup.SetTrigger("Open");
        ActivateUIMap();
    }

    public void SecretClose(Animator popup)
    {
        popup.SetTrigger("Close");
        DeactivateUIMap();
    }


}



