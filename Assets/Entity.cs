using UnityEngine;

public class Entity : MonoBehaviour
{
	public float moveSpeed;
	public Vector2 direction;

	public Rigidbody2D rb;
	public SpriteRenderer sr;

	public virtual void Awake()
	{
		rb = GetComponent<Rigidbody2D>();
		Debug.Assert(rb != null);

		sr = GetComponent<SpriteRenderer>();
		Debug.Assert(sr != null);
	}

	public virtual void Move(Vector2 direction)
	{
		rb.linearVelocity = direction;
		if (rb.linearVelocityX > 0) sr.flipX = false;
		else if (rb.linearVelocityX < 0) sr.flipX = true;
	}
}
