using UnityEngine;

public class Bullet : Projectile
{
    [SerializeField] private int rawDamage = 10;
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Drone"))
        {
            collision.GetComponent<Drone>()?.absorbDamage(rawDamage);
            Destroy(gameObject);
        }
    }
}