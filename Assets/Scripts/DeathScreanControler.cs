using System;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class DeathScreanControler : MonoBehaviour
{
    [SerializeField] private PlayerControler playerControler;
    [SerializeField] private GameObject deathScrean;
    [SerializeField] private Button retryButton;
    [SerializeField] private Button mainMenuButton;
    [SerializeField] private Button quitButton;
    private void Start() {
        playerControler.death += OnDeath;
        retryButton.onClick.AddListener(OnRetryButtonClicked);
        mainMenuButton.onClick.AddListener(OnMainMenuButtonCliked);
        quitButton.onClick.AddListener(OnQuitButtonClicked);
    }

    private void OnDestroy() {
        playerControler.death -= OnDeath;
        retryButton.onClick.RemoveListener(OnRetryButtonClicked);
        mainMenuButton.onClick.RemoveListener(OnMainMenuButtonCliked);
        quitButton.onClick.RemoveListener(OnQuitButtonClicked);
        
    }

    private void OnQuitButtonClicked()
    {
        Application.Quit();
    }

    private void OnRetryButtonClicked()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    private void OnDeath()
    {
        deathScrean.SetActive(true);
        Time.timeScale = 0;
    }
    
    private void OnMainMenuButtonCliked()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("Main menu");
    }
}
