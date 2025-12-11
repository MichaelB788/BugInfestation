using UnityEngine;
public class Vulture : Hittable
{
	private void Start()
	{
		direction = Random.insideUnitCircle.normalized;
	}
}
