using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuController : MonoBehaviour
{
	[SerializeField] GameObject mainMenuPanel;
	[SerializeField] GameObject settingsMenuPanel;
	[SerializeField] GameObject audioDisplayMenuPanel;
	[SerializeField] GameObject controlSchemeMenuPanel;


	public void PlayGame(int sceneIndex)
	{
		SceneManager.LoadScene(sceneIndex);
	}
	public void OpenSettings()
	{
		mainMenuPanel.SetActive(false);
		audioDisplayMenuPanel.SetActive(false);
		controlSchemeMenuPanel.SetActive(false);

		settingsMenuPanel.SetActive(true);
	}
	public void OpenAudioDisplaySettings()
	{
		mainMenuPanel.SetActive(false);
		controlSchemeMenuPanel.SetActive(false);
		settingsMenuPanel.SetActive(false);

		audioDisplayMenuPanel.SetActive(true);
	}
	public void OpenControlSchemeSettings()
	{
		mainMenuPanel.SetActive(false);
		audioDisplayMenuPanel.SetActive(false);
		settingsMenuPanel.SetActive(false);

		controlSchemeMenuPanel.SetActive(true);
	}
	public void ReturnFromSettings()
	{
		settingsMenuPanel.SetActive(false);
		mainMenuPanel.SetActive(true);
	}
	public void ReturnToSettings()
	{
		audioDisplayMenuPanel.SetActive(false);
		controlSchemeMenuPanel.SetActive(false);
		settingsMenuPanel.SetActive(true);
	}
	public void ExitGame()
	{
		Application.Quit();
	}
}
