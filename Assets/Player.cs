using UnityEngine;

public class Player : Entity
{
	public float jumpForce = 15.0f;
	private bool isGrounded;
	private bool isOnWall;

	void Update()
	{
		direction.x = isOnWall? 0 : Input.GetAxis("Horizontal") * moveSpeed;
		direction.y = rb.linearVelocityY;
		Move(direction);

		if (Input.GetKeyDown(KeyCode.W) && isGrounded)
		{
			Jump();
		}
	}
	private void OnCollisionEnter2D(Collision2D collision)
	{
		if (collision.gameObject.CompareTag("Floor"))
		{
			isGrounded = true;
			isOnWall = false;
		}
		else if (collision.gameObject.CompareTag("Wall"))
		{
			isOnWall = true;
		}
	}

	private void Jump()
	{
		rb.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
		isGrounded = false;
	}
}
