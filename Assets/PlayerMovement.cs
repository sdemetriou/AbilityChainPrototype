using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
  private Rigidbody2D body;
  [SerializeField] private float movementSpeed = 10;

  void Awake()
  {
    body = GetComponent<Rigidbody2D>();
  }

  // Start is called before the first frame update
  void Start()
  {
    // Debug.Log(body.velocity.x.GetType());
  }

  // Update is called once per frame
  void Update()
  {
    float movement = Input.GetAxisRaw("Horizontal") * movementSpeed;
    body.velocity = new Vector2(movement, body.velocity.y);
    // Debug.Log(body.velocity);
  }
}
