using TMPro;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
	public TextMeshProUGUI scoreUI;
  private uint score = 0;

	// Start is called once before the first execution of Update after the MonoBehaviour is created
	void Start()
	{
		scoreUI = GetComponent<TextMeshProUGUI>();
		scoreUI.text = "Score: ";
	}

	// Update is called once per frame
	void Update()
	{
		scoreUI.text = "Score: " + score.ToString();
	}

	public void IncrementScore(uint points, float scoreMultiplier)
	{
		score += (uint)(points * scoreMultiplier);
	}
}
