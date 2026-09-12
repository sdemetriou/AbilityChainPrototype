using UnityEngine;

public class Projectile : MonoBehaviour
{
    private float projectileDecay = 10;
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    // Update is called once per frame
    void Update()
    {
        Destroy(gameObject, projectileDecay);
    }
}
