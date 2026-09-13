using UnityEngine;

public class Drone : MonoBehaviour
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
