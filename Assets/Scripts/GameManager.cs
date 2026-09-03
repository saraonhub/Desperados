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
        Debug.Log("RELOAD METHOD");

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
}
