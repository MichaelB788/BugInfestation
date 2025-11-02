using UnityEngine;
using UnityEngine.SceneManagement;

public class Beetle : Enemy
{
	public float inflationRate = 0.05f;
	public float inflationInterval = 0.1f;
	public float maxScale = 3.0f;

	void Start()
	{
		scoreMultiplier = 2.0f;
		points = 5;
		direction = Vector2.right;
		InvokeRepeating("Inflate", 0f, inflationInterval);
	}

	void Inflate()
	{
		// Grow the sprite
		Vector2 currentScale = transform.localScale;
		currentScale.x -= inflationRate;
		currentScale.y += inflationRate;
		transform.localScale = currentScale;

		// Check if we've reached max scale
		if (currentScale.x >= maxScale || currentScale.y >= maxScale)
		{
			CancelInvoke("Inflate");
			Destroy(gameObject);
			SceneManager.LoadScene(SceneManager.GetActiveScene().name);
		}
	}

	protected override void Die()
	{
		base.Die();
		SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
	}
}