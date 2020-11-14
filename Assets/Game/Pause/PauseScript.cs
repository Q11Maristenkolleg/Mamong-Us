using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseScript : MonoBehaviour
{
    public GameObject pauseButton, pauseMenu;
    private bool _paused;
    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape) || Input.GetKeyDown(KeyCode.Joystick1Button6))
        {
            _paused = !_paused;
            pauseButton.SetActive(!_paused);
            pauseMenu.SetActive(_paused);
        }
    }

    public void Quit()
    {
        Application.Quit();
    }
}
