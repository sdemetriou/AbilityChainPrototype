using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] private int health = 20;
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    public void absorbDamage(int dmgAmount)
    {
        health -= dmgAmount;
        if (health <= 0)
        {
            Destroy(gameObject);
        }
    }
}
