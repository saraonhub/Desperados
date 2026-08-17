using System.Collections;
using UnityEngine;

public class EnemyAI : MonoBehaviour
{
    [SerializeField] Transform player;
    [SerializeField] Transform enemyGun;
    [SerializeField] Transform enemyMuzzele;
    [SerializeField] GameObject enemyBullet;
    [SerializeField] GameObject enemyMuzzleFlash;

    [SerializeField] float shootDelay = 2f;
    void Start()
    {
        StartCoroutine(ShootRoutine());
    }


    void Update()
    {
        Vector2 direction = player.position - enemyGun.position;

        float angle = Mathf.Atan2(direction.y, Mathf.Abs(direction.x)) * Mathf.Rad2Deg;

        Vector3 rotation = enemyGun.localEulerAngles;

        if (player.position.x < enemyGun.position.x)
        {
            rotation.y = 180f;
        }
        else
        {
            rotation.y = 0f;
        }

        rotation.z = angle;

        enemyGun.localEulerAngles = rotation;
    }

    IEnumerator ShootRoutine()
    {
        yield return new WaitForSeconds(2f);

        while (true)
        {
            Shoot();

            yield return new WaitForSeconds(shootDelay);
        }
    }

    void Shoot()
    {
        Vector2 direction = player.position - enemyMuzzele.position;

        GameObject newBullet = Instantiate(
            enemyBullet,
            enemyMuzzele.position + (Vector3)direction.normalized,
            Quaternion.identity
        );
        StartCoroutine(ShowMuzzleFlash());

        Bullet bulletScript = newBullet.GetComponent<Bullet>();

        bulletScript.SetDirection(direction);
    }


    IEnumerator ShowMuzzleFlash()
    {
        enemyMuzzleFlash.SetActive(true);
        yield return new WaitForSeconds(0.05f);
        enemyMuzzleFlash.SetActive(false);
    }

}
