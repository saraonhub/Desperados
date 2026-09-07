using System.Collections;
using TMPro;
using UnityEngine;
using UnityEngine.InputSystem;


public class MainMenu : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI text;
    [SerializeField] InputActionReference anyBtnInput;
    [SerializeField] Animator logoAnimator;
    [SerializeField] Animator backgroundAnimator;
    [SerializeField] Animator buttonStartAnimator;
    [SerializeField] Animator buttonQuitAnimator;
    [SerializeField] Animator buttonCreditsAnimator;

    void OnEnable()
    {
        if (anyBtnInput != null)
        {
            anyBtnInput.action.Enable();
            anyBtnInput.action.performed += OnKeyTriggered;
        }
    }

    void OnDisable()
    {
        if (anyBtnInput != null)
        {
            anyBtnInput.action.Disable();
            anyBtnInput.action.performed -= OnKeyTriggered;
        }
    }

    void OnKeyTriggered(InputAction.CallbackContext context)
    {
        TextChange();
    }

    void TextChange()
    {
        text.text = "Loading content...";
        StartCoroutine(Loading());


    }

    IEnumerator Loading()
    {
        yield return new WaitForSeconds(3f);
        LoadMenu();
    }

    void LoadMenu()
    {
        text.enabled = false;
        logoAnimator.SetTrigger("Start");
        backgroundAnimator.SetTrigger("Start");
        buttonStartAnimator.SetTrigger("Start");
        buttonQuitAnimator.SetTrigger("Start");
        buttonCreditsAnimator.SetTrigger("Start");


    }
}
