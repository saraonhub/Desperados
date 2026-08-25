using System.Collections;
using UnityEngine;


public class EnemyHealth : MonoBehaviour
{
    [SerializeField] int health;
    [SerializeField] Animator animator;
    [SerializeField] EnemyManager enemyManager;

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Bullet"))
        {
            Debug.Log("BANG");
            health--;
            Destroy(collision.gameObject);

            if (health <= 0)
            {
                animator.SetBool("Die", true);
                StartCoroutine(DeathRoutine());
                enemyManager.EnemyDied();
            }
        }
    }

    IEnumerator DeathRoutine()
    {
        yield return new WaitForSeconds(0.5f);
        Destroy(gameObject);


    }

}
