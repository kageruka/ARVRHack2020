﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TransitionManager : MonoBehaviour
{
    // Start is called before the first frame update
    

void Update()
{
if(Input.GetKeyDown(KeyCode.Escape))
{
Application.Quit();
}
}
public void OpenGame()
{
SceneManager.LoadScene("Start");
}

public void QuitGame()
{
Application.Quit();
}

public void MenuGame()
{
SceneManager.LoadScene("Menu");
}


}