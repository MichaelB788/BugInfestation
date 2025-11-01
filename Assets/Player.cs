using UnityEngine;

public class Player : BaseCharacter
{
	public float jumpForce = 10.0f;
	private bool isGrounded;

	void Update()
	{
		direction.x = Input.GetAxis("Horizontal");
		direction.y = rb.linearVelocityY;
		Move(new Vector2(direction.x * moveSpeed, direction.y));

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
		}
	}

	private void Jump()
	{
		rb.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
		isGrounded = false;
	}
}
