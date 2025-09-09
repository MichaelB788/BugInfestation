using UnityEngine;

public class CherryProjectile : MonoBehaviour
{
	public GameObject projectilePrefab;
	public GameObject playerPrefab;
	public float launchForce = 20f;

  private GameObject projectile;

	void Update()
	{
		if (Input.GetKeyDown(KeyCode.Space))
		{
			LaunchProjectile();
		}
	}

	void LaunchProjectile()
	{
    projectile = Instantiate(projectilePrefab);
		projectile.transform.position = playerPrefab.GetComponent<Rigidbody2D>().position;

		Rigidbody2D rb = projectile.GetComponent<Rigidbody2D>();
    rb.linearVelocity = Vector2.up * launchForce;

    Destroy(projectile, 3f);
	}

	private void OnCollisionEnter2D(Collision2D collision)
	{
		if (collision.gameObject.CompareTag("Enemy"))
    {
      Destroy(projectile);
    }
    ;
	}
}