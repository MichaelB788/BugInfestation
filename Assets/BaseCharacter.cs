using UnityEngine;

public class BaseCharacter : MonoBehaviour
{
	public float moveSpeed = 10.0f;
	public int health = 3;

  public AudioClip deathSound;
  public AudioClip hitSound;

	protected Rigidbody2D rb;
	protected SpriteRenderer spriteRenderer;
	protected Vector2 direction = Vector2.zero;

	protected virtual void Awake()
	{
		rb = GetComponent<Rigidbody2D>();
		Debug.Assert(rb != null);

		spriteRenderer = GetComponent<SpriteRenderer>();
		Debug.Assert(spriteRenderer != null);
	}

	protected virtual void Move(Vector2 direction)
	{
		rb.linearVelocity = direction;

		// Flip the sprite based on velocity
		if (rb.linearVelocityX > 0)
		{
			spriteRenderer.flipX = false; // Facing right
		}
		else if (rb.linearVelocityX < 0)
		{
			spriteRenderer.flipX = true; // Facing left
		}
	}

  protected virtual void Die()
  {
		if (deathSound != null)
		{
			AudioSource.PlayClipAtPoint(deathSound, transform.position);
		}
    Destroy(gameObject);
  }

  protected virtual void GetHit()
  {
		if (deathSound != null)
		{
			AudioSource.PlayClipAtPoint(hitSound, transform.position);
		}
    health--;
  }
}
