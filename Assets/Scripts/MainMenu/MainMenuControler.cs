using System;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenuControler : MonoBehaviour
{
    [SerializeField] private GameObject mainMenu;
    [SerializeField] private GameObject credits;
    [SerializeField] private Button playButton;
    [SerializeField] private Button quitButton;
    [SerializeField] private Button creditsButon;
    [SerializeField] private Button creditsBackButton;

    private void Start() {
        playButton.onClick.AddListener(OnPlayButtonCliked);
        quitButton.onClick.AddListener(OnQuitButtonCliked);
        creditsButon.onClick.AddListener(OnCreditsButtonClicked);
        creditsBackButton.onClick.AddListener(OnCreditsBackButtonClicked);
    }


    private void OnDestroy() {
        playButton.onClick.RemoveListener(OnPlayButtonCliked);
        quitButton.onClick.RemoveListener(OnQuitButtonCliked);
        creditsButon.onClick.RemoveListener(OnCreditsButtonClicked);
        creditsBackButton.onClick.RemoveListener(OnCreditsBackButtonClicked);
    }
    private void OnPlayButtonCliked()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("Game");
    }

    private void OnQuitButtonCliked()
    {
        Application.Quit();
    }

    private void OnCreditsButtonClicked()
    {
        mainMenu.SetActive(false);
        credits.SetActive(true);
    }

    private void OnCreditsBackButtonClicked()
    {
        mainMenu.SetActive(true);
        credits.SetActive(false);
    }
}
