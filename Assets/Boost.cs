using UnityEngine;

public class Boost : Property
{
    [SerializeField] private float boostAmount = 10;
    public override GameObject fabricate(GameObject instance)
    {
        Rigidbody2D body = instance.GetComponent<Rigidbody2D>();
        body.linearVelocity = new Vector2(body.linearVelocity.x * boostAmount, body.linearVelocity.y);
        return instance;
    }
}
