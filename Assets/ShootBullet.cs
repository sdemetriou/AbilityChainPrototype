using UnityEngine;

public class ShootBullet : MonoBehaviour
{
    [SerializeField] private GameObject bulletPrefab;
    [SerializeField] private float initBulletSpeed = 10;
    [SerializeField] private Property[] properties;
    private PlayerMovement player;

    void Awake()
    {
        player = GetComponentInParent<PlayerMovement>();
    }

    void Update()
    {
        if (!Input.GetMouseButtonDown(0)) return;

        float facingDirection = player.FacingDirection;

        UnityEngine.Vector3 spawnPosition = new UnityEngine.Vector3(this.transform.position.x, this.transform.position.y, 0);
        GameObject bullet = Instantiate(bulletPrefab, spawnPosition, this.transform.rotation);
        Rigidbody2D bulletBody = bullet.GetComponent<Rigidbody2D>();
        bulletBody.linearVelocity = new Vector2(initBulletSpeed * facingDirection, 0);

        for (int i = 0; i < properties.Length; i++)
        {
            bullet = properties[i].fabricate(bullet);
        }
    }
}