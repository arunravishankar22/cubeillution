using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class pauseMenu : MonoBehaviour
{
    public static bool GameisPaused = false;

    public GameObject pausemenu;

    //public GameObject postFX;


    //public Button FX;


    private void Start()
    {
        GameisPaused = false;
    }
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            if(GameisPaused)
            {
                Resume();
            }
            else
            {
                Pause();

            }
        }


    }

    public void Resume()
    {
        pausemenu.SetActive(false);
        //Time.timeScale = 1f;
        GameisPaused = false;
    }

    void Pause()
    {
        pausemenu.SetActive(true);
        //Time.timeScale = 0f;
        GameisPaused = true;
    }

    public void exit()
    {
        Application.Quit();
    }

    public void mainmanu()
    {
        SceneManager.LoadScene(0);
        
    }

    //public void PostpFX()
    //{
    //    postFX.SetActive(false);
    //    FX.enabled = false;
    //}
}
