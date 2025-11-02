using UnityEngine;
using TMPro;

public class WinScreen : MonoBehaviour
{
	public TextMeshProUGUI textComponent;
	public float changeInterval = 2f;

	void Start()
	{
		InvokeRepeating("ChangeColor", 0f, changeInterval);
	}

	void ChangeColor()
	{
		textComponent.color = Random.ColorHSV(0f, 1f, 1f, 1f, 1f, 1f);
	}
}