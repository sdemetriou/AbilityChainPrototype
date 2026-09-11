using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
  private Rigidbody2D body;
  private Collider2D playerCollider;
  private int previousDirection = 1;
  public int FacingDirection => previousDirection;
  LayerMask groundLayer;
  [SerializeField] private float movementSpeed = 10;
  [SerializeField] private float Jump = 10;


  void Awake()
  {
    body = GetComponent<Rigidbody2D>();
    playerCollider = GetComponent<Collider2D>();
    groundLayer = LayerMask.GetMask("Ground");
  }

  // Start is called before the first frame update
  void Start()
  {
    // Debug.Log(body.velocity.x.GetType());
  }

  // Update is called once per frame
  void Update()
  {
    float direction = Input.GetAxisRaw("Horizontal");
    float movement = direction * movementSpeed;
    body.linearVelocity = new Vector2(movement, body.linearVelocity.y);
    Vector2 playerPosition = new Vector2(body.transform.position.x, body.transform.position.y);

    float playerBottom = playerCollider.bounds.center.y - playerCollider.bounds.extents.y;
    Vector2 floorDetectorPosition = new Vector2(body.transform.position.x, playerBottom);

    Collider2D detectedObjects = Physics2D.OverlapCircle(floorDetectorPosition, 1, groundLayer);
    if (detectedObjects && Input.GetButtonDown("Jump"))
    {
      Vector2 jumpForce = new Vector2(0, Jump);
      body.AddForce(jumpForce, ForceMode2D.Impulse);
    }

    if (direction < 0)
    {
      previousDirection = -1;
    }
    else if (direction > 0)
    {
      previousDirection = 1;
    }
    this.transform.localScale = new Vector3(previousDirection, this.transform.localScale.y, this.transform.localScale.z);
  }

  void OnDrawGizmosSelected()
  {
    Collider2D playerColliderTest = GetComponent<Collider2D>();
    float playerBottom = playerColliderTest.bounds.center.y - playerColliderTest.bounds.extents.y;
    Vector3 floorDetectorPosition = new Vector3(this.transform.position.x, playerBottom, 0);
    Gizmos.DrawWireSphere(floorDetectorPosition, 1);
  }
}
