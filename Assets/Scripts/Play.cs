using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Play : MonoBehaviour
{
    

    // Update is called once per frame
    void Update()
    {
      
    }
    public void ChangeScence()
    {
        SceneManager.LoadScene("Level1");
    }
    public void ChangeScence2()
    {
        SceneManager.LoadScene("Level2");
    }

    public void ShowInstrucions()
    {
        SceneManager.LoadScene("Instructions");
    }

    public void ShowMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }

    public void History()
    {
        SceneManager.LoadScene("History");
    }

    public void History1()
    {
        SceneManager.LoadScene("History1");
    }

    public void exitGame(){
        Application.Quit();
    }

    private void Start()
    {
        Cursor.lockState = CursorLockMode.None;
    }


}
