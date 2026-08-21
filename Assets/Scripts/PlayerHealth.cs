using System;
using System.Collections;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    [SerializeField] int health = 5;
    [SerializeField] Animator animator;
    [SerializeField] HealthUI healthUI;
    public int CurrentHealth => health;
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("EnemyBullet"))
        {
            health--;
            healthUI.UpdateHealth();
            Debug.Log("Cora health: " + health);
            if (health <= 0)
            {
                animator.SetBool("Die", true);
                StartCoroutine(DeathRoutine());
            }
        }
    }

    IEnumerator DeathRoutine()
    {
        yield return new WaitForSeconds(0.5f);
        Destroy(gameObject);
    }
}
