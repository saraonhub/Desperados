using System.Collections;
using Unity.VectorGraphics;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;
    int secretsFound = 0;

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
        Debug.Log("QUIT METHOD");

        Application.Quit();
    }

    public void ReloadGame()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        UIManager.Instance.DeactivateUIMap();
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
        yield return new WaitForSeconds(1f);
        SceneManager.LoadScene(1);
    }

    public void StartGame()
    {
        StartCoroutine(StartGameLoading());

    }

    IEnumerator StartCreditsLoading()
    {
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
}
