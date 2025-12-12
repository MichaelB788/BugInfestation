using UnityEngine;

public class Entity : MonoBehaviour
{
	public float moveSpeed;
	protected Vector2 direction;
	protected Rigidbody2D rb;
	protected SpriteRenderer sr;

	protected virtual void Awake()
	{
		rb = GetComponent<Rigidbody2D>();
		Debug.Assert(rb != null);

		sr = GetComponent<SpriteRenderer>();
		Debug.Assert(sr != null);
	}

	protected virtual void Move(Vector2 direction)
	{
		rb.linearVelocity = direction;
		if (rb.linearVelocityX > 0) sr.flipX = false;
		else if (rb.linearVelocityX < 0) sr.flipX = true;
	}
}
