﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Play : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

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

    public void EndGame()
    {
        SceneManager.LoadScene("GameOver");
    }
    public void Again()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    
}
