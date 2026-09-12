using UnityEngine;

public class Bullet : Projectile
{
    [SerializeField] private int rawDamage = 10;
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Enemy"))
        {
            collision.GetComponent<Enemy>()?.absorbDamage(rawDamage);
            Destroy(gameObject);
        }
    }
}
