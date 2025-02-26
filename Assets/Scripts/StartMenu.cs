using UnityEngine;
using UnityEngine.SceneManagement;

public class StartMenu : MonoBehaviour
{
	//Start Menu - start game
	public void OnStartPress()
	{
		SceneManager.LoadScene(1); //SceneManager.GetActiveScene().buildIndex + 1
		Time.timeScale = 1;
	}

	//Exit Game
	public void OnGameExitPress()
	{
		Application.Quit();
	}
}
