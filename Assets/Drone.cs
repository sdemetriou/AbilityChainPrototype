using UnityEngine;

public class Drone : MonoBehaviour
{
    [SerializeField] private int health = 20;
    private int maxHP;
    [SerializeField] private GameObject healthBar;
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    void Start()
    {
        maxHP = health;
    }
    public void absorbDamage(int dmgAmount)
    {
        health -= dmgAmount;
        if (health <= 0)
        {
            Destroy(healthBar);
            Destroy(gameObject);
        }
        healthBar.transform.localScale = new Vector3(health / (float)maxHP, healthBar.transform.localScale.y, healthBar.transform.localScale.z);
    }
}
