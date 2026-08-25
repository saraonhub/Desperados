using System.Collections;
using Unity.Mathematics;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;

public class Shooting : MonoBehaviour
{
    [SerializeField] GameObject bullet;
    [SerializeField] InputActionReference shootInput;
    [SerializeField] GameObject muzzleFlash;
    [SerializeField] Transform muzzle;
    [SerializeField] AmmoUI ammoUI;

    Vector2 direction;

    int magazine = 6;
    int currentAmmo;
    int storage = 24;
    float reloadTime = 2f;

    bool isReloading;

    // properties 
    public int CurrentAmmo => currentAmmo;
    public int Storage => storage;
    void Start()
    {
        currentAmmo = magazine;
    }

    void Update()
    {
        Vector3 mousePosition = Camera.main.ScreenToWorldPoint(
            Mouse.current.position.ReadValue()
        );

        direction = mousePosition - transform.position;
    }

    void OnEnable()
    {
        if (shootInput != null)
        {
            shootInput.action.Enable();
            shootInput.action.performed += OnKeyTriggered;
        }
    }

    void OnDisable()
    {
        if (shootInput != null)
        {
            shootInput.action.Disable();
            shootInput.action.performed -= OnKeyTriggered;
        }
    }

    void OnKeyTriggered(InputAction.CallbackContext context)
    {
        if (isReloading) return;

        if (currentAmmo < 1)
        {

            if (storage > 0)
                StartCoroutine(Reload());

            else
                Debug.Log("EMPTY");
        }
        else
        {
            GameObject newBullet = Instantiate(
                bullet,
                muzzle.position + (Vector3)direction.normalized,
                Quaternion.identity
            );
            StartCoroutine(ShowMuzzleFlash());
            Bullet bulletScript = newBullet.GetComponent<Bullet>();

            bulletScript.SetDirection(direction);

            currentAmmo--;
            ammoUI.UpdateAmmo();

        }

    }

    public void AddAmmo(int ammount)
    {
        storage += ammount;
        ammoUI.UpdateAmmo();
    }

    IEnumerator Reload()
    {
        isReloading = true;
        yield return new WaitForSeconds(reloadTime);

        int bulletsToReload = Mathf.Min(storage, magazine);

        currentAmmo = bulletsToReload;
        storage -= bulletsToReload;
        ammoUI.UpdateAmmo();
        isReloading = false;

    }

    IEnumerator ShowMuzzleFlash()
    {
        muzzleFlash.SetActive(true);
        yield return new WaitForSeconds(0.05f);
        muzzleFlash.SetActive(false);
    }



}
