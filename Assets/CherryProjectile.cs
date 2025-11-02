using UnityEngine;

public class CherryProjectile : MonoBehaviour
{
	public GameObject player;

	private float launchForce = 20f;
	private bool isFired = false;

	private Rigidbody2D cherryBody;
	private SpriteRenderer spriteRenderer;


	void Start()
	{
		cherryBody = GetComponent<Rigidbody2D>();
		spriteRenderer = GetComponent<SpriteRenderer>();
		spriteRenderer.enabled = false;
	}

	void Update()
	{
		if (Input.GetKeyDown(KeyCode.Space) && !isFired)
		{
			LaunchProjectile();
		}
	}

	void LaunchProjectile()
	{
		isFired = true;
		spriteRenderer.enabled = true;
		transform.position = player.GetComponent<Rigidbody2D>().position;
		cherryBody.linearVelocity = Vector2.up * launchForce;
	}

	private void OnCollisionEnter2D(Collision2D collision)
	{
		if (collision.gameObject.CompareTag("Player")) return;

		spriteRenderer.enabled = false;
		isFired = false;
	}
}