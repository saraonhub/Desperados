using TMPro;
using UnityEngine;

public class AmmoUI : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI inMagazine;
    [SerializeField] TextMeshProUGUI inStorage;

    [SerializeField] Shooting shooting;

    public void UpdateAmmo()
    {
        inMagazine.text = shooting.CurrentAmmo.ToString();
        inStorage.text = "/" + shooting.Storage.ToString();
    }

}
