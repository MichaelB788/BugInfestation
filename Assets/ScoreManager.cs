using TMPro;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
	public TextMeshProUGUI scoreUI;
  private int score = 0;

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

	public void IncrementScore(int points, float scoreMultiplier)
	{
		score += (int)(points * scoreMultiplier);
	}
}
