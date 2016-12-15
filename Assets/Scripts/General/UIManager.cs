using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class UIManager : MonoBehaviour {

	private bool lvlStarted;
	public DrinkController.Ingredient currIng;
	public PlayerInventory inventory;
	private GameObject startMenu;
	public GameObject gameOverMenu;
	// Use this for initialization
	void Start () {
		lvlStarted = false;
		Time.timeScale = 0;
		startMenu = GameObject.FindGameObjectWithTag ("StartMenu");

		if (gameOverMenu == null) {
			gameOverMenu = GameObject.FindGameObjectWithTag ("GameOverMenu");
		}

		showStartMenu ();
		hideGameOverMenu ();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void hideGameOverMenu(){
		gameOverMenu.SetActive (false);
	}

	public void showGameOverMenu(){
		gameOverMenu.SetActive (true);
		hideStartMenu();
	}

	private void hideStartMenu(){
		startMenu.SetActive (false);
	}

	private void showStartMenu(){
		startMenu.SetActive (true);
	}

	public void PauseControl(){
		if (Time.timeScale == 1) {
			Time.timeScale = 0;
		} else if (Time.timeScale == 1) {
			Time.timeScale = 0;
		}
	}

	public void StartGame(){
		Time.timeScale = 1;
		hideStartMenu ();
	}

	public void QuitGame(){
		Application.Quit ();
	}

	public void RestartGame(){
		SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
	}
}
