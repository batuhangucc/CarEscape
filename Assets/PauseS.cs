using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseS : MonoBehaviour
{
    [SerializeField] GameObject PauseMenu;
    [SerializeField] GameObject Char;

    public ScoreManager ScoreManager;

    public void Start()
    {
        ScoreManager = FindObjectOfType<ScoreManager>();

    }
    public void Pause()
    {
        PauseMenu.SetActive(true);
        Time.timeScale = 0f;
        ScoreManager.scoreIncreasing = false;

    }
    public void Resume()
    {
        PauseMenu.SetActive(false);
        Time.timeScale = 1f;
        ScoreManager.scoreIncreasing = true;

    }
    public void Shop()
    {
        PauseMenu.SetActive(false);
        Time.timeScale = 1f;
        ScoreManager.scoreIncreasing = false;
        Char.SetActive(true);

    }
    public void Home()
    {
        SceneManager.LoadScene("MenuScene");
        Time.timeScale = 1f;
    }
}
