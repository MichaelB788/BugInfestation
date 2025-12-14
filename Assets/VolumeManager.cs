using UnityEngine;
using UnityEngine.UI;

public class VolumeManager : MonoBehaviour
{
	public Slider volumeSlider;

	// Start is called once before the first execution of Update after the MonoBehaviour is created
	void Start()
	{
		if (PlayerPrefs.HasKey("MaxVolume"))
		{
			Load();
		}
		else
		{
			PlayerPrefs.SetFloat("MaxVolume", 1);
			Load();
		}
	}

	public void UpdateVolume()
	{
		AudioListener.volume = volumeSlider.value;
		Sync();
	}

	public void Load()
	{
		volumeSlider.value = PlayerPrefs.GetFloat("MaxVolume");
	}

	public void Sync()
	{
		PlayerPrefs.SetFloat("MaxVolume", volumeSlider.value);
	}
}
