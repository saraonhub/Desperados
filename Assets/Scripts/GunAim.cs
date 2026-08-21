using UnityEngine;
using UnityEngine.InputSystem;

public class GunAim : MonoBehaviour
{
    void Update()
    {
        Vector3 mousePosition = Camera.main.ScreenToWorldPoint(
            Mouse.current.position.ReadValue()
        );

        Vector3 rotation = transform.localEulerAngles;

        if (mousePosition.x < transform.position.x)
        {
            rotation.y = 180f;
        }
        else
        {
            rotation.y = 0f;
        }

        float angle = Mathf.Atan2(
            mousePosition.y - transform.position.y,
            Mathf.Abs(mousePosition.x - transform.position.x)
        ) * Mathf.Rad2Deg;

        rotation.z = angle;

        transform.localEulerAngles = rotation;
    }
}