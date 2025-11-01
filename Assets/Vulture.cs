using UnityEngine;
public class Vulture : Enemy
{
	private void Start()
	{
		scoreMultiplier = 1;
		points = 1;
		direction = Random.insideUnitCircle.normalized;
	}
}
