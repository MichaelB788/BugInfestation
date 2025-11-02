using UnityEngine;

public class Enemy : BaseCharacter
{
	public ScoreManager scoreManagerScript;
	public float scoreMultiplier;
	public int points;

	protected virtual void FixedUpdate()
	{
		Move(direction * moveSpeed);
	}

	protected virtual void OnCollisionEnter2D(Collision2D collision)
	{
		if (collision.gameObject.CompareTag("Bullet"))
		{
			if (health > 1)
			{
				GetHit();
			}
			else
			{
				Die();
			}
			scoreManagerScript.IncrementScore(points, scoreMultiplier);
		}
		else
		{
			direction = Vector2.Reflect(direction, collision.contacts[0].normal);
		}
	}
}
