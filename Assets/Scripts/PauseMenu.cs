using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class PauseMenu : MonoBehaviour
{
    public GameObject pause;

    private bool isPaused = false;
    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 1.0f;
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Escape))
            TogglePause();
        
    }

    public void TogglePause()
    {
        pause.SetActive(!pause.activeSelf);
        isPaused = !isPaused;
        Time.timeScale = isPaused ? 0.0f : 1.0f;
    }

    public void MenuScene()
    {
        SceneManager.LoadScene("MainMenu");
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}