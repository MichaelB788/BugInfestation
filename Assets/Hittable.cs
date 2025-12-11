using UnityEngine;

public class Hittable : Entity
{
	public uint health = 3;
	public uint points = 5;
	public float mult = 2f;

	public AudioClip hit;
	public AudioClip death;

	public ScoreManager scoreManager;

	public override void Awake()
	{
		base.Awake();
		scoreManager = GetComponent<ScoreManager>();
		Debug.Assert(scoreManager != null);
		hit = GetComponent<AudioClip>();
		death = GetComponent<AudioClip>();
	}


	public virtual void FixedUpdate()
	{
		Move(direction * moveSpeed);
	}

	public virtual void OnCollisionEnter2D(Collision2D collision)
	{
		if (collision.gameObject.CompareTag("Bullet"))
		{
			if (health > 1) GetHit();
			else Die();
			scoreManager.IncrementScore(points, mult);
		}
		else
		{
			// HACK: collision.contacts produces garbage, come back to this
			direction = Vector2.Reflect(direction, collision.contacts[0].normal);
		}
	}

  public virtual void GetHit()
  {
		if (hit != null) AudioSource.PlayClipAtPoint(hit, transform.position);
    health--;
  }

  public virtual void Die()
  {
		if (death != null) AudioSource.PlayClipAtPoint(death, transform.position);
    Destroy(gameObject);
  }
}
