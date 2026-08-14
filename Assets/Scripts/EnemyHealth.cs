using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    [SerializeField] int health;

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Bullet"))
        {
            health--;
            Destroy(collision.gameObject);

            if (health <= 0)
            {
                Destroy(gameObject);
            }
        }
    }

}
