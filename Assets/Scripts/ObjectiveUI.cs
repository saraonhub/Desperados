using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class ObjectiveUI : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI objective;

    public void Objective1Completed()
    {
        objective.fontStyle = FontStyles.Strikethrough;
        Invoke("Objective2Start", 1f);
    }

    public void Objective2Start()
    {
        objective.fontStyle = FontStyles.Normal;
        objective.text = "Loot the safe";
    }

    public void Objective2Completed()
    {
        objective.fontStyle = FontStyles.Strikethrough;
    }
}
