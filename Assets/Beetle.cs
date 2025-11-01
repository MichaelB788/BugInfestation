using UnityEngine;
using System.Collections;

public class Beetle : Enemy
{
  public float maxScale = 5.0f;
  public float duration = 10.0f;

  // Start is called once before the first execution of Update after the MonoBehaviour is created
  void Start()
  {
		scoreMultiplier = 2;
		points = 5;
		direction = Vector2.right;
    StartCoroutine(InflationKink(maxScale, duration));
  }

  IEnumerator InflationKink(float targetScaleMultiplier, float timeToScale)
  {
    Vector2 initialScale = transform.localScale;
    Vector2 finalScale = initialScale * targetScaleMultiplier;
    float elapsed = 0;

    while (elapsed < timeToScale)
    {
      transform.localScale = Vector2.Lerp(initialScale, finalScale, (elapsed / timeToScale));
      elapsed += Time.deltaTime;
      yield return null;
    }

    transform.localScale = finalScale;
  }
}
