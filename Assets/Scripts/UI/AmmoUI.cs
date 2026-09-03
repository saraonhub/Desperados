using System.Collections;
using TMPro;
using UnityEngine;
using UnityEngine.UIElements;

public class AmmoUI : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI inMagazine;
    [SerializeField] TextMeshProUGUI inStorage;
    [SerializeField] TextMeshProUGUI refill;

    [SerializeField] Shooting shooting;
    public GameObject reloading;
    void Start()
    {
        refill.enabled = false;
    }

    public void UpdateAmmo()
    {
        inMagazine.text = shooting.CurrentAmmo.ToString();
        inStorage.text = "/" + shooting.Storage.ToString();

    }

    public void AddAmmoUI()
    {
        StartCoroutine(Popup());
    }

    IEnumerator Popup()
    {
        refill.enabled = true;
        yield return new WaitForSeconds(1f);
        refill.enabled = false;
    }

}
