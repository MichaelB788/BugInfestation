using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
	public GameObject pauseMenu;
	private bool isPaused;

	// Start is called once before the first execution of Update after the MonoBehaviour is created
	void Start()
	{
		pauseMenu.SetActive(false);
		isPaused = false;
	}

	// Update is called once per frame
	void Update()
	{
		if (Input.GetKeyDown(KeyCode.Escape))
		{
			if (!isPaused)
			{
				Pause();
			}
			else
			{
				Resume();
			}
		}
	}

	public void Pause()
	{
		pauseMenu.SetActive(true);
		Time.timeScale = 0f;
		isPaused = true;
	}

	public void Resume()
	{
		pauseMenu.SetActive(false);
		Time.timeScale = 1f;
		isPaused = false;
	}

	public void MainMenu()
	{
		Time.timeScale = 1f;
		SceneManager.LoadScene(0);
	}

	public void Quit()
	{
		Application.Quit();
	}
}
