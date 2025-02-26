using System;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{
	public GameObject pauseUI;
	public GameObject endUI;
	public GameObject healthBar;
	public GameObject pauseButton;

	void Update()
	{
		bool isEndUIActive = endUI.activeSelf;

		if (isEndUIActive== true)
		{
			//Stop Game
			Time.timeScale = 0;
			//Hide health bar 
			healthBar.SetActive(false);
			//Hide pause
			pauseButton.SetActive(false);
		}

	}

	//Restart Game
	public void OnRestartPress()
	{
		//restart game
		SceneManager.LoadScene(SceneManager.GetActiveScene().name);
		//Hide Pause Menu
		pauseUI.SetActive(false);
		//Hide End Game Menu
		endUI.SetActive(false);
		//Game Speed back to normal
		Time.timeScale = 1;
	}


	//Pause Game
	public void OnPausePress()
	{
		//Pause Game
		Time.timeScale = 0; //could use this to make game more difficult - speeding up
		//Show to Pause Menu
		pauseUI.SetActive(true);
	}

	//Return to Game
	public void OnGameResumePress() 
	{
		//Hide Pause Menu
		pauseUI.SetActive(false);
		//Hide End Game Menu
		endUI.SetActive(false);
		//Game Speed back to normal
		Time.timeScale = 1;
	}

	//End Game
	public void OnGameEndPress()
	{
		//Hide Pause Menu
		pauseUI.SetActive(false);
		//Hide End Game Menu
		endUI.SetActive(false);
		SceneManager.LoadScene(0);
	}
}
