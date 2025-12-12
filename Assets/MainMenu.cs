using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
	public void PlayGame()
	{
		SceneManager.LoadScene(1);
	}

	public void Instructions()
	{
		SceneManager.LoadScene(5);
	}
	public void Settings()
	{
		SceneManager.LoadScene(6);
	}

	public void BackToMain()
	{
		SceneManager.LoadScene(0);
	}
}
