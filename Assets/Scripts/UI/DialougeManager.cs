using System;
using System.Collections;
using Unity.VisualScripting;
using UnityEngine;

public class DialougeManager : MonoBehaviour
{
    [SerializeField] GameObject[] array;
    [SerializeField] int nextSceneIndex;
    float delay = 4f;
    int current = 0;

    void Start()
    {
        StartCoroutine(DialougeRoutine());
    }

    IEnumerator DialougeRoutine()
    {
        GameManager.Instance.ResumeGame();
        for (current = 0; current < array.Length; current++)
        {
            array[current].SetActive(true);
            yield return new WaitForSeconds(delay);
        }
        GameManager.Instance.StartGameplay(nextSceneIndex);
    }


}
