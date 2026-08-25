using UnityEngine.UI;
using UnityEngine;
using Unity.VisualScripting;

public class HealthUI : MonoBehaviour
{
    [SerializeField] Image healthBar;
    [SerializeField] PlayerHealth playerHealth;
    [SerializeField] GameObject damageFlash;

    void Start()
    {
        damageFlash.SetActive(false);
    }
    public void UpdateHealth()
    {
        healthBar.fillAmount = playerHealth.CurrentHealth / 7f;
        ShowDamage();
    }

    public void ShowDamage()
    {
        damageFlash.SetActive(true);
        Invoke("HideDamage", 0.3f);
    }

    public void HideDamage()
    {
        damageFlash.SetActive(false);

    }


}
