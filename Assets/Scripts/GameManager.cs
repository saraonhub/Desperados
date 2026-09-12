using System.Collections;
using Unity.VectorGraphics;
using UnityEditor;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;
    [SerializeField] AudioSource UIsound;
    // [SerializeField] PlayerInput playerInput;
    int secretsFound = 0;

    void Start()
    {
        // playerInput.SwitchCurrentActionMap("UI");
        PauseGame();

    }

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

    public void QuitGame()
    {
        UIsound.Play();
        Application.Quit();
    }

    public void ReloadGame()
    {
        UIsound.Play();
        StartCoroutine(ReloadRoutine());

    }
    IEnumerator ReloadRoutine()
    {
        Debug.Log("routine start");
        yield return new WaitForSecondsRealtime(1f);
        Debug.Log("this never happens");
        Time.timeScale = 1f;
        SceneManager.LoadScene(2);
    }

    public void SecretFound()
    {
        secretsFound++;
        Debug.Log(secretsFound);
    }

    public int GetSecertsFound()
    {
        return secretsFound;
    }

    public void PauseGame()
    {
        Time.timeScale = 0f;
    }

    public void ResumeGame()
    {
        Time.timeScale = 1f;
    }

    IEnumerator StartGameLoading()
    {
        UIsound.Play();
        yield return new WaitForSeconds(1f);
        SceneManager.LoadScene(1);
    }

    public void StartGame()
    {
        StartCoroutine(StartGameLoading());

    }

    IEnumerator StartCreditsLoading()
    {
        UIsound.Play();
        yield return new WaitForSeconds(1f);
        SceneManager.LoadScene(4);
    }

    public void Credits()
    {
        StartCoroutine(StartCreditsLoading());
    }

    public void StartGameplay(int nextSceneIndex)
    {
        SceneManager.LoadScene(nextSceneIndex);
    }

    public IEnumerator EndGameplay()
    {
        yield return new WaitForSeconds(2f);
        SceneManager.LoadScene(3);
    }

    public void OpenLink(string link)
    {
        Application.OpenURL(link);
    }
}
