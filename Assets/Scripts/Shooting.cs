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

    Vector2 direction;

    int magazine = 6;
    float reloadTime = 2f;
    int currentAmmo;
    bool isReloading;


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

        if (currentAmmo <= 0)
        {
            StartCoroutine(Reload());
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
        }

    }

    IEnumerator Reload()
    {
        isReloading = true;
        yield return new WaitForSeconds(reloadTime);

        currentAmmo = magazine;
        isReloading = false;

    }

    IEnumerator ShowMuzzleFlash()
    {
        muzzleFlash.SetActive(true);
        yield return new WaitForSeconds(0.05f);
        muzzleFlash.SetActive(false);
    }



}
