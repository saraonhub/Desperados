using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class ObjectiveUI : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI objective;
    public bool objective2Active = false;

    public void Objective1Completed()
    {
        objective.fontStyle = FontStyles.Strikethrough;
        Invoke("Objective2Start", 1f);
    }

    public void Objective2Start()
    {
        objective.fontStyle = FontStyles.Normal;
        objective.text = "Loot the safe";
        objective2Active = true;
    }

    public void Objective2Completed()
    {
        objective.fontStyle = FontStyles.Strikethrough;
    }
}
